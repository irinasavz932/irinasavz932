using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// Spawns the rings, walks them across the screen and answers the one question the
/// director asks: "the courier just dashed — what did she fly through?"
///
/// Everything it creates is sized from the camera and takes its sorting order from
/// GateOrders, so nothing can climb over the pops.
public sealed class _0xd5c0fa0f : MonoBehaviour
{
    /// Move everything one frame along. Returns the number of rows that left the
    /// screen untouched this frame.
    public int _0x2bc3d415(float deltaTime)
    {
        if (!this._0xf6d2a63a)
            return 0;
        float _0x9f2eec02 = _0x44394cff.RowSpeed(this._0x0c0b52f4);
        float _0x82a176cf = _0x44394cff.RowCadence(this._0x0c0b52f4);
        this._0x6c23b8d5 -= deltaTime;
        if (this._0x6c23b8d5 <= 0f)
        {
            this._0x6c23b8d5 = _0x82a176cf;
            this._0x47f1ead3();
        }

        this._0xcf52be92 -= deltaTime;
        if (this._0xcf52be92 <= 0f)
        {
            this._0xcf52be92 = 1.8f;
            this._0xf45a9a95();
        }

        if (_0x44394cff.HasGusts(this._0x0c0b52f4))
        {
            this._0x245869c6 -= deltaTime;
            if (this._0x245869c6 <= 0f)
            {
                this._0x245869c6 = 3.4f;
                this._0x986f15a5();
            }
        }

        int _0x20f842fa = 0;
        for (int _0x6a0e178f = this._0x5203a4db.Count - 1; _0x6a0e178f >= 0; _0x6a0e178f--)
        {
            _0x8f124af6 _0x6155bfe0 = this._0x5203a4db[_0x6a0e178f];
            _0x6155bfe0.X -= _0x9f2eec02 * deltaTime;
            if (_0x6155bfe0.Root != null)
                _0x6155bfe0.Root.position = new Vector3(_0x6155bfe0.X, 0f, 0f);
            if (_0x6155bfe0.X < _0x06d167a9.RowDespawnX)
            {
                if (!_0x6155bfe0.Resolved)
                    _0x20f842fa++;
                this._0xa399ad22(_0x6155bfe0);
                if (_0x6155bfe0.Root != null)
                    Destroy(_0x6155bfe0.Root.gameObject);
                this._0x5203a4db.RemoveAt(_0x6a0e178f);
            }
        }

        this._0xeda848bf(this._0xbb9c55d7, _0x9f2eec02 * 0.55f, deltaTime);
        this._0xeda848bf(this._0x292c42f5, _0x9f2eec02 * 2.2f, deltaTime);
        return _0x20f842fa;
    }

    [SerializeField]
    private GameObject _featherSparkPrefab;
    private float _0x245869c6;
    public void _0x25aa691d(int _0x9b77a6b3, _0xe2597f34 _0x5e671961)
    {
        this._0xb8f4d1d6 = Camera.main;
        this._0x0c0b52f4 = _0x9b77a6b3;
        this._0x3c4f277c = _0x5e671961;
        this._0xc1b8f586 = 2f * _0x06d167a9.HalfHeight(this._0xb8f4d1d6) * _0x06d167a9.GateRingHeightFraction;
        this._0x6c23b8d5 = 0f;
        this._0xcf52be92 = 0f;
        this._0x245869c6 = 2.5f;
        this._0x8f4f479e = 0;
        this._0xe41bd364 = 0;
        this._0xf6d2a63a = true;
        if (this._cottage != null)
        {
            this._cottage.drawMode = SpriteDrawMode.Sliced;
            this._cottage.size = _0x06d167a9.Square(this._0xb8f4d1d6, _0x06d167a9.CottageHeightFraction);
            this._cottage.sortingOrder = _0x06d167a9.CottageOrder;
            this._cottage.transform.position = new Vector3(_0x06d167a9.RowSpawnX + 2.4f, -2.2f, 0f);
        }
    }

    private void _0xeda848bf(List<Transform> _0x0040b043, float _0x8dbdb4d2, float _0x11a5c435)
    {
        for (int _0xf938b3e3 = _0x0040b043.Count - 1; _0xf938b3e3 >= 0; _0xf938b3e3--)
        {
            Transform _0xea67692e = _0x0040b043[_0xf938b3e3];
            if (_0xea67692e == null)
            {
                _0x0040b043.RemoveAt(_0xf938b3e3);
                continue;
            }

            _0xea67692e.position = _0xea67692e.position + new Vector3(-_0x8dbdb4d2 * _0x11a5c435, 0f, 0f);
            if (_0xea67692e.position.x < _0x06d167a9.RowDespawnX - 1.5f)
            {
                Destroy(_0xea67692e.gameObject);
                _0x0040b043.RemoveAt(_0xf938b3e3);
            }
        }
    }

