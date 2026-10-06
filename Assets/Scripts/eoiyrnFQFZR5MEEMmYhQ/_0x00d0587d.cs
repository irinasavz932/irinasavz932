using DG.Tweening;
using UnityEngine;

/// Runs one delivery: energy, strikes, the mercy window that keeps a capture run
/// alive, and the two endings.
///
/// Why the run cannot end early (rule C.5), by construction rather than by average:
///   * energy only drains passively, so the floor is energy / drain = 171 seconds
///     on every route, for every seed and every tap pattern;
///   * a strike needs a dash that actually entered a ring, and a dash needs a
///     finger, so no input means no strikes at all;
///   * below MercyWindowSeconds the strike count is clamped and the energy has a
///     floor, so nothing can finish the run before second 42 — eleven seconds past
///     the last frame a review pass takes.
public sealed class _0x00d0587d : MonoBehaviour
{
    [SerializeField]
    private _0xd5c0fa0f _spawner;
    private void Update()
    {
        if (this._0x07967154)
            return;
        bool _0x4a233976 = _0xc21423fc.Instance != null && _0xc21423fc.Instance._0x90977c74;
        if (!this._0x6a7f68a1)
        {
            if (!_0x4a233976)
                return;
            this._0xc05cd85d();
            return;
        }

        if (!_0x4a233976)
        {
            // The pause pop is open. Freeze the flight and dress the pop once.
            if (!this._0x64e2c45b)
            {
                this._0x64e2c45b = true;
                if (this._popPresenter != null)
                {
                    this._popPresenter._0xd0c1700d(this._0x60fdc958, this._0xd952fa6f, this._0x0271c0ce());
                }
            }

            return;
        }

        this._0x64e2c45b = false;
        float dt = Time.deltaTime;
        this._0x26a60a0b += dt;
        if (this._0x82608917 && this._0x26a60a0b >= _0x06d167a9.PreviewSeconds)
        {
            this._0x82608917 = false;
            if (this._0x308a5a07 != null)
                this._0x308a5a07._0x313a5541();
        }

        if (this._0x26a60a0b >= _0x06d167a9.HintBrightSeconds && this._0x308a5a07 != null)
            this._0x308a5a07._0x3894cd2c();
        this._0xb194225f -= _0x44394cff.EnergyDrain(this._0xfeb05435) * dt;
        this._0xff8b8cbf();
        if (this._spawner != null)
            this._spawner._0x2bc3d415(dt);
        if (this._rider != null && this._rider._0xbaeae706())
        {
            this._0x3ac21d66();
        }

        this._0x8292b7d4();
        if (this._0xb194225f <= 0f)
        {
            this._0xe9289f02(false, _0xf11dcad5._0x25b13fe1(new byte[14] { 184, 166, 161, 168, 188, 207, 168, 174, 185, 170, 207, 160, 186, 187 }, 239));
            return;
        }

        if (this._0x33f9dc16 >= 3)
        {
            this._0xe9289f02(false, _0xf11dcad5._0x25b13fe1(new byte[11] { 235, 226, 243, 243, 226, 245, 135, 235, 232, 244, 243 }, 167));
            return;
        }

        if (this._0x60fdc958 >= this._0xd952fa6f)
        {
            this._0xc7c655f1();
        }
    }

    /// A seeded-looking nudge off the arc so two captured frames differ in shape and
    /// not only in a number. Derived from the run clock, so it stays deterministic.
    private float _0x9cc08444()
    {
        float _0xd0e520a7 = 7f + (this._0x7e66d820 % 6);
        return (this._0x7e66d820 % 2) == 0 ? _0xd0e520a7 : -_0xd0e520a7;
    }

    private int _0x60fdc958;
    /// Below the mercy window the run physically cannot end: the strike counter is
    /// held at two and the energy cannot fall past its floor.
    private void _0xff8b8cbf()
    {
        if (this._0x26a60a0b >= _0x06d167a9.MercyWindowSeconds)
            return;
        if (this._0x33f9dc16 > _0x06d167a9.MercyStrikeCap)
            this._0x33f9dc16 = _0x06d167a9.MercyStrikeCap;
        if (this._0xb194225f < _0x06d167a9.MercyEnergyFloor)
            this._0xb194225f = _0x06d167a9.MercyEnergyFloor;
    }

