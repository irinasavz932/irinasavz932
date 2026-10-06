using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The readouts over the flight: the colour queue, the energy quill, the gate
/// counter, the three strike pips, the permanent gesture hint and the opening
/// ribbon that shows the whole colour order before the first ring arrives.
public sealed class _0xa38770b5 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _queueLabelNext;
    [SerializeField]
    private Image _strikePipTwo;
    [SerializeField]
    private Image _energyFill;
    private const int PreviewPerRow = 6;
    [SerializeField]
    private GameObject _previewChipPrefab;
    /// A short line over the lane: what just happened and why.
    public void _0x920553a2(string _0xefacf735, Color _0xda943e6c)
    {
        if (this._flashText == null)
            return;
        if (this._0x0ecefc94 != null)
            this._0x0ecefc94.Kill();
        this._flashText.color = _0xda943e6c;
        _0x0988f69c.SetText(this._flashText, _0xefacf735);
        this._0x0ecefc94 = DOTween.Sequence().AppendInterval(0.9f).Append(DOTween.To(() => this._flashText.alpha, _0xcc517b71 => this._flashText.alpha = _0xcc517b71, 0f, 0.35f)).AppendCallback(() => this._0x3bdd40f7());
    }

    [SerializeField]
    private TMP_Text _hintText;
    private void _0xf5f7ea9f(Image _0x15bf68a7, TMP_Text _0x8a810bc5, int _0xbe93ed21)
    {
        if (_0x15bf68a7 != null)
        {
            _0x15bf68a7.enabled = _0xbe93ed21 >= 0;
            if (_0xbe93ed21 >= 0)
                _0x15bf68a7.color = _0x4f5b9c84.GateColour(_0xbe93ed21);
        }

        if (_0x8a810bc5 != null)
        {
            _0x0988f69c.SetText(_0x8a810bc5, _0xbe93ed21 >= 0 ? _0x4f5b9c84.GateColourName(_0xbe93ed21) : string.Empty);
        }
    }

    /// Lay the whole colour chain out as two rows of chips over the HUD.
    public void _0x7ff05bbf(_0xe2597f34 _0x9044a978, int _0xb564af1f)
    {
        if (this._previewRoot == null || this._previewStrip == null || this._previewChipPrefab == null)
            return;
        if (_0x9044a978 == null)
            return;
        int _0x10a7bad6 = _0xb564af1f > 12 ? 12 : _0xb564af1f;
        for (int _0xa591a4a6 = 0; _0xa591a4a6 < _0x10a7bad6; _0xa591a4a6++)
        {
            GameObject _0x494b76d3 = Instantiate(this._previewChipPrefab, this._previewStrip);
            RectTransform _0xbb3017c2 = _0x494b76d3.transform as RectTransform;
            if (_0xbb3017c2 != null)
            {
                int _0x799fbed8 = _0xa591a4a6 / PreviewPerRow;
                int _0xb83d9f80 = _0xa591a4a6 % PreviewPerRow;
                float width = (PreviewPerRow - 1) * 112f;
                _0xbb3017c2.anchoredPosition = new Vector2(_0xb83d9f80 * 112f - width * 0.5f, _0x799fbed8 == 0 ? 60f : -60f);
            }

            Image _0xc05a17de = _0x494b76d3.GetComponent<Image>();
            if (_0xc05a17de != null)
                _0xc05a17de.color = _0x4f5b9c84.GateColour(_0x9044a978._0xcd8f98a9(_0xa591a4a6));
        }

        this._previewRoot.SetActive(true);
    }

    public void _0x3725d385(float _0xa1706a54)
    {
        if (this._energyFill == null)
            return;
        float _0xc511a1bd = _0xa1706a54 < 0f ? 0f : (_0xa1706a54 > 1f ? 1f : _0xa1706a54);
        this._energyFill.fillAmount = _0xc511a1bd;
        this._energyFill.color = _0xc511a1bd < 0.25f ? _0x4f5b9c84._0x96f3147f : _0x4f5b9c84._0xe1ed2d6d;
    }

    /// Dim one pip per strike and punch it so the loss is felt, not just counted.
    public void _0x1d017a0b(int _0x5dc47843)
    {
        this._0xf4ecd6f8(this._strikePipOne, _0x5dc47843 >= 1);
        this._0xf4ecd6f8(this._strikePipTwo, _0x5dc47843 >= 2);
        this._0xf4ecd6f8(this._strikePipThree, _0x5dc47843 >= 3);
    }

    [SerializeField]
    private Image _queueChipMain;
    private void OnDestroy()
    {
        if (this._0x0ecefc94 != null)
            this._0x0ecefc94.Kill();
    }

    /// Dim the hint after the opening seconds, but never hide it.
    public void _0x3894cd2c()
    {
        if (this._hintText == null)
            return;
        this._hintText.color = _0x4f5b9c84.Fade(_0x4f5b9c84._0x53c78623, 0.55f);
    }

    /// The colour the next three rows are asking for. -1 blanks a chip.
    public void _0x3052574a(int _0x02f8130c, int _0x6a7fc7f1, int _0x3c3f1891)
    {
        this._0xf5f7ea9f(this._queueChipMain, this._queueLabelMain, _0x02f8130c);
        this._0xf5f7ea9f(this._queueChipNext, this._queueLabelNext, _0x6a7fc7f1);
        this._0xf5f7ea9f(this._queueChipThird, this._queueLabelThird, _0x3c3f1891);
    }

    private void _0xf4ecd6f8(Image _0xbbf7bea7, bool _0x4426a4fc)
    {
        if (_0xbbf7bea7 == null)
            return;
        Color _0xc3ebb92e = _0x4426a4fc ? _0x4f5b9c84._0x49501795 : _0x4f5b9c84._0xe1ed2d6d;
        if (_0xbbf7bea7.color != _0xc3ebb92e && _0x4426a4fc)
        {
            RectTransform _0x26342665 = _0xbbf7bea7.transform as RectTransform;
            if (_0x26342665 != null)
                _0x26342665.DOPunchScale(new Vector3(0.2f, 0.2f, 0f), 0.3f, 6, 0.6f);
        }

        _0xbbf7bea7.color = _0xc3ebb92e;
    }

    public void _0x336ab0ce(int _0xe359fd3f, int _0xbc08d59b)
    {
        _0x0988f69c.SetText(this._progressText, _0x7954c9e1._0x8f49548b(new byte[6] { 209, 215, 194, 211, 197, 182 }, 150) + _0xe359fd3f + _0x7954c9e1._0x8f49548b(new byte[3] { 141, 130, 141 }, 173) + _0xbc08d59b);
    }

    [SerializeField]
    private TMP_Text _progressText;
    private void _0x3bdd40f7()
    {
        if (this._flashText == null)
            return;
        _0x0988f69c.SetText(this._flashText, string.Empty);
        this._flashText.alpha = 1f;
    }

    [SerializeField]
    private TMP_Text _flashText;
    private void _0x1fe51e0d()
    {
        if (this._previewRoot != null)
            this._previewRoot.SetActive(false);
    }

    /// Fade the opening ribbon away once the first ring is close.
    public void _0x313a5541()
    {
        if (this._previewRoot == null)
            return;
        CanvasGroup _0x5698e935 = this._previewRoot.GetComponent<CanvasGroup>();
        if (_0x5698e935 == null)
        {
            this._previewRoot.SetActive(false);
            return;
        }

        DOTween.To(() => _0x5698e935.alpha, _0xcc517b71 => _0x5698e935.alpha = _0xcc517b71, 0f, 0.4f).SetTarget(_0x5698e935).OnComplete(() => this._0x1fe51e0d());
    }

    /// Dress every label once, then let the per-frame setters only change values.
    public void _0x85d3111d()
    {
        _0x0988f69c.Apply(this._queueLabelMain, _0x4f5b9c84._0x53c78623, 36f, 44f);
        _0x0988f69c.Apply(this._queueLabelNext, _0x4f5b9c84._0x53c78623, 34f, 38f);
        _0x0988f69c.Apply(this._queueLabelThird, _0x4f5b9c84._0x53c78623, 34f, 38f);
        _0x0988f69c.Apply(this._progressText, _0x4f5b9c84._0x53c78623, 38f, 48f);
        _0x0988f69c.Apply(this._hintText, _0x4f5b9c84._0x53c78623, 42f, 52f);
        _0x0988f69c.Apply(this._flashText, _0x4f5b9c84._0xe1ed2d6d, 44f, 60f);
        _0x0988f69c.Apply(this._previewLabel, _0x4f5b9c84._0x53c78623, 40f, 54f);
        // The gesture and what it does, in that order, and it never leaves the screen.
        _0x0988f69c.SetText(this._hintText, _0x7954c9e1._0x8f49548b(new byte[29] { 156, 155, 152, 144, 244, 128, 155, 244, 135, 131, 157, 154, 147, 222, 134, 145, 152, 145, 149, 135, 145, 244, 128, 155, 244, 144, 149, 135, 156 }, 212));
        _0x0988f69c.SetText(this._flashText, string.Empty);
        if (this._previewLabel != null)
            _0x0988f69c.SetText(this._previewLabel, _0x7954c9e1._0x8f49548b(new byte[18] { 171, 188, 180, 188, 180, 187, 188, 171, 217, 173, 177, 188, 217, 182, 171, 189, 188, 171 }, 249));
    }

    [SerializeField]
    private TMP_Text _previewLabel;
    [SerializeField]
    private Image _strikePipThree;
    [SerializeField]
    private TMP_Text _queueLabelThird;
    private Tween _0x0ecefc94;
    [SerializeField]
    private TMP_Text _queueLabelMain;
    [SerializeField]
    private Image _strikePipOne;
    [SerializeField]
    private Image _queueChipThird;
    [SerializeField]
    private Image _queueChipNext;
    [SerializeField]
    private RectTransform _previewStrip;
    [SerializeField]
    private GameObject _previewRoot;
}

internal static class _0x7954c9e1
{
    internal static string _0x8f49548b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}