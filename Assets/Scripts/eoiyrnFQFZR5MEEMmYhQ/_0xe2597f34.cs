using UnityEngine;

/// Builds the ring layout for one run from a seed, then proves it is flyable before
/// handing it over (rule C.11). Nothing here is hand-placed: the colour chain, the
/// slot that carries the target, the decoy colours, the sideways bow of each row and
/// which rows drop to two rings all come out of the generator.
public sealed class _0xe2597f34 : MonoBehaviour
{
    public int _0x98d00205
    {
        get
        {
            return this._0xb9edb1b9 == null ? 0 : this._0xb9edb1b9.Length;
        }
    }

    private const int RetryBudget = 20;
    /// One row of rings: three vertical slots, one of which carries the target colour.
    public sealed class _0xdd7a3562
    {
        public int TargetSlot;
        public int Slot0Colour;
        public int Slot1Colour;
        public int Slot2Colour;
        public bool Slot0Present;
        public bool Slot1Present;
        public bool Slot2Present;
        public float Bow;
        public int _0x5e446d05(int _0x6fe12bf0)
        {
            if (_0x6fe12bf0 == 0)
                return this.Slot0Colour;
            if (_0x6fe12bf0 == 1)
                return this.Slot1Colour;
            return this.Slot2Colour;
        }

        public bool _0xeb455c73(int _0xc155b5cc)
        {
            if (_0xc155b5cc == 0)
                return this.Slot0Present;
            if (_0xc155b5cc == 1)
                return this.Slot1Present;
            return this.Slot2Present;
        }
    }

    /// The colour the courier must fly through at step <paramref name = "step"/>.
    public int _0xcd8f98a9(int _0xcac1cbbe)
    {
        if (this._0xb9edb1b9 == null || this._0xb9edb1b9.Length == 0)
            return 0;
        if (_0xcac1cbbe < 0)
            _0xcac1cbbe = 0;
        if (_0xcac1cbbe >= this._0xb9edb1b9.Length)
            _0xcac1cbbe = this._0xb9edb1b9.Length - 1;
        return this._0xb9edb1b9[_0xcac1cbbe];
    }

    private int[] _0xa6037ff0;
    private int[] _0xcc914d28(System.Random _0x08843018, int _0x3c0d7c68)
    {
        int[] _0xdc3d6dbb = new int[_0x3c0d7c68];
        for (int _0x8fe27d5d = 0; _0x8fe27d5d < _0x3c0d7c68; _0x8fe27d5d++)
            _0xdc3d6dbb[_0x8fe27d5d] = _0x08843018.Next(3);
        return _0xdc3d6dbb;
    }

    private _0xdd7a3562[] _0x58348877;
    private _0xdd7a3562[] _0x0a85d475(System.Random _0x4aac59fd, int _0xdf79920f, int _0xa70691e4)
    {
        // A handful of spare rows past the target, so the field keeps coming while a
        // slow player is still working through the chain.
        int _0x366a7380 = _0xdf79920f + 6;
        _0xdd7a3562[] _0x0ae5edf7 = new _0xdd7a3562[_0x366a7380];
        for (int _0xf3708ee7 = 0; _0xf3708ee7 < _0x366a7380; _0xf3708ee7++)
        {
            _0xdd7a3562 _0x4340ea6c = new _0xdd7a3562();
            _0x4340ea6c.TargetSlot = _0x4aac59fd.Next(SlotCount);
            int _0x6f29cd05 = this._0xcd8f98a9(_0xf3708ee7);
            int _0x0028f5c6 = (_0x6f29cd05 + 1 + _0x4aac59fd.Next(_0xa70691e4 - 1)) % _0xa70691e4;
            int _0x13104760 = (_0x6f29cd05 + 1 + _0x4aac59fd.Next(_0xa70691e4 - 1)) % _0xa70691e4;
            if (_0x13104760 == _0x0028f5c6)
                _0x13104760 = (_0x13104760 + 1) % _0xa70691e4;
            if (_0x13104760 == _0x6f29cd05)
                _0x13104760 = (_0x13104760 + 1) % _0xa70691e4;
            _0x4340ea6c.Slot0Colour = _0x4340ea6c.TargetSlot == 0 ? _0x6f29cd05 : _0x0028f5c6;
            _0x4340ea6c.Slot1Colour = _0x4340ea6c.TargetSlot == 1 ? _0x6f29cd05 : (_0x4340ea6c.TargetSlot == 0 ? _0x0028f5c6 : _0x13104760);
            _0x4340ea6c.Slot2Colour = _0x4340ea6c.TargetSlot == 2 ? _0x6f29cd05 : _0x13104760;
            _0x4340ea6c.Slot0Present = true;
            _0x4340ea6c.Slot1Present = true;
            _0x4340ea6c.Slot2Present = true;
            // a quarter of the rows drop one decoy, which changes the shape of the
            // row and not just its colours
            if (_0x4aac59fd.Next(100) < 25)
            {
                int _0x380d82c0 = _0x4aac59fd.Next(SlotCount);
                if (_0x380d82c0 == _0x4340ea6c.TargetSlot)
                    _0x380d82c0 = (_0x380d82c0 + 1) % SlotCount;
                if (_0x380d82c0 == 0)
                    _0x4340ea6c.Slot0Present = false;
                else if (_0x380d82c0 == 1)
                    _0x4340ea6c.Slot1Present = false;
                else
                    _0x4340ea6c.Slot2Present = false;
            }

            int _0xdb97504b = _0x4aac59fd.Next(3);
            _0x4340ea6c.Bow = _0xdb97504b == 0 ? -0.34f : (_0xdb97504b == 1 ? 0f : 0.34f);
            _0x0ae5edf7[_0xf3708ee7] = _0x4340ea6c;
        }

        return _0x0ae5edf7;
    }