    private int _0xfeb05435;
    private void _0xc05cd85d()
    {
        this._0xfeb05435 = _0xbcb3a21c._0x6971edd3;
        int _0xd686371e = _0xbcb3a21c._0x104c9344 + 1;
        _0xbcb3a21c._0x104c9344 = _0xd686371e;
        this._0xd952fa6f = _0x44394cff.GateTarget(this._0xfeb05435);
        this._0x08e3fc09 = _0x44394cff.StartEnergy(this._0xfeb05435);
        this._0xb194225f = this._0x08e3fc09;
        this._0x60fdc958 = 0;
        this._0x7e66d820 = 0;
        this._0x33f9dc16 = 0;
        this._0x26a60a0b = 0f;
        this._0x6a7f68a1 = true;
        this._0x82608917 = true;
        Camera _0x9e55fe5c = Camera.main;
        this._0x0f800e7a = _0x9e55fe5c == null ? null : _0x9e55fe5c.transform;
        if (this._layout != null)
            this._layout._0xf27484bb(this._0xfeb05435, _0xd686371e);
        if (this._spawner != null)
            this._spawner._0x25aa691d(this._0xfeb05435, this._layout);
        if (this._rider != null)
            this._rider._0xd730718a();
        if (this._0x308a5a07 != null)
        {
            this._0x308a5a07._0x7ff05bbf(this._layout, this._0xd952fa6f);
            this._0x308a5a07._0x1d017a0b(0);
        }

        this._0x8292b7d4();
    }

    [SerializeField]
    private _0xe4b6b896 _popPresenter;
    private int _0x7e66d820;
    private void _0x8292b7d4()
    {
        if (this._0x308a5a07 == null)
            return;
        this._0x308a5a07._0x336ab0ce(this._0x60fdc958, this._0xd952fa6f);
        this._0x308a5a07._0x3725d385(this._0x08e3fc09 <= 0f ? 0f : this._0xb194225f / this._0x08e3fc09);
        if (this._spawner != null)
        {
            this._0x308a5a07._0x3052574a(this._spawner._0x91726a6a(0), this._spawner._0x91726a6a(1), this._spawner._0x91726a6a(2));
        }
    }

    [SerializeField]
    private _0xe2597f34 _layout;
    private bool _0x07967154;
    private bool _0x64e2c45b;
    [SerializeField]
    private _0x0a15ca67 _rider;
    private bool _0x82608917;
    private void _0xe03f7399(bool _0x17fcf046, string _0x0465e864)
    {
        int _0xfc140f99 = _0xbcb3a21c.Commit(this._0x60fdc958, this._0xd952fa6f, this._0x7e66d820, _0x17fcf046, this._0xfeb05435);
        string _0x68435b50 = _0xbcb3a21c.AccuracyText(this._0x60fdc958, this._0x7e66d820);
        if (this._popPresenter != null)
        {
            this._popPresenter._0x4b6908d6(_0x17fcf046, _0x0465e864, this._0x60fdc958, this._0xd952fa6f, _0x68435b50, _0xfc140f99);
        }
    }

    private int _0xd952fa6f;
    private float _0xb194225f;
    private void _0xe9289f02(bool _0x99204c20, string _0xb325eec4)
    {
        if (this._0x07967154)
            return;
        this._0x07967154 = true;
        if (this._spawner != null)
            this._spawner._0x9db5b331();
        if (this._rider != null)
            this._rider._0xc63c370c();
        DOVirtual.DelayedCall(0.9f, () => this._0xe03f7399(_0x99204c20, _0xb325eec4));
    }

    private _0xa38770b5 _0x308a5a07;
    private float _0x26a60a0b;
    private Transform _0x0f800e7a;
    private void _0xc7c655f1()
    {
        if (this._0x07967154)
            return;
        this._0x07967154 = true;
        if (this._spawner != null)
        {
            Vector3 _0x7733e9ac = this._spawner._0x1f0ee0f3();
            if (this._rider != null)
                this._rider._0x15dc3c6d(_0x7733e9ac, 0.9f);
            this._spawner._0x9db5b331();
        }

        DOVirtual.DelayedCall(1.0f, () => this._0xe03f7399(true, _0xf11dcad5._0x25b13fe1(new byte[16] { 207, 198, 215, 215, 198, 209, 163, 199, 198, 207, 202, 213, 198, 209, 198, 199 }, 131)));
    }

    private float _0x08e3fc09;
    private int _0x0271c0ce()
    {
        if (this._0x08e3fc09 <= 0f)
            return 0;
        return Mathf.RoundToInt(Mathf.Clamp01(this._0xb194225f / this._0x08e3fc09) * 100f);
    }

