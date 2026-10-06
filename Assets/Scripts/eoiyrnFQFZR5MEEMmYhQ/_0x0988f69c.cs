using TMPro;
using UnityEngine;

/// One place that decides how a label behaves: light face, no engine word wrap,
/// autosize always on with a readable floor, line breaks only where the author
/// put them (rules C.10 and C.12).
internal static class _0x0988f69c
{
    public const float UiFloor = 34f;
    /// Set a label's text, keeping the house rules intact. Line breaks belong in
    /// the string the caller passes, never in the engine's hands.
    public static void SetText(TMP_Text _0x6c2714c1, string _0xc953a5dd)
    {
        if (_0x6c2714c1 == null)
            return;
        _0x6c2714c1.textWrappingMode = TextWrappingModes.NoWrap;
        _0x6c2714c1.enableAutoSizing = true;
        _0x6c2714c1.text = _0xc953a5dd == null ? string.Empty : _0xc953a5dd;
    }

    /// Set text and face colour in one call.
    public static void SetText(TMP_Text _0xd7672558, string _0x6662a522, Color _0x923d3832)
    {
        if (_0xd7672558 == null)
            return;
        _0xd7672558.color = _0x923d3832;
        SetText(_0xd7672558, _0x6662a522);
    }

    /// Apply the house rules to a label and give it a face colour.
    public static void Apply(TMP_Text _0x53d773a1, Color _0xe41f0b5b, float _0xc1ed0661, float _0xaf3d8448)
    {
        if (_0x53d773a1 == null)
            return;
        _0x53d773a1.color = _0xe41f0b5b;
        _0x53d773a1.textWrappingMode = TextWrappingModes.NoWrap;
        _0x53d773a1.overflowMode = TextOverflowModes.Overflow;
        _0x53d773a1.enableAutoSizing = true;
        _0x53d773a1.fontSizeMin = _0xc1ed0661 < UiFloor ? UiFloor : _0xc1ed0661;
        _0x53d773a1.fontSizeMax = _0xaf3d8448 < _0x53d773a1.fontSizeMin ? _0x53d773a1.fontSizeMin : _0xaf3d8448;
    }

    /// Blank a label without disturbing anything else.
    public static void Clear(TMP_Text _0xd5c1ae0d)
    {
        if (_0xd5c1ae0d == null)
            return;
        _0xd5c1ae0d.text = string.Empty;
    }
}