    /// 0 haystack, 1 hedge, 2 mailbox — seeded so two runs scatter the fields
    /// differently even when the ring chain repeats.
    public int _0xcafeca1f(int _0xa5249f0a)
    {
        if (this._0xa6037ff0 == null || this._0xa6037ff0.Length == 0)
            return 0;
        return this._0xa6037ff0[((_0xa5249f0a % this._0xa6037ff0.Length) + this._0xa6037ff0.Length) % this._0xa6037ff0.Length];
    }

    /// The world height of a slot, before the row's bow is added.
    public static float SlotY(int _0x37a22388)
    {
        if (_0x37a22388 == 0)
            return _0x06d167a9.RowLowY;
        if (_0x37a22388 == 1)
            return _0x06d167a9.RowMidY;
        return _0x06d167a9.RowTopY;
    }

    public _0xdd7a3562 _0x8172aa72(int _0x0b1f343b)
    {
        if (this._0x58348877 == null || this._0x58348877.Length == 0)
            return null;
        return this._0x58348877[((_0x0b1f343b % this._0x58348877.Length) + this._0x58348877.Length) % this._0x58348877.Length];
    }

    /// A layout is flyable when every target ring sits inside the arc the courier can
    /// reach, and the row's approach leaves time to swing there. Both halves are
    /// checked with the same slot geometry the spawner ships, so the proof is about
    /// the rings the player will actually see.
    public bool _0xf18a3268(_0xdd7a3562[] _0x3ad29fea, float _0xfae15dcc)
    {
        if (_0x3ad29fea == null || _0x3ad29fea.Length == 0)
            return false;
        float _0x775dc8bd = _0x06d167a9.ArcRadius * Mathf.Sin(_0x06d167a9.ArcSpanDegrees * Mathf.Deg2Rad);
        float _0x1c8fd5f5 = _0x06d167a9.ArcCentreY - _0x775dc8bd;
        float _0x054692b3 = _0x06d167a9.ArcCentreY + _0x775dc8bd;
        float _0xcee6bd3b = 0.5f * 2f * 5f * _0x06d167a9.GateRingHeightFraction * _0x06d167a9.RingCatchFraction;
        float _0xf5e56254 = (2f * _0x06d167a9.ArcSpanDegrees) / _0x06d167a9.ArcSweepDegreesPerSecond;
        if (_0xf5e56254 > _0xfae15dcc)
            return false;
        for (int _0x9aa71763 = 0; _0x9aa71763 < _0x3ad29fea.Length; _0x9aa71763++)
        {
            _0xdd7a3562 _0x51a930cd = _0x3ad29fea[_0x9aa71763];
            if (_0x51a930cd == null)
                return false;
            if (!_0x51a930cd._0xeb455c73(_0x51a930cd.TargetSlot))
                return false;
            float _0x5cb95dce = SlotY(_0x51a930cd.TargetSlot) + _0x51a930cd.Bow;
            if (_0x5cb95dce < _0x1c8fd5f5 - _0xcee6bd3b)
                return false;
            if (_0x5cb95dce > _0x054692b3 + _0xcee6bd3b)
                return false;
        }

        return true;
    }

    public int _0x410692cb
    {
        get
        {
            return this._0x58348877 == null ? 0 : this._0x58348877.Length;
        }
    }