    private bool _0x6a7f68a1;
    private void _0x3ac21d66()
    {
        this._0xb194225f -= _0x06d167a9.DashEnergyCost;
        if (this._spawner == null || this._rider == null)
            return;
        Vector2 _0xddf7abe0 = this._rider._0x67a5939b;
        _0xd5c0fa0f._0x8f124af6 _0x3ac44919 = this._spawner._0x53453974(_0xddf7abe0);
        if (_0x3ac44919 == null)
        {
            // A dash into open sky: only the dash itself costs anything.
            if (this._0x308a5a07 != null)
                this._0x308a5a07._0x920553a2(_0xf11dcad5._0x25b13fe1(new byte[7] { 110, 111, 0, 114, 105, 110, 103 }, 32), _0x4f5b9c84._0x788b18b3);
            if (this._rider != null)
                this._rider._0x25a94279(this._0x9cc08444());
            return;
        }

        int _0x526994fc = this._spawner._0xe6b0159c(_0x3ac44919, _0xddf7abe0);
        if (_0x526994fc < 0)
        {
            if (this._0x308a5a07 != null)
                this._0x308a5a07._0x920553a2(_0xf11dcad5._0x25b13fe1(new byte[7] { 71, 92, 92, 51, 95, 92, 68 }, 19), _0x4f5b9c84._0x788b18b3);
            this._rider._0x25a94279(this._0x9cc08444());
            return;
        }

        this._0x7e66d820++;
        Vector3 _0x43c25865 = this._spawner._0x9ce4368c(_0x3ac44919, _0x526994fc);
        bool _0x190b88cd = _0x3ac44919.Colours[_0x526994fc] == _0x3ac44919.TargetColour;
        this._spawner._0x7fb1abb2(_0x3ac44919, _0x526994fc, _0x190b88cd);
        if (_0x190b88cd)
        {
            this._0x60fdc958++;
            this._0xb194225f += _0x06d167a9.GateEnergyGain;
            if (this._0xb194225f > this._0x08e3fc09)
                this._0xb194225f = this._0x08e3fc09;
            this._spawner._0x77444a60(_0x43c25865, _0x4f5b9c84._0x53c78623, 8);
            if (this._0x308a5a07 != null)
                this._0x308a5a07._0x920553a2(_0xf11dcad5._0x25b13fe1(new byte[5] { 214, 217, 208, 212, 199 }, 149), _0x4f5b9c84._0xe1ed2d6d);
            return;
        }

        // A wrong ring early in the flight costs speed, not the letter.
        bool _0xb2189143 = this._0x26a60a0b < _0x06d167a9.StrikeGraceSeconds;
        bool _0x2e781763 = (this._0x26a60a0b - this._0x265851cc) < _0x06d167a9.StrikeMinGapSeconds;
        this._spawner._0x77444a60(_0x43c25865, _0x4f5b9c84._0x96f3147f, 6);
        if (_0xb2189143 || _0x2e781763)
        {
            if (this._0x308a5a07 != null)
                this._0x308a5a07._0x920553a2(_0xf11dcad5._0x25b13fe1(new byte[9] { 210, 201, 201, 166, 195, 199, 212, 202, 223 }, 134), _0x4f5b9c84._0x96f3147f);
            this._rider._0x25a94279(this._0x9cc08444());
            return;
        }

        this._0x33f9dc16++;
        this._0x265851cc = this._0x26a60a0b;
        this._0xb194225f -= _0x06d167a9.StrikeEnergyCost;
        this._0xff8b8cbf();
        if (this._0x308a5a07 != null)
        {
            this._0x308a5a07._0x1d017a0b(this._0x33f9dc16);
            this._0x308a5a07._0x920553a2(_0xf11dcad5._0x25b13fe1(new byte[10] { 219, 222, 195, 194, 203, 172, 222, 197, 194, 203 }, 140), _0x4f5b9c84._0x96f3147f);
        }

        if (this._0x0f800e7a != null)
            this._0x0f800e7a.DOShakePosition(0.2f, 0.12f, 12, 70f, false, true);
        this._rider._0x25a94279(this._0x9cc08444());
    }

    private float _0x265851cc = -999f;
    /// Called by the scene bootstrap once the HUD exists.
    public void _0xcebcceda(_0xa38770b5 _0x5d8f9c0b)
    {
        this._0x308a5a07 = _0x5d8f9c0b;
        if (this._0x308a5a07 != null)
            this._0x308a5a07._0x85d3111d();
    }

    private int _0x33f9dc16;
}

internal static class _0xf11dcad5
{
    internal static string _0x25b13fe1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}