    private int _0x8f4f479e;
    private float _0xc1b8f586;
    /// Flash the ring the courier flew through, then stop counting the row.
    public void _0x7fb1abb2(_0x8f124af6 _0xd5f0d8c0, int _0x20060ad1, bool _0x1bb69664)
    {
        if (_0xd5f0d8c0 == null)
            return;
        _0xd5f0d8c0.Resolved = true;
        this._0xa399ad22(_0xd5f0d8c0);
        if (_0x20060ad1 >= 0 && _0x20060ad1 < SlotCount && _0xd5f0d8c0.Bodies[_0x20060ad1] != null)
        {
            SpriteRenderer _0x8b7e41c6 = _0xd5f0d8c0.Bodies[_0x20060ad1];
            _0x8b7e41c6.DOColor(_0x1bb69664 ? _0x4f5b9c84._0x53c78623 : _0x4f5b9c84._0x96f3147f, _0x1bb69664 ? 0.18f : 0.12f);
        }

        for (int _0x740370ee = 0; _0x740370ee < SlotCount; _0x740370ee++)
        {
            if (_0x740370ee == _0x20060ad1)
                continue;
            SpriteRenderer _0xcfc58156 = _0xd5f0d8c0.Bodies[_0x740370ee];
            if (_0xcfc58156 == null)
                continue;
            _0xcfc58156.DOFade(0.25f, 0.35f);
        }
    }

    /// The breathing tween on a ring has no Unity target of its own, so it has to be
    /// killed by hand before the renderer it drives is destroyed.
    private void _0xa399ad22(_0x8f124af6 _0x942eb86b)
    {
        if (_0x942eb86b == null || _0x942eb86b.Bodies == null)
            return;
        for (int _0xd486343b = 0; _0xd486343b < _0x942eb86b.Bodies.Length; _0xd486343b++)
        {
            if (_0x942eb86b.Bodies[_0xd486343b] != null)
                DOTween.Kill(_0x942eb86b.Bodies[_0xd486343b]);
        }
    }

    [SerializeField]
    private GameObject _hedgePrefab;
    /// Bring the destination cottage into frame for the closing beat.
    public Vector3 _0x1f0ee0f3()
    {
        if (this._cottage == null)
            return new Vector3(1.4f, -1.2f, 0f);
        Vector3 _0x4d1e5ff0 = new Vector3(1.35f, -2.05f, 0f);
        this._cottage.transform.DOMove(_0x4d1e5ff0, 0.9f).SetEase(Ease.OutCubic);
        return _0x4d1e5ff0 + new Vector3(0f, 0.6f, 0f);
    }

    private const float DecayGrace = 0.40f;
    [SerializeField]
    private GameObject _gateRingPrefab;
    private readonly List<_0x8f124af6> _0x5203a4db = new List<_0x8f124af6>();
    private int _0xe41bd364;
    private _0xe2597f34 _0x3c4f277c;
    /// The colour of the ring the courier should aim for, <paramref name = "offset"/>
    /// rows ahead of the nearest one. Returns -1 when nothing is queued that far.
    public int _0x91726a6a(int _0x2194df4d)
    {
        int _0x5720a122 = 0;
        for (int _0x0b9e1a98 = 0; _0x0b9e1a98 < this._0x5203a4db.Count; _0x0b9e1a98++)
        {
            if (this._0x5203a4db[_0x0b9e1a98].Resolved)
                continue;
            if (_0x5720a122 == _0x2194df4d)
                return this._0x5203a4db[_0x0b9e1a98].TargetColour;
            _0x5720a122++;
        }

        return -1;
    }

    /// The courier just dashed. Returns the row she reached, or null.
    public _0x8f124af6 _0x53453974(Vector2 _0xbb0ef391)
    {
        for (int _0xa11c5eab = 0; _0xa11c5eab < this._0x5203a4db.Count; _0xa11c5eab++)
        {
            _0x8f124af6 _0x4550a1dc = this._0x5203a4db[_0xa11c5eab];
            if (_0x4550a1dc.Resolved)
                continue;
            float _0xc8eb8406 = _0x4550a1dc.X - _0xbb0ef391.x;
            if (_0xc8eb8406 < -DecayGrace)
                continue;
            if (_0xc8eb8406 > _0x06d167a9.DashReach)
                continue;
            return _0x4550a1dc;
        }

        return null;
    }

