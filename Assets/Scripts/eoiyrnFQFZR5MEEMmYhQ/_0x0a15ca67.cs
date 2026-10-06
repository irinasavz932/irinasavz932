using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

/// The courier herself. A finger held down swings her along a vertical arc; letting
/// go fires a short dash along +X through whatever ring she is level with.
///
/// Input is read straight from EnhancedTouch: this template's InputController keeps
/// its singleton and every accessor private, so there is nothing to call there.
public sealed class _0x0a15ca67 : MonoBehaviour
{
    [SerializeField]
    private Transform _arcGuideRoot;
    private float _0x1842e2d1;
    /// The long fall that plays when the letter is lost.
    public void _0xc63c370c()
    {
        this._0x4172b030 = false;
        if (this._0xc3142df0 != null)
            this._0xc3142df0.Kill();
        if (this._courier != null)
            this._courier.DOLocalMoveY(this._courier.localPosition.y - 6f, 0.8f).SetEase(Ease.InBack);
        if (this._letter != null)
            this._letter.DOLocalRotate(new Vector3(0f, 0f, 540f), 0.8f, RotateMode.FastBeyond360);
    }

    public void _0x75330a48()
    {
        this._0x4172b030 = false;
        this._0x9757b64d = false;
    }

    private Camera _0x8fd15251;
    [SerializeField]
    private Transform _letter;
    private bool _0xf1252e60()
    {
        var _0x5a57f0b7 = Touch.activeTouches;
        for (int _0x1264a2c1 = 0; _0x1264a2c1 < _0x5a57f0b7.Count; _0x1264a2c1++)
        {
            if (!_0x5a57f0b7[_0x1264a2c1].ended)
                return true;
        }

        return false;
    }

    private float _0xa7282c73;
    private bool _0x4172b030;
    public bool _0xdb11a28e
    {
        get
        {
            return this._0x1842e2d1 <= 0f;
        }
    }

    /// Where the courier is right now, dash offset included.
    public Vector2 _0x67a5939b
    {
        get
        {
            Vector2 _0xb686a929 = this._0x7cc1a4ad(this._0xa7282c73);
            return new Vector2(_0xb686a929.x + this._0x4a428d58, _0xb686a929.y);
        }
    }

    private const int ArcDotCount = 9;
    private Vector2 _0x7cc1a4ad(float _0x093483fb)
    {
        float _0x2e24df95 = _0x093483fb * Mathf.Deg2Rad;
        return new Vector2(_0x06d167a9.ArcCentreX + _0x06d167a9.ArcRadius * Mathf.Cos(_0x2e24df95), _0x06d167a9.ArcCentreY + _0x06d167a9.ArcRadius * Mathf.Sin(_0x2e24df95));
    }

    /// Fired on finger-up. Returns true when the dash actually left the perch.
    private void _0x0870c7c9()
    {
        if (this._0x1842e2d1 > 0f)
            return;
        this._0x1842e2d1 = _0x06d167a9.DashCooldown;
        if (this._0xc3142df0 != null)
            this._0xc3142df0.Kill();
        float _0xcfc31d79 = _0x06d167a9.DashReach;
        this._0xc3142df0 = DOTween.Sequence().Append(DOTween.To(() => this._0x4a428d58, _0xb0811e1b => this._0x4a428d58 = _0xb0811e1b, _0xcfc31d79, _0x06d167a9.DashRise).SetEase(Ease.OutQuart)).Append(DOTween.To(() => this._0x4a428d58, _0xb0811e1b => this._0x4a428d58 = _0xb0811e1b, 0f, _0x06d167a9.DashFall).SetEase(Ease.InOutSine));
        this._0x06648e36 = true;
    }

    private bool _0x9757b64d;
    private void Update()
    {
        if (!this._0x4172b030)
            return;
        if (this._0x1842e2d1 > 0f)
            this._0x1842e2d1 -= Time.deltaTime;
        bool _0x2a6531d7 = this._0xf1252e60();
        if (_0x2a6531d7 && !this._0x9757b64d)
        {
            // Every new touch flips the swing direction, so even a 50 ms tap from an
            // automated pass moves her instead of sitting still.
            this._0x9757b64d = true;
            this._0x87878181 = -this._0x87878181;
        }
        else if (!_0x2a6531d7 && this._0x9757b64d)
        {
            this._0x9757b64d = false;
            this._0x0870c7c9();
        }

        if (this._0x9757b64d)
        {
            this._0xa7282c73 += this._0x87878181 * _0x06d167a9.ArcSweepDegreesPerSecond * Time.deltaTime;
            if (this._0xa7282c73 > _0x06d167a9.ArcSpanDegrees)
            {
                this._0xa7282c73 = _0x06d167a9.ArcSpanDegrees;
                this._0x87878181 = -this._0x87878181;
            }
            else if (this._0xa7282c73 < -_0x06d167a9.ArcSpanDegrees)
            {
                this._0xa7282c73 = -_0x06d167a9.ArcSpanDegrees;
                this._0x87878181 = -this._0x87878181;
            }
        }

        this._0x3970dec5();
    }

