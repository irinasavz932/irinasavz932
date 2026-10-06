using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The menu, as three views inside the template's own DefaultPanel: the home card,
/// the route sheet and the how-to-fly sheet. Switching between them is a local
/// matter, so it never touches the panel pool the template addresses by index.
public sealed class _0x4ec3746f : MonoBehaviour
{
    private void _0x936aa408(RectTransform _0x4d7426af, float _0x985d6a1b)
    {
        if (_0x4d7426af == null)
            return;
        _0x4d7426af.localScale = new Vector3(0.9f, 0.9f, 1f);
        _0x4d7426af.DOScale(1f, 0.28f).SetDelay(_0x985d6a1b).SetEase(Ease.OutBack);
    }

    [SerializeField]
    private RectTransform _playButtonFace;
    [SerializeField]
    private TMP_Text _stampsValue;
    [SerializeField]
    private TMP_Text _routeSheetTitle;
    [SerializeField]
    private TMP_Text _stepTitleThree;
    [SerializeField]
    private RectTransform _howToButtonRect;
    private void _0x0d631378()
    {
        if (this._heroCard != null)
        {
            Vector2 _0x94b338ed = this._heroCard.anchoredPosition;
            this._heroCard.anchoredPosition = _0x94b338ed + new Vector2(0f, 140f);
            this._heroCard.DOAnchorPos(_0x94b338ed, 0.45f).SetEase(Ease.OutCubic);
        }

        this._0x936aa408(this._playButtonFace, 0f);
        this._0x936aa408(this._routesButtonRect, 0.06f);
        this._0x936aa408(this._howToButtonRect, 0.12f);
    }

    [SerializeField]
    private Button _routesButton;
    [SerializeField]
    private Button _routeCloseButton;
    private void _0x99865beb(TMP_Text _0x85bc51f3, TMP_Text _0xd8ec4fa6, string _0x83219bd6, string _0xfb966082)
    {
        _0x0988f69c.Apply(_0x85bc51f3, _0x4f5b9c84._0xe1ed2d6d, 44f, 54f);
        _0x0988f69c.Apply(_0xd8ec4fa6, _0x4f5b9c84._0x53c78623, 40f, 48f);
        _0x0988f69c.SetText(_0x85bc51f3, _0x83219bd6);
        _0x0988f69c.SetText(_0xd8ec4fa6, _0xfb966082);
    }

    [SerializeField]
    private TMP_Text _routesLabel;
    [SerializeField]
    private Button _howToBackButton;
    [SerializeField]
    private _0x805ada77 _homeGate;
    private void _0xab5b3349()
    {
        if (this._routeGate != null)
            this._routeGate._0x1fd8e5c9(true);
        if (this._howToGate != null)
            this._howToGate._0x1fd8e5c9(false);
    }

    [SerializeField]
    private TMP_Text _bestRunLabel;
    [SerializeField]
    private TMP_Text _stepTitleTwo;
    [SerializeField]
    private TMP_Text _playLabel;
    [SerializeField]
    private TMP_Text _objectiveLabel;
    [SerializeField]
    private TMP_Text _howToLabel;
    [SerializeField]
    private _0xc6291a4c _stampsCounter;
    [SerializeField]
    private TMP_Text _stepBodyOne;
    private void _0x8b7c25b6()
    {
        if (this._routeGate != null)
            this._routeGate._0x1fd8e5c9(false);
        if (this._howToGate != null)
            this._howToGate._0x1fd8e5c9(false);
        if (this._homeGate != null)
            this._homeGate._0x1fd8e5c9(true);
    }

    [SerializeField]
    private TMP_Text _stepTitleOne;
    [SerializeField]
    private Button _howToButton;
    private void Start()
    {
        this._0x0a3f333b();
        if (this._stampsCounter != null)
            this._stampsCounter._0x83e32f13();
        if (this._routesButton != null)
            this._routesButton.onClick.AddListener(() => this._0xab5b3349());
        if (this._howToButton != null)
            this._howToButton.onClick.AddListener(() => this._0x49b40014());
        if (this._routeCloseButton != null)
            this._routeCloseButton.onClick.AddListener(() => this._0x8b7c25b6());
        if (this._howToBackButton != null)
            this._howToBackButton.onClick.AddListener(() => this._0x8b7c25b6());
        this._0x8b7c25b6();
        this._0x0d631378();
    }

    [SerializeField]
    private _0x805ada77 _howToGate;
    private void _0x49b40014()
    {
        if (this._howToGate != null)
            this._howToGate._0x1fd8e5c9(true);
        if (this._routeGate != null)
            this._routeGate._0x1fd8e5c9(false);
    }