    /// Lay out a run. The seed is derived from the route and the attempt, so a bug
    /// can be reproduced exactly from the two numbers printed below.
    public void _0xf27484bb(int _0x10970501, int _0x0bfb58a8)
    {
        int _0x912f1c3b = (_0x10970501 * 7919) ^ (_0x0bfb58a8 * 104729);
        System.Random _0x50aa79c2 = new System.Random(_0x912f1c3b);
        int _0x8e66a48d = _0x44394cff.GateTarget(_0x10970501);
        int _0xfae89df0 = _0x44394cff.ColourCount(_0x10970501);
        float _0x1840b64f = _0x44394cff.RowCadence(_0x10970501);
        this._0xb9edb1b9 = this._0x87e2cd7f(_0x50aa79c2, _0x8e66a48d, _0xfae89df0);
        this._0x58348877 = this._0x0a85d475(_0x50aa79c2, _0x8e66a48d, _0xfae89df0);
        for (int _0x67ba5f41 = 0; _0x67ba5f41 < RetryBudget && !this._0xf18a3268(this._0x58348877, _0x1840b64f); _0x67ba5f41++)
        {
            this._0x58348877 = this._0x0a85d475(_0x50aa79c2, _0x8e66a48d, _0xfae89df0);
        }

        if (!this._0xf18a3268(this._0x58348877, _0x1840b64f))
        {
            this._0x58348877 = this._0x9a791dcd(_0x8e66a48d);
        }

        this._0xa6037ff0 = this._0xcc914d28(_0x50aa79c2, _0x8e66a48d * 3 + 6);
        {
#if B_LOGS
            {
                Debug.Log(_0x2b068f69._0xa18cf611(new byte[13] { 215, 254, 227, 249, 248, 233, 209, 172, 255, 233, 233, 232, 177 }, 140) + _0x912f1c3b + _0x2b068f69._0xa18cf611(new byte[7] { 254, 172, 177, 171, 170, 187, 227 }, 222) + _0x10970501 + _0x2b068f69._0xa18cf611(new byte[9] { 249, 184, 173, 173, 188, 180, 169, 173, 228 }, 217) + _0x0bfb58a8 + _0x2b068f69._0xa18cf611(new byte[6] { 149, 199, 218, 194, 198, 136 }, 181) + this._0x58348877.Length);
            }
#endif
        }
    }

    /// A hand-checked layout used only if twenty generated ones all failed: every
    /// target sits on the middle slot, dead centre of the arc.
    private _0xdd7a3562[] _0x9a791dcd(int _0x03b4e318)
    {
        int _0x28a40584 = _0x03b4e318 + 6;
        _0xdd7a3562[] _0x77d37ebb = new _0xdd7a3562[_0x28a40584];
        for (int _0x2ca33e61 = 0; _0x2ca33e61 < _0x28a40584; _0x2ca33e61++)
        {
            _0xdd7a3562 _0xa73cc29a = new _0xdd7a3562();
            _0xa73cc29a.TargetSlot = 1;
            int _0xfc943d2e = this._0xcd8f98a9(_0x2ca33e61);
            _0xa73cc29a.Slot0Colour = (_0xfc943d2e + 1) % _0x4f5b9c84.GateColourCount;
            _0xa73cc29a.Slot1Colour = _0xfc943d2e;
            _0xa73cc29a.Slot2Colour = (_0xfc943d2e + 2) % _0x4f5b9c84.GateColourCount;
            _0xa73cc29a.Slot0Present = true;
            _0xa73cc29a.Slot1Present = true;
            _0xa73cc29a.Slot2Present = true;
            _0xa73cc29a.Bow = 0f;
            _0x77d37ebb[_0x2ca33e61] = _0xa73cc29a;
        }

        return _0x77d37ebb;
    }

    private int[] _0x87e2cd7f(System.Random _0x3ea085b0, int _0xb338d60c, int _0x309e2739)
    {
        int[] _0x069cb6de = new int[_0xb338d60c];
        for (int _0xbd675e0b = 0; _0xbd675e0b < _0xb338d60c; _0xbd675e0b++)
        {
            int _0x658b65ec = _0x3ea085b0.Next(_0x309e2739);
            // never three of the same colour in a row: the memory game has to stay a
            // memory game rather than a stretch of "keep doing what you just did".
            if (_0xbd675e0b >= 2 && _0x069cb6de[_0xbd675e0b - 1] == _0x658b65ec && _0x069cb6de[_0xbd675e0b - 2] == _0x658b65ec)
            {
                _0x658b65ec = (_0x658b65ec + 1 + _0x3ea085b0.Next(_0x309e2739 - 1)) % _0x309e2739;
            }

            _0x069cb6de[_0xbd675e0b] = _0x658b65ec;
        }

        return _0x069cb6de;
    }

    private int[] _0xb9edb1b9;
    private const int SlotCount = 3;
}

internal static class _0x2b068f69
{
    internal static string _0xa18cf611(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}