    public Vector3 _0x9ce4368c(_0x8f124af6 _0x88c5fe72, int _0xbd54bdeb)
    {
        if (_0x88c5fe72 == null || _0xbd54bdeb < 0)
            return Vector3.zero;
        return new Vector3(_0x88c5fe72.X, _0xe2597f34.SlotY(_0xbd54bdeb) + _0x88c5fe72.Bow, 0f);
    }

    private const int SlotCount = 3;
    private void _0x47f1ead3()
    {
        if (this._0x3c4f277c == null || this._gateRingPrefab == null || this._worldRoot == null)
            return;
        _0xe2597f34._0xdd7a3562 _0xa21c8fe5 = this._0x3c4f277c._0x8172aa72(this._0x8f4f479e);
        if (_0xa21c8fe5 == null)
            return;
        GameObject _0x68ac762f = new GameObject(_0x495ed2ac._0xe9f9cee9(new byte[3] { 6, 59, 35 }, 84));
        Transform _0xa1ba7052 = _0x68ac762f.transform;
        _0xa1ba7052.SetParent(this._worldRoot, false);
        _0xa1ba7052.position = new Vector3(_0x06d167a9.RowSpawnX, 0f, 0f);
        _0x8f124af6 _0x96bdfc1f = new _0x8f124af6();
        _0x96bdfc1f.Root = _0xa1ba7052;
        _0x96bdfc1f.Rings = new Transform[SlotCount];
        _0x96bdfc1f.Bodies = new SpriteRenderer[SlotCount];
        _0x96bdfc1f.Cores = new SpriteRenderer[SlotCount];
        _0x96bdfc1f.Colours = new int[SlotCount];
        _0x96bdfc1f.Present = new bool[SlotCount];
        _0x96bdfc1f.X = _0x06d167a9.RowSpawnX;
        _0x96bdfc1f.Bow = _0xa21c8fe5.Bow;
        _0x96bdfc1f.TargetColour = _0xa21c8fe5._0x5e446d05(_0xa21c8fe5.TargetSlot);
        Vector2 _0x4972ca57 = _0x06d167a9.Square(this._0xb8f4d1d6, _0x06d167a9.GateRingHeightFraction);
        Vector2 _0x7aa78f08 = _0x06d167a9.Square(this._0xb8f4d1d6, _0x06d167a9.GateRingHeightFraction * _0x06d167a9.GateCoreOfRing);
        for (int _0xfa069e53 = 0; _0xfa069e53 < SlotCount; _0xfa069e53++)
        {
            _0x96bdfc1f.Colours[_0xfa069e53] = _0xa21c8fe5._0x5e446d05(_0xfa069e53);
            _0x96bdfc1f.Present[_0xfa069e53] = _0xa21c8fe5._0xeb455c73(_0xfa069e53);
            if (!_0x96bdfc1f.Present[_0xfa069e53])
                continue;
            GameObject _0x68ebd804 = Instantiate(this._gateRingPrefab, _0xa1ba7052);
            _0x68ebd804.transform.localPosition = new Vector3(0f, _0xe2597f34.SlotY(_0xfa069e53) + _0xa21c8fe5.Bow, 0f);
            _0x96bdfc1f.Rings[_0xfa069e53] = _0x68ebd804.transform;
            SpriteRenderer _0x141789c9 = _0x68ebd804.GetComponent<SpriteRenderer>();
            if (_0x141789c9 != null)
            {
                _0x141789c9.drawMode = SpriteDrawMode.Sliced;
                _0x141789c9.size = _0x4972ca57;
                _0x141789c9.sortingOrder = _0x06d167a9.GateRingOrder;
                _0x141789c9.color = _0x4f5b9c84.GateColour(_0x96bdfc1f.Colours[_0xfa069e53]);
                SpriteRenderer _0x6ec60833 = _0x141789c9;
                DOTween.To(() => _0x6ec60833.size, _0x0e9f55f0 => _0x6ec60833.size = _0x0e9f55f0, _0x4972ca57 * 1.08f, 0.9f).SetTarget(_0x6ec60833).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
            }

            _0x96bdfc1f.Bodies[_0xfa069e53] = _0x141789c9;
            SpriteRenderer _0xed5e7339 = null;
            SpriteRenderer[] _0x4f0d829f = _0x68ebd804.GetComponentsInChildren<SpriteRenderer>(true);
            for (int _0x7196a9e8 = 0; _0x7196a9e8 < _0x4f0d829f.Length; _0x7196a9e8++)
            {
                if (_0x4f0d829f[_0x7196a9e8] != _0x141789c9)
                {
                    _0xed5e7339 = _0x4f0d829f[_0x7196a9e8];
                    break;
                }
            }

            if (_0xed5e7339 != null)
            {
                _0xed5e7339.drawMode = SpriteDrawMode.Sliced;
                _0xed5e7339.size = _0x7aa78f08;
                _0xed5e7339.sortingOrder = _0x06d167a9.GateCoreOrder;
                _0xed5e7339.color = _0x4f5b9c84.Fade(_0x4f5b9c84.GateColour(_0x96bdfc1f.Colours[_0xfa069e53]), 0.55f);
            }

            _0x96bdfc1f.Cores[_0xfa069e53] = _0xed5e7339;
        }

        this._0x5203a4db.Add(_0x96bdfc1f);
        this._0x8f4f479e++;
    }

