using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xbfab86fa : MonoBehaviour
{
    private static float Linear(float _0x1a7b635d)
    {
        _0x1a7b635d = Mathf.Clamp01(_0x1a7b635d);
        return _0x1a7b635d <= 0.03928f ? _0x1a7b635d / 12.92f : Mathf.Pow((_0x1a7b635d + 0.055f) / 1.055f, 2.4f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x19cd8125 != null)
            return;
        GameObject _0x03a47410 = new GameObject(_0xe64577bf._0x21aa6feb(new byte[16] { 253, 196, 217, 234, 198, 199, 221, 219, 200, 218, 221, 238, 220, 200, 219, 205 }, 169));
        _0x03a47410.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x03a47410);
        _0x19cd8125 = _0x03a47410.AddComponent<_0xbfab86fa>();
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x911ef9c5;
    private void OnDisable()
    {
        if (this._0x911ef9c5 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x911ef9c5);
    }

    private void OnEnable()
    {
        if (this._0x911ef9c5 == null)
            this._0x911ef9c5 = _0x0c31c94f => this._0xee372d73(_0x0c31c94f);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x911ef9c5);
    }

    private readonly HashSet<TMP_Text> _0xa5675845 = new HashSet<TMP_Text>();
    private static float Ratio(Color _0x6174f340, Color _0x763a6119)
    {
        float _0x6a87a7b5 = Luminance(_0x6174f340);
        float _0xcb057e69 = Luminance(_0x763a6119);
        return (Mathf.Max(_0x6a87a7b5, _0xcb057e69) + 0.05f) / (Mathf.Min(_0x6a87a7b5, _0xcb057e69) + 0.05f);
    }

    private readonly List<TMP_Text> _0xfbe0ce81 = new List<TMP_Text>();
    private const float TargetRatio = 7f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xee372d73(Object _0xf114514c)
    {
        TMP_Text _0xc2797854 = _0xf114514c as TMP_Text;
        if (_0xc2797854 != null)
            this._0xa5675845.Add(_0xc2797854);
    }

    private const float MinRatio = 4.5f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x1c5b4658)
    {
        return 0.2126f * Linear(_0x1c5b4658.r) + 0.7152f * Linear(_0x1c5b4658.g) + 0.0722f * Linear(_0x1c5b4658.b);
    }

    private static void Fix(TMP_Text _0x4475e22c)
    {
        if (_0x4475e22c == null || !_0x4475e22c.isActiveAndEnabled)
            return;
        Material _0x61ffe658 = _0x4475e22c.fontSharedMaterial;
        if (_0x61ffe658 == null || !_0x61ffe658.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x61ffe658.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x61ffe658.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x21d4c52f = _0x4475e22c.color;
        if (_0x21d4c52f.a <= 0f)
            return;
        Color _0x1836ea90 = _0x61ffe658.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x21d4c52f, _0x1836ea90) >= MinRatio)
            return;
        Color _0xffaa4984 = Luminance(_0x1836ea90) < 0.5f ? Color.white : Color.black;
        Color _0x94ef3f11;
        if (Ratio(_0xffaa4984, _0x1836ea90) < TargetRatio)
        {
            _0x94ef3f11 = _0xffaa4984;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xbcfc4189 = 0f;
            float _0xc2ef9585 = 1f;
            for (int _0x28a765d2 = 0; _0x28a765d2 < 20; _0x28a765d2++)
            {
                float _0x24411c5c = (_0xbcfc4189 + _0xc2ef9585) * 0.5f;
                if (Ratio(Color.Lerp(_0x21d4c52f, _0xffaa4984, _0x24411c5c), _0x1836ea90) >= TargetRatio)
                    _0xc2ef9585 = _0x24411c5c;
                else
                    _0xbcfc4189 = _0x24411c5c;
            }

            _0x94ef3f11 = Color.Lerp(_0x21d4c52f, _0xffaa4984, _0xc2ef9585);
        }

        _0x94ef3f11.a = _0x21d4c52f.a;
        _0x4475e22c.color = _0x94ef3f11;
    }

    private const float MinOutlineWidth = 0.01f;
    private void LateUpdate()
    {
        if (this._0xa5675845.Count == 0)
            return;
        this._0xfbe0ce81.Clear();
        this._0xfbe0ce81.AddRange(this._0xa5675845);
        this._0xa5675845.Clear();
        for (int _0xd6a739cb = 0; _0xd6a739cb < this._0xfbe0ce81.Count; _0xd6a739cb++)
            Fix(this._0xfbe0ce81[_0xd6a739cb]);
    }

    private static _0xbfab86fa _0x19cd8125;
}

internal static class _0xe64577bf
{
    internal static string _0x21aa6feb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}