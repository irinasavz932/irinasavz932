using UnityEngine;

/// Named sorting orders and camera-derived sizes for the flight scene.
/// Every world sprite in this game takes its order from here, never from a literal
/// written at the call site, and every size is a fraction of the camera frustum.
internal static class _0x06d167a9
{
    public const float StrikeGraceSeconds = 28.0f;
    /// Half the visible height in world units.
    public static float HalfHeight(Camera _0x1ebb1188)
    {
        return _0x1ebb1188 == null ? 5f : _0x1ebb1188.orthographicSize;
    }

    public const float ArcRadius = 6.2f;
    public const int ArcGuideOrder = -13;
    public const float GateCoreOfRing = 0.62f;
    public const int WindStreakOrder = -8;
    public const float MercyWindowSeconds = 42.0f;
    public const int TrailOrder = -7;
    public const int GateRimFrontOrder = -3;
    public const float RowDespawnX = -3.10f;
    public const int CourierOrder = -5;
    public const float CourierHeightFraction = 0.115f;
    public const float RingCatchFraction = 0.72f;
    public const float DashCooldown = 0.80f;
    public const float WindStreakHeightFraction = 0.080f;
    // Arc the courier swings along, in world units, measured from the camera centre.
    public const float ArcCentreX = -7.0f;
    public const float GateEnergyGain = 16f;
    public const float RowLowY = -1.60f;
    /// Half the visible width in world units.
    public static float HalfWidth(Camera _0xce2f6671)
    {
        float _0x96f00d8f = HalfHeight(_0xce2f6671);
        float _0x9bc816fc = (_0xce2f6671 == null || _0xce2f6671.aspect <= 0f) ? 0.45f : _0xce2f6671.aspect;
        return _0x96f00d8f * _0x9bc816fc;
    }

    public const float HedgeHeightFraction = 0.110f;
    public const int FarFieldOrder = -17;
    public const float HaystackHeightFraction = 0.160f;
    // Round pacing that keeps a capture run alive (rule C.5).
    public const float PreviewSeconds = 3.0f;
    /// A square sprite size taken as a fraction of the full camera height.
    public static Vector2 Square(Camera _0x8db7bc77, float _0x37183834)
    {
        float _0x872a242e = 2f * HalfHeight(_0x8db7bc77) * _0x37183834;
        return new Vector2(_0x872a242e, _0x872a242e);
    }

    public const float DashRise = 0.40f;
    public const float RowSpawnX = 3.10f;
    public const int GateRingOrder = -10;
    public const float ArcDotHeightFraction = 0.018f;
    public const float ArcSweepDegreesPerSecond = 46f;
    public const int MidFieldOrder = -15;
    // Sizes as a fraction of the full camera height (2 * orthographicSize).
    public const float GateRingHeightFraction = 0.190f;
    public const float CottageHeightFraction = 0.210f;
    // Gate rows: three rings stacked in a column, marching right to left.
    public const float RowTopY = 2.80f;
    public const int LetterOrder = -4;
    public const float ArcSpanDegrees = 21f;
    public const float MercyEnergyFloor = 8f;
    public const float StrikeMinGapSeconds = 18.0f;
    public const int GateCoreOrder = -11;
    public const float HintBrightSeconds = 9.0f;
    // Dash: a short lunge along +X and back.
    public const float DashReach = 1.90f;
    public const float SparkHeightFraction = 0.035f;
    public const float ArcCentreY = 0.6f;
    // Energy economy.
    public const float DashEnergyCost = 5f;
    public const int MercyStrikeCap = 2;
    // Sorting band: the background canvas owns -30 and the pops own 10 and up,
    // so every SpriteRenderer this game creates lives strictly inside -19 .. -1.
    public const int BackdropBandOrder = -19;
    public const float RowMidY = 0.60f;
    public const float MailboxHeightFraction = 0.090f;
    public const float DashFall = 0.55f;
    public const int SparkOrder = -2;
    public const float StrikeEnergyCost = 8f;
    public const int CottageOrder = -12;
    public const float LetterOfCourier = 0.34f;
}