    [SerializeField]
    private TMP_Text _stampsCaption;
    private void _0x0a3f333b()
    {
        _0x0988f69c.Apply(this._objectiveLabel, _0x4f5b9c84._0x53c78623, 48f, 64f);
        _0x0988f69c.Apply(this._stampsCaption, _0x4f5b9c84._0xe1ed2d6d, 36f, 44f);
        _0x0988f69c.Apply(this._stampsValue, _0x4f5b9c84._0x53c78623, 44f, 56f);
        _0x0988f69c.Apply(this._bestRunLabel, _0x4f5b9c84._0x53c78623, 36f, 44f);
        _0x0988f69c.Apply(this._playLabel, _0x4f5b9c84._0x53c78623, 52f, 64f);
        _0x0988f69c.Apply(this._routesLabel, _0x4f5b9c84._0x53c78623, 42f, 52f);
        _0x0988f69c.Apply(this._howToLabel, _0x4f5b9c84._0x53c78623, 42f, 52f);
        _0x0988f69c.Apply(this._howToTitle, _0x4f5b9c84._0xe1ed2d6d, 48f, 64f);
        _0x0988f69c.Apply(this._routeSheetTitle, _0x4f5b9c84._0xe1ed2d6d, 52f, 64f);
        _0x0988f69c.SetText(this._objectiveLabel, _0xb34f37e9._0xaa23e1b8(new byte[18] { 13, 12, 5, 0, 31, 12, 27, 105, 29, 1, 12, 105, 5, 12, 29, 29, 12, 27 }, 73));
        _0x0988f69c.SetText(this._stampsCaption, _0xb34f37e9._0xaa23e1b8(new byte[6] { 8, 15, 26, 22, 11, 8 }, 91));
        _0x0988f69c.SetText(this._playLabel, _0xb34f37e9._0xaa23e1b8(new byte[12] { 79, 72, 93, 78, 72, 60, 90, 80, 85, 91, 84, 72 }, 28));
        _0x0988f69c.SetText(this._routesLabel, _0xb34f37e9._0xaa23e1b8(new byte[6] { 169, 180, 174, 175, 190, 168 }, 251));
        _0x0988f69c.SetText(this._howToLabel, _0xb34f37e9._0xaa23e1b8(new byte[10] { 188, 187, 163, 212, 160, 187, 212, 178, 184, 173 }, 244));
        _0x0988f69c.SetText(this._howToTitle, _0xb34f37e9._0xaa23e1b8(new byte[10] { 85, 82, 74, 61, 73, 82, 61, 91, 81, 68 }, 29));
        _0x0988f69c.SetText(this._routeSheetTitle, _0xb34f37e9._0xaa23e1b8(new byte[14] { 36, 47, 40, 40, 52, 34, 71, 38, 71, 53, 40, 50, 51, 34 }, 103));
        // No run yet is a state, not an empty line: say what to do instead.
        if (_0xbcb3a21c._0xe6d389b0)
        {
            _0x0988f69c.SetText(this._bestRunLabel, _0xb34f37e9._0xaa23e1b8(new byte[10] { 173, 170, 188, 187, 207, 189, 186, 161, 207, 207 }, 239) + _0xbcb3a21c._0x36591e5d + _0xb34f37e9._0xaa23e1b8(new byte[3] { 54, 57, 54 }, 22) + _0xbcb3a21c._0x139e76b0 + _0xb34f37e9._0xaa23e1b8(new byte[14] { 80, 80, 12, 80, 80, 49, 51, 51, 37, 34, 49, 51, 41, 80 }, 112) + _0xbcb3a21c._0x8167c850 + _0xb34f37e9._0xaa23e1b8(new byte[1] { 207 }, 234));
        }
        else
        {
            _0x0988f69c.SetText(this._bestRunLabel, _0xb34f37e9._0xaa23e1b8(new byte[31] { 224, 225, 142, 232, 226, 231, 233, 230, 250, 253, 142, 247, 235, 250, 142, 142, 210, 142, 142, 254, 231, 237, 229, 142, 239, 142, 252, 225, 251, 250, 235 }, 174));
        }

        this._0x99865beb(this._stepTitleOne, this._stepBodyOne, _0xb34f37e9._0xaa23e1b8(new byte[13] { 133, 130, 129, 137, 237, 140, 131, 148, 154, 133, 136, 159, 136 }, 205), _0xb34f37e9._0xaa23e1b8(new byte[32] { 69, 89, 84, 49, 82, 94, 68, 67, 88, 84, 67, 49, 66, 70, 88, 95, 86, 66, 27, 80, 93, 94, 95, 86, 49, 69, 89, 84, 49, 80, 67, 82 }, 17));
        this._0x99865beb(this._stepTitleTwo, this._stepBodyTwo, _0xb34f37e9._0xaa23e1b8(new byte[6] { 50, 59, 42, 94, 57, 49 }, 126), _0xb34f37e9._0xaa23e1b8(new byte[41] { 228, 133, 246, 237, 234, 247, 241, 133, 225, 228, 246, 237, 133, 230, 228, 247, 247, 236, 224, 246, 133, 252, 234, 240, 175, 241, 237, 247, 234, 240, 226, 237, 133, 241, 237, 224, 133, 247, 236, 235, 226 }, 165));
        this._0x99865beb(this._stepTitleThree, this._stepBodyThree, _0xb34f37e9._0xaa23e1b8(new byte[15] { 161, 173, 184, 175, 164, 204, 184, 164, 169, 204, 191, 184, 190, 165, 188 }, 236), _0xb34f37e9._0xaa23e1b8(new byte[40] { 134, 154, 128, 151, 151, 242, 133, 128, 157, 156, 149, 242, 128, 155, 156, 149, 129, 216, 147, 156, 150, 242, 134, 154, 151, 242, 158, 151, 134, 134, 151, 128, 242, 155, 129, 242, 158, 157, 129, 134 }, 210));
    }

    [SerializeField]
    private TMP_Text _stepBodyThree;
    [SerializeField]
    private _0x805ada77 _routeGate;
    [SerializeField]
    private RectTransform _routesButtonRect;
    [SerializeField]
    private TMP_Text _howToTitle;
    [SerializeField]
    private RectTransform _heroCard;
    [SerializeField]
    private TMP_Text _stepBodyTwo;
}

internal static class _0xb34f37e9
{
    internal static string _0xaa23e1b8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}