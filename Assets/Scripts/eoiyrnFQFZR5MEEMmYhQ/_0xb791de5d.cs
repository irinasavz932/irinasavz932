using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The three route cards on the sheet. Choosing one changes three visible things at
/// once — the selected card's rim, a punch on its crest and the preview line under
/// the list — because a caption swap on its own is not an answer the player can see
/// (rule C.7).
public sealed class _0xb791de5d : MonoBehaviour
{
    [SerializeField]
    private Button _cardButtonTwo;
    private void _0x02f04ba8(int _0xc933ea30, bool _0xf88e43c5)
    {
        int _0x7ca88872 = _0x44394cff.Clamp(_0xc933ea30);
        // Three things move at once, because a rim alone does not read on a screenshot:
        // the rim brightens, the whole card face lifts out of the dim state, and the
        // crest of the chosen route punches.
        this._0x358af200(this._cardRimOne, this._cardFaceOne, _0x7ca88872 == 0);
        this._0x358af200(this._cardRimTwo, this._cardFaceTwo, _0x7ca88872 == 1);
        this._0x358af200(this._cardRimThree, this._cardFaceThree, _0x7ca88872 == 2);
        if (_0xf88e43c5)
        {
            RectTransform _0x61af2cee = _0x7ca88872 == 0 ? this._crestOne : (_0x7ca88872 == 1 ? this._crestTwo : this._crestThree);
            if (_0x61af2cee != null)
                _0x61af2cee.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.35f, 7, 0.7f);
        }

        _0x0988f69c.SetText(this._previewLabel, _0x44394cff.RouteName(_0x7ca88872) + _0x87baf9c5._0xec82c928(new byte[5] { 144, 144, 157, 144, 144 }, 176) + _0x44394cff.GateTarget(_0x7ca88872) + _0x87baf9c5._0xec82c928(new byte[11] { 74, 45, 43, 62, 47, 57, 74, 74, 71, 74, 74 }, 106) + _0x44394cff.PassiveSeconds(_0x7ca88872) + _0x87baf9c5._0xec82c928(new byte[10] { 27, 104, 27, 107, 122, 104, 104, 114, 109, 126 }, 59));
    }

    [SerializeField]
    private TMP_Text _detailThree;
    [SerializeField]
    private TMP_Text _nameThree;
    [SerializeField]
    private TMP_Text _paceThree;
    [SerializeField]
    private TMP_Text _paceOne;
    [SerializeField]
    private Image _cardRimTwo;
    [SerializeField]
    private Image _cardRimThree;
    [SerializeField]
    private RectTransform _crestTwo;
    [SerializeField]
    private TMP_Text _detailOne;
    [SerializeField]
    private TMP_Text _previewLabel;
    [SerializeField]
    private Image _cardFaceThree;
    [SerializeField]
    private TMP_Text _nameTwo;
    [SerializeField]
    private TMP_Text _nameOne;
    [SerializeField]
    private TMP_Text _emptyLabel;
    private void _0xbb59f131(int _0x81c37101, TMP_Text _0xf87e7d5c, TMP_Text _0x49610ade, TMP_Text _0x9ee07828)
    {
        _0x0988f69c.Apply(_0xf87e7d5c, _0x4f5b9c84._0x53c78623, 44f, 54f);
        _0x0988f69c.Apply(_0x49610ade, _0x4f5b9c84._0x53c78623, 36f, 44f);
        _0x0988f69c.Apply(_0x9ee07828, _0x4f5b9c84._0xe1ed2d6d, 36f, 44f);
        _0x0988f69c.SetText(_0xf87e7d5c, _0x44394cff.RouteName(_0x81c37101));
        _0x0988f69c.SetText(_0x49610ade, _0x44394cff.GateTarget(_0x81c37101) + _0x87baf9c5._0xec82c928(new byte[9] { 15, 104, 110, 123, 106, 124, 15, 2, 15 }, 47) + _0x44394cff.ColourCount(_0x81c37101) + _0x87baf9c5._0xec82c928(new byte[8] { 179, 208, 220, 223, 220, 198, 193, 192 }, 147));
        _0x0988f69c.SetText(_0x9ee07828, _0x87baf9c5._0xec82c928(new byte[5] { 205, 220, 222, 216, 189 }, 157) + _0x44394cff.PaceName(_0x81c37101));
    }

    [SerializeField]
    private Image _cardRimOne;
    [SerializeField]
    private TMP_Text _paceTwo;
    [SerializeField]
    private Button _cardButtonThree;
    private void _0x358af200(Image _0x75a13eb6, Image _0x0421ab9d, bool _0xcb66ad8e)
    {
        if (_0x75a13eb6 != null)
            _0x75a13eb6.color = _0xcb66ad8e ? _0x4f5b9c84._0xe1ed2d6d : _0x4f5b9c84.Fade(_0x4f5b9c84._0x788b18b3, 0.35f);
        if (_0x0421ab9d != null)
            _0x0421ab9d.color = _0xcb66ad8e ? _0x4f5b9c84._0x6349cce2 : _0x4f5b9c84._0x9dc279f8;
    }

    [SerializeField]
    private TMP_Text _detailTwo;
    private void Start()
    {
        this._0xbb59f131(0, this._nameOne, this._detailOne, this._paceOne);
        this._0xbb59f131(1, this._nameTwo, this._detailTwo, this._paceTwo);
        this._0xbb59f131(2, this._nameThree, this._detailThree, this._paceThree);
        _0x0988f69c.Apply(this._previewLabel, _0x4f5b9c84._0x53c78623, 36f, 44f);
        _0x0988f69c.Apply(this._emptyLabel, _0x4f5b9c84._0x788b18b3, 36f, 44f);
        // Three routes always exist, so the empty-state line stays out of the way -
        // it is here for the day the list is filtered down to nothing.
        if (this._emptyLabel != null)
            this._emptyLabel.gameObject.SetActive(false);
        if (this._cardButtonOne != null)
            this._cardButtonOne.onClick.AddListener(() => this._0xf43b98b3(0));
        if (this._cardButtonTwo != null)
            this._cardButtonTwo.onClick.AddListener(() => this._0xf43b98b3(1));
        if (this._cardButtonThree != null)
            this._cardButtonThree.onClick.AddListener(() => this._0xf43b98b3(2));
        this._0x02f04ba8(_0xbcb3a21c._0x6971edd3, false);
    }

    [SerializeField]
    private Image _cardFaceOne;
    private void _0xf43b98b3(int _0x01c0f116)
    {
        _0xbcb3a21c._0x6971edd3 = _0x01c0f116;
        this._0x02f04ba8(_0x01c0f116, true);
    }

    [SerializeField]
    private RectTransform _crestOne;
    [SerializeField]
    private Button _cardButtonOne;
    [SerializeField]
    private RectTransform _crestThree;
    [SerializeField]
    private Image _cardFaceTwo;
}

internal static class _0x87baf9c5
{
    internal static string _0xec82c928(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}