    public void _0x9db5b331()
    {
        this._0xf6d2a63a = false;
    }

    private readonly List<Transform> _0x292c42f5 = new List<Transform>();
    [SerializeField]
    private GameObject _mailboxPrefab;
    [SerializeField]
    private Transform _decorRoot;
    /// Which slot of <paramref name = "row"/> the courier is level with, or -1.
    public int _0xe6b0159c(_0x8f124af6 _0x1d538a42, Vector2 _0x23b8e134)
    {
        if (_0x1d538a42 == null)
            return -1;
        float _0x7ea00820 = this._0xc1b8f586 * 0.5f * _0x06d167a9.RingCatchFraction;
        int _0xa498b438 = -1;
        float _0x538664db = _0x7ea00820;
        for (int _0xd53f3225 = 0; _0xd53f3225 < SlotCount; _0xd53f3225++)
        {
            if (!_0x1d538a42.Present[_0xd53f3225])
                continue;
            float _0xe03d4363 = _0xe2597f34.SlotY(_0xd53f3225) + _0x1d538a42.Bow;
            float _0x5d3ea507 = Mathf.Abs(_0x23b8e134.y - _0xe03d4363);
            if (_0x5d3ea507 <= _0x538664db)
            {
                _0x538664db = _0x5d3ea507;
                _0xa498b438 = _0xd53f3225;
            }
        }

        return _0xa498b438;
    }

    public int _0x0fbfe16b
    {
        get
        {
            return this._0x5203a4db.Count;
        }
    }

    private bool _0xf6d2a63a;
    [SerializeField]
    private SpriteRenderer _cottage;
    private float _0x6c23b8d5;
    private Camera _0xb8f4d1d6;
    [SerializeField]
    private GameObject _windStreakPrefab;
    /// Scatter feather sparks around a point.
    public void _0x77444a60(Vector3 _0x0bca2c53, Color _0xb83e8ace, int _0x2a1d38c0)
    {
        if (this._featherSparkPrefab == null || this._worldRoot == null)
            return;
        Vector2 _0x97cc4788 = _0x06d167a9.Square(this._0xb8f4d1d6, _0x06d167a9.SparkHeightFraction);
        for (int _0x8b69552b = 0; _0x8b69552b < _0x2a1d38c0; _0x8b69552b++)
        {
            float _0x8f45b0e7 = (360f / Mathf.Max(1, _0x2a1d38c0)) * _0x8b69552b;
            GameObject _0x50b33172 = Instantiate(this._featherSparkPrefab, this._worldRoot);
            _0x50b33172.transform.position = _0x0bca2c53;
            SpriteRenderer _0x96a4a38d = _0x50b33172.GetComponent<SpriteRenderer>();
            if (_0x96a4a38d != null)
            {
                _0x96a4a38d.drawMode = SpriteDrawMode.Sliced;
                _0x96a4a38d.size = _0x97cc4788;
                _0x96a4a38d.sortingOrder = _0x06d167a9.SparkOrder;
                _0x96a4a38d.color = _0xb83e8ace;
            }

            Vector3 _0xa4f6ec27 = _0x0bca2c53 + (Quaternion.Euler(0f, 0f, _0x8f45b0e7) * Vector3.right) * 0.9f;
            _0x50b33172.transform.DOMove(_0xa4f6ec27, 0.45f).SetEase(Ease.OutCubic);
            if (_0x96a4a38d != null)
                _0x96a4a38d.DOFade(0f, 0.45f);
            Destroy(_0x50b33172, 0.6f);
        }
    }