    private void _0xdd1001f7()
    {
        if (this._arcGuideRoot == null || this._arcDotPrefab == null)
            return;
        if (this._arcGuideRoot.childCount > 0)
            return;
        Vector2 _0x3194c599 = _0x06d167a9.Square(this._0x8fd15251, _0x06d167a9.ArcDotHeightFraction);
        for (int _0x939d4175 = 0; _0x939d4175 < ArcDotCount; _0x939d4175++)
        {
            float _0x20fae5c2 = ArcDotCount <= 1 ? 0f : (_0x939d4175 / (float)(ArcDotCount - 1));
            float _0xc1e6c379 = Mathf.Lerp(-_0x06d167a9.ArcSpanDegrees, _0x06d167a9.ArcSpanDegrees, _0x20fae5c2);
            Vector2 _0x36b03486 = this._0x7cc1a4ad(_0xc1e6c379);
            GameObject _0xe244f4a6 = Instantiate(this._arcDotPrefab, this._arcGuideRoot);
            _0xe244f4a6.transform.position = new Vector3(_0x36b03486.x, _0x36b03486.y, 0f);
            SpriteRenderer _0x1689cf48 = _0xe244f4a6.GetComponent<SpriteRenderer>();
            if (_0x1689cf48 != null)
            {
                _0x1689cf48.drawMode = SpriteDrawMode.Sliced;
                _0x1689cf48.size = _0x3194c599;
                _0x1689cf48.sortingOrder = _0x06d167a9.ArcGuideOrder;
                _0x1689cf48.color = _0x4f5b9c84.Fade(_0x4f5b9c84._0x53c78623, 0.45f);
            }
        }
    }

    private float _0x4a428d58;
    /// True once per dash, for the director that scores the rings. Polled rather
    /// than raised as an event: a delegate field is one more thing to keep alive
    /// across a scene change, and the director already runs every frame.
    public bool _0xbaeae706()
    {
        if (!this._0x06648e36)
            return false;
        this._0x06648e36 = false;
        return true;
    }

    [SerializeField]
    private Transform _courier;
    private float _0x87878181 = -1f;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        this._0x8fd15251 = Camera.main;
        this._0xa7282c73 = 0f;
    }

    [SerializeField]
    private GameObject _arcDotPrefab;
    [SerializeField]
    private SpriteRenderer _letterRenderer;
    /// Size everything from the camera and lay the arc guide out, then start reading
    /// input. Called by the director once the run begins.
    public void _0xd730718a()
    {
        this._0x8fd15251 = Camera.main;
        if (this._courierRenderer != null)
        {
            this._courierRenderer.drawMode = SpriteDrawMode.Sliced;
            this._courierRenderer.size = _0x06d167a9.Square(this._0x8fd15251, _0x06d167a9.CourierHeightFraction);
            this._courierRenderer.sortingOrder = _0x06d167a9.CourierOrder;
        }

        if (this._letterRenderer != null)
        {
            this._letterRenderer.drawMode = SpriteDrawMode.Sliced;
            this._letterRenderer.size = _0x06d167a9.Square(this._0x8fd15251, _0x06d167a9.CourierHeightFraction * _0x06d167a9.LetterOfCourier);
            this._letterRenderer.sortingOrder = _0x06d167a9.LetterOrder;
        }

        this._0xdd1001f7();
        this._0x4172b030 = true;
        this._0x3970dec5();
    }

    /// Knock the swing off course after a missed or wrong ring, so two captured
    /// frames differ in geometry and not only in a HUD number.
    public void _0x25a94279(float degrees)
    {
        this._0xa7282c73 += degrees;
        if (this._0xa7282c73 > _0x06d167a9.ArcSpanDegrees)
            this._0xa7282c73 = _0x06d167a9.ArcSpanDegrees;
        if (this._0xa7282c73 < -_0x06d167a9.ArcSpanDegrees)
            this._0xa7282c73 = -_0x06d167a9.ArcSpanDegrees;
        this._0x3970dec5();
    }

    /// The glide towards the cottage that plays when the letter arrives.
    public void _0x15dc3c6d(Vector3 _0x80a6d8f3, float _0x28877fea)
    {
        this._0x4172b030 = false;
        if (this._0xc3142df0 != null)
            this._0xc3142df0.Kill();
        if (this._courier != null)
            this._courier.DOMove(_0x80a6d8f3, _0x28877fea).SetEase(Ease.InOutSine);
    }

    private Tween _0xc3142df0;
    public float _0x75fcc1e8
    {
        get
        {
            return _0x06d167a9.DashReach;
        }
    }

    private void _0x3970dec5()
    {
        if (this._courier == null)
            return;
        Vector2 _0xd728e5f0 = this._0x67a5939b;
        this._courier.position = new Vector3(_0xd728e5f0.x, _0xd728e5f0.y, 0f);
    }

    [SerializeField]
    private SpriteRenderer _courierRenderer;
    private bool _0x06648e36;
    private void OnDestroy()
    {
        if (this._0xc3142df0 != null)
            this._0xc3142df0.Kill();
    }
}