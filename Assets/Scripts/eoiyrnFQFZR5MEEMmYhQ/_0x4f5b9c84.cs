using UnityEngine;

/// The whole colour vocabulary of the game, in one place.
/// Every entry is a property that builds its Color on the spot, so no static field
/// initialiser can ever depend on another one (rule C.52).
internal static class _0x4f5b9c84
{
    /// The face of the route card the player has chosen.
    public static Color _0x6349cce2
    {
        get
        {
            return Rgb(0x30, 0x3F, 0x5F, 1f);
        }
    }

    /// Ink at the alpha a meter track needs to read on any background.
    public static Color _0xeb080c87
    {
        get
        {
            return Rgb(0x27, 0x33, 0x4D, 0.55f);
        }
    }

    /// Sage, the "correct" accent.
    public static Color _0x9e02df91
    {
        get
        {
            return Rgb(0x65, 0xBF, 0x69, 1f);
        }
    }

    /// A shade lighter than paper, for card interiors.
    public static Color _0xeb1fc64e
    {
        get
        {
            return Rgb(0xFF, 0xF8, 0xE7, 1f);
        }
    }

    private static Color Rgb(int _0x53ca0f58, int _0xa687d0c4, int _0x85b99966, float _0x78732427)
    {
        return new Color(_0x53ca0f58 / 255f, _0xa687d0c4 / 255f, _0x85b99966 / 255f, _0x78732427);
    }

    /// Sand, for disabled states and empty meter tracks.
    public static Color _0x788b18b3
    {
        get
        {
            return Rgb(0xE8, 0xDD, 0xC4, 1f);
        }
    }

    /// Ochre, the pressed / warning accent.
    public static Color _0x96f3147f
    {
        get
        {
            return Rgb(0xF2, 0x8A, 0x45, 1f);
        }
    }

    /// The ASCII name of gate colour <paramref name = "index"/>, so the queue reads
    /// without relying on colour vision alone.
    public static string GateColourName(int _0x51812909)
    {
        switch (((_0x51812909 % GateColourCount) + GateColourCount) % GateColourCount)
        {
            case 0:
                return _0xe9cda373._0xdb1d3b25(new byte[5] { 114, 109, 96, 100, 113 }, 37);
            case 1:
                return _0xe9cda373._0xdb1d3b25(new byte[5] { 12, 4, 11, 12, 27 }, 73);
            case 2:
                return _0xe9cda373._0xdb1d3b25(new byte[6] { 15, 7, 3, 6, 13, 21 }, 66);
            case 3:
                return _0xe9cda373._0xdb1d3b25(new byte[3] { 252, 228, 246 }, 175);
            default:
                return _0xe9cda373._0xdb1d3b25(new byte[5] { 248, 253, 250, 241, 250 }, 180);
        }
    }

    /// The same colour with a different alpha.
    public static Color Fade(Color _0xa9c8723a, float _0x977308e0)
    {
        return new Color(_0xa9c8723a.r, _0xa9c8723a.g, _0xa9c8723a.b, _0x977308e0);
    }

    /// Paper. The face colour of almost every label.
    public static Color _0x53c78623
    {
        get
        {
            return Rgb(0xFF, 0xF2, 0xD5, 1f);
        }
    }

    /// Evening sky, the cool accent.
    public static Color _0x38e8a2b3
    {
        get
        {
            return Rgb(0x4A, 0x9D, 0xDA, 1f);
        }
    }

    /// Ink at the alpha that dims the menu behind a sheet.
    public static Color _0x55931cb1
    {
        get
        {
            return Rgb(0x27, 0x33, 0x4D, 0.55f);
        }
    }

    /// Ink, the dark of every outline and primary plate.
    public static Color _0x48c5d130
    {
        get
        {
            return Rgb(0x27, 0x33, 0x4D, 1f);
        }
    }

    /// Wheat, the main accent.
    public static Color _0xe1ed2d6d
    {
        get
        {
            return Rgb(0xF7, 0xC9, 0x4C, 1f);
        }
    }

    public const int GateColourCount = 5;
    /// The face of a route card that is merely on offer.
    public static Color _0x9dc279f8
    {
        get
        {
            return Rgb(0x1B, 0x23, 0x36, 0.80f);
        }
    }

    /// Ink at the alpha that darkens the splash away from the menu.
    public static Color _0x2543b8e0
    {
        get
        {
            return Rgb(0x27, 0x33, 0x4D, 0.62f);
        }
    }

    /// The tint of gate ring number <paramref name = "index"/>.
    public static Color GateColour(int _0xf08610e9)
    {
        switch (((_0xf08610e9 % GateColourCount) + GateColourCount) % GateColourCount)
        {
            case 0:
                return _0xe1ed2d6d;
            case 1:
                return _0x96f3147f;
            case 2:
                return _0x9e02df91;
            case 3:
                return _0x38e8a2b3;
            default:
                return _0xeb1fc64e;
        }
    }

    /// A spent strike pip.
    public static Color _0x49501795
    {
        get
        {
            return Rgb(0x27, 0x33, 0x4D, 0.35f);
        }
    }
}

internal static class _0xe9cda373
{
    internal static string _0xdb1d3b25(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}