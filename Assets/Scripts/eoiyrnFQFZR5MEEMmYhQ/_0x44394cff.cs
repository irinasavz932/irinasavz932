using UnityEngine;

/// The three delivery routes, expressed as pure lookups so nothing is held in a
/// static field that an obfuscator could reorder (rule C.52).
///
/// Passive survival is what keeps a capture run alive: with no input at all the only
/// drain is the per-second one, so the floor is energy / drain =
/// 171 / 171 / 173 seconds. That holds for every seed and every tap pattern.
internal static class _0x44394cff
{
    public static string PaceName(int _0x548d5402)
    {
        switch (Clamp(_0x548d5402))
        {
            case 0:
                return _0xd9147812._0x0005e428(new byte[4] { 48, 50, 63, 62 }, 115);
            case 1:
                return _0xd9147812._0x0005e428(new byte[5] { 120, 104, 115, 105, 113 }, 58);
            default:
                return _0xd9147812._0x0005e428(new byte[5] { 242, 251, 232, 233, 242 }, 186);
        }
    }

    /// How many of the five ring colours this route draws from.
    public static int ColourCount(int _0xdc50a706)
    {
        switch (Clamp(_0xdc50a706))
        {
            case 0:
                return 3;
            case 1:
                return 4;
            default:
                return 5;
        }
    }

    /// World units per second the rows travel towards the courier.
    public static float RowSpeed(int _0xce16f938)
    {
        switch (Clamp(_0xce16f938))
        {
            case 0:
                return 0.78f;
            case 1:
                return 0.92f;
            default:
                return 1.08f;
        }
    }

    /// Starting (and maximum) energy.
    public static float StartEnergy(int _0xe2fb398c)
    {
        switch (Clamp(_0xe2fb398c))
        {
            case 0:
                return 120f;
            case 1:
                return 120f;
            default:
                return 130f;
        }
    }

    public const int Count = 3;
    /// Seconds between two rows leaving the spawn line.
    public static float RowCadence(int _0x1beaeb4b)
    {
        switch (Clamp(_0x1beaeb4b))
        {
            case 0:
                return 6.6f;
            case 1:
                return 5.8f;
            default:
                return 5.0f;
        }
    }

    /// How many rings have to be cleared for the letter to arrive.
    public static int GateTarget(int _0x76694cce)
    {
        switch (Clamp(_0x76694cce))
        {
            case 0:
                return 6;
            case 1:
                return 9;
            default:
                return 12;
        }
    }

    public const int DefaultRoute = 0;
    /// Whether this route sends gusts across the lane.
    public static bool HasGusts(int _0xfd54fc84)
    {
        return Clamp(_0xfd54fc84) == 2;
    }

    /// Energy lost per second with no input at all.
    public static float EnergyDrain(int _0xb541a618)
    {
        switch (Clamp(_0xb541a618))
        {
            case 0:
                return 0.70f;
            case 1:
                return 0.70f;
            default:
                return 0.75f;
        }
    }

    public static string RouteName(int _0xfe9836c1)
    {
        switch (Clamp(_0xfe9836c1))
        {
            case 0:
                return _0xd9147812._0x0005e428(new byte[11] { 228, 236, 232, 237, 230, 254, 137, 229, 232, 231, 236 }, 169);
            case 1:
                return _0xd9147812._0x0005e428(new byte[10] { 63, 36, 59, 40, 63, 77, 47, 40, 35, 41 }, 109);
            default:
                return _0xd9147812._0x0005e428(new byte[11] { 189, 186, 161, 188, 163, 206, 188, 167, 170, 169, 171 }, 238);
        }
    }

    /// Stamps awarded on top of the per-gate score when the letter arrives.
    public static int RouteBonus(int _0xdcc1e3e8)
    {
        switch (Clamp(_0xdcc1e3e8))
        {
            case 0:
                return 40;
            case 1:
                return 80;
            default:
                return 140;
        }
    }

    /// Seconds a route lasts with no input whatsoever — printed on the route sheet
    /// so the player can see the promise the design makes.
    public static int PassiveSeconds(int _0xc7228b9e)
    {
        float _0x23e11dcc = EnergyDrain(_0xc7228b9e);
        if (_0x23e11dcc <= 0f)
            return 0;
        return Mathf.RoundToInt(StartEnergy(_0xc7228b9e) / _0x23e11dcc);
    }

    public static int Clamp(int _0x64bc8f82)
    {
        if (_0x64bc8f82 < 0)
            return 0;
        if (_0x64bc8f82 >= Count)
            return Count - 1;
        return _0x64bc8f82;
    }
}

internal static class _0xd9147812
{
    internal static string _0x0005e428(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}