    /// One row of rings currently on screen.
    public sealed class _0x8f124af6
    {
        public Transform Root;
        public Transform[] Rings;
        public SpriteRenderer[] Bodies;
        public SpriteRenderer[] Cores;
        public int[] Colours;
        public bool[] Present;
        public int TargetColour;
        public bool Resolved;
        public float X;
        public float Bow;
    }

    private readonly List<Transform> _0xbb9c55d7 = new List<Transform>();
    [SerializeField]
    private Transform _worldRoot;
    private float _0xcf52be92;
    private void _0xf45a9a95()
    {
        if (this._decorRoot == null || this._0x3c4f277c == null)
            return;
        int _0xda33e9ce = this._0x3c4f277c._0xcafeca1f(this._0xe41bd364);
        this._0xe41bd364++;
        GameObject _0x4eba1f47 = _0xda33e9ce == 0 ? this._haystackPrefab : (_0xda33e9ce == 1 ? this._hedgePrefab : this._mailboxPrefab);
        if (_0x4eba1f47 == null)
            return;
        float _0xe32d530d = _0xda33e9ce == 0 ? _0x06d167a9.HaystackHeightFraction : (_0xda33e9ce == 1 ? _0x06d167a9.HedgeHeightFraction : _0x06d167a9.MailboxHeightFraction);
        GameObject _0xa68e7294 = Instantiate(_0x4eba1f47, this._decorRoot);
        float _0x049780b7 = -_0x06d167a9.HalfHeight(this._0xb8f4d1d6) + 2f * _0x06d167a9.HalfHeight(this._0xb8f4d1d6) * _0xe32d530d * 0.5f + 0.25f;
        _0xa68e7294.transform.position = new Vector3(_0x06d167a9.RowSpawnX + 1.2f, _0x049780b7, 0f);
        SpriteRenderer _0xd6b77e09 = _0xa68e7294.GetComponent<SpriteRenderer>();
        if (_0xd6b77e09 != null)
        {
            _0xd6b77e09.drawMode = SpriteDrawMode.Sliced;
            _0xd6b77e09.size = _0x06d167a9.Square(this._0xb8f4d1d6, _0xe32d530d);
            _0xd6b77e09.sortingOrder = _0x06d167a9.MidFieldOrder;
            _0xd6b77e09.color = _0x4f5b9c84.Fade(_0x4f5b9c84._0x53c78623, 0.85f);
        }

        this._0xbb9c55d7.Add(_0xa68e7294.transform);
    }

    private int _0x0c0b52f4;
    [SerializeField]
    private GameObject _haystackPrefab;
    private void _0x986f15a5()
    {
        if (this._windStreakPrefab == null || this._worldRoot == null)
            return;
        GameObject _0x4f21b90b = Instantiate(this._windStreakPrefab, this._worldRoot);
        // Height comes from the seeded decor stream, not from UnityEngine.Random:
        // one global generator shared between systems stops meaning anything.
        int _0xe1370787 = this._0x3c4f277c == null ? 1 : this._0x3c4f277c._0xcafeca1f(this._0xe41bd364 + 3);
        float _0x15991317 = _0xe1370787 == 0 ? -1.6f : (_0xe1370787 == 1 ? 0.6f : 2.4f);
        _0x4f21b90b.transform.position = new Vector3(_0x06d167a9.RowSpawnX + 1.6f, _0x15991317, 0f);
        SpriteRenderer _0xf8e854c4 = _0x4f21b90b.GetComponent<SpriteRenderer>();
        if (_0xf8e854c4 != null)
        {
            _0xf8e854c4.drawMode = SpriteDrawMode.Sliced;
            _0xf8e854c4.size = _0x06d167a9.Square(this._0xb8f4d1d6, _0x06d167a9.WindStreakHeightFraction);
            _0xf8e854c4.sortingOrder = _0x06d167a9.WindStreakOrder;
            _0xf8e854c4.color = _0x4f5b9c84.Fade(_0x4f5b9c84._0xeb1fc64e, 0.55f);
        }

        this._0x292c42f5.Add(_0x4f21b90b.transform);
    }
}

internal static class _0x495ed2ac
{
    internal static string _0xe9f9cee9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}