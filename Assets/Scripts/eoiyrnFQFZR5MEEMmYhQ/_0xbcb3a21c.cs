using UnityEngine;

/// Stamps are a score, not a currency: nothing can be bought with them and nothing
/// is wagered. They live in the template's own player store so the menu counter
/// (MoneyCount) shows them without a second bookkeeping path.
internal static class _0xbcb3a21c
{
    public static string AccuracyText(int _0xccc6bf99, int _0x67738235)
    {
        if (_0x67738235 <= 0)
            return _0x7bdd8a10._0x5b105e48(new byte[2] { 235, 235 }, 198);
        return Mathf.RoundToInt(Accuracy(_0xccc6bf99, _0x67738235) * 100f) + _0x7bdd8a10._0x5b105e48(new byte[1] { 167 }, 130);
    }

    private static readonly string BestOfKey = _0x7bdd8a10._0x5b105e48(new byte[12] { 103, 77, 72, 70, 73, 85, 99, 68, 82, 85, 110, 71 }, 33);
    /// Bank a finished run and return the stamps it was worth.
    public static int Commit(int _0x5c7d04d3, int _0x135114aa, int _0x02726dde, bool _0x66909dc9, int _0xd5bd9921)
    {
        int _0x73d1412c = RunStamps(_0x5c7d04d3, _0x02726dde, _0x66909dc9, _0xd5bd9921);
        _0x0c2ee824._0xc63c2332._0xe393db65 = _0x0c2ee824._0xc63c2332._0xe393db65 + _0x73d1412c;
        if (_0x5c7d04d3 > PlayerPrefs.GetInt(BestGatesKey, 0))
        {
            PlayerPrefs.SetInt(BestGatesKey, _0x5c7d04d3);
            PlayerPrefs.SetInt(BestOfKey, _0x135114aa);
        }

        PlayerPrefs.SetInt(LastAccuracyKey, _0x02726dde <= 0 ? 0 : Mathf.RoundToInt(Accuracy(_0x5c7d04d3, _0x02726dde) * 100f));
        PlayerPrefs.Save();
        return _0x73d1412c;
    }

    public static bool _0xe6d389b0
    {
        get
        {
            return PlayerPrefs.GetInt(LastAccuracyKey, -1) >= 0;
        }
    }

    /// Correct rings over rings actually entered. Zero entries reads as zero, and
    /// the caller prints "--" rather than a made-up number.
    public static float Accuracy(int _0x3656e68b, int _0x181607d9)
    {
        if (_0x181607d9 <= 0)
            return 0f;
        return (float)_0x3656e68b / _0x181607d9;
    }

    private static readonly string AttemptKey = _0x7bdd8a10._0x5b105e48(new byte[18] { 125, 87, 82, 92, 83, 79, 122, 79, 79, 94, 86, 75, 79, 120, 84, 78, 85, 79 }, 59);
    /// Accuracy of the last finished run, in whole percent. -1 means "no run yet".
    public static int _0x8167c850
    {
        get
        {
            return PlayerPrefs.GetInt(LastAccuracyKey, -1);
        }
    }

    /// The route the player last chose.
    public static int _0x6971edd3
    {
        get
        {
            return _0x44394cff.Clamp(PlayerPrefs.GetInt(RouteKey, _0x44394cff.DefaultRoute));
        }

        set
        {
            PlayerPrefs.SetInt(RouteKey, _0x44394cff.Clamp(value));
        }
    }

    public static int _0x36591e5d
    {
        get
        {
            return PlayerPrefs.GetInt(BestGatesKey, 0);
        }
    }

    /// Stamps earned by a finished run.
    public static int RunStamps(int _0x29cb38df, int _0xb343c52f, bool _0x8dd4d02e, int _0x4611bc02)
    {
        int _0x004c0811 = _0x29cb38df * 15;
        float _0x742a49af = Accuracy(_0x29cb38df, _0xb343c52f);
        if (_0x742a49af >= 0.90f)
            _0x004c0811 += 60;
        else if (_0x742a49af >= 0.70f)
            _0x004c0811 += 30;
        if (_0x8dd4d02e)
            _0x004c0811 += _0x44394cff.RouteBonus(_0x4611bc02);
        return _0x004c0811;
    }

    private static readonly string LastAccuracyKey = _0x7bdd8a10._0x5b105e48(new byte[18] { 82, 120, 125, 115, 124, 96, 88, 117, 103, 96, 85, 119, 119, 97, 102, 117, 119, 109 }, 20);
    public static int _0x139e76b0
    {
        get
        {
            return PlayerPrefs.GetInt(BestOfKey, 0);
        }
    }

    private static readonly string RouteKey = _0x7bdd8a10._0x5b105e48(new byte[16] { 216, 242, 247, 249, 246, 234, 204, 241, 235, 234, 251, 215, 240, 250, 251, 230 }, 158);
    private static readonly string BestGatesKey = _0x7bdd8a10._0x5b105e48(new byte[15] { 8, 34, 39, 41, 38, 58, 12, 43, 61, 58, 9, 47, 58, 43, 61 }, 78);
    /// How many runs have been started. Feeds the per-attempt seed, so two runs in
    /// a row never lay the rings out the same way.
    public static int _0x104c9344
    {
        get
        {
            return PlayerPrefs.GetInt(AttemptKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(AttemptKey, value);
        }
    }
}

internal static class _0x7bdd8a10
{
    internal static string _0x5b105e48(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}