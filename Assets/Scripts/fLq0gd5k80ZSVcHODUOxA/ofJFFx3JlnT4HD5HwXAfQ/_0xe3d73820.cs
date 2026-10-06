using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xe3d73820 : MonoBehaviour
{
    private static void ResolutionChanged()
    {
        _0xe8f30fdc.x = Screen.width;
        _0xe8f30fdc.y = Screen.height;
        _0xa5cb3475.Invoke();
    }

    private static Rect _0x2425497a = Rect.zero;
    private static void SafeAreaChanged()
    {
        _0x2425497a = Screen.safeArea;
        for (int _0x2e733e7c = 0; _0x2e733e7c < _0xd3fa6f84.Count; _0x2e733e7c++)
            _0xd3fa6f84[_0x2e733e7c]._0xb9acef32();
    }

    private static void OrientationChanged()
    {
        _0x4e27b0fc = Screen.orientation;
        _0xe8f30fdc.x = Screen.width;
        _0xe8f30fdc.y = Screen.height;
        _0xa5cb3475.Invoke();
    }

    private static ScreenOrientation _0x4e27b0fc = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0xd3fa6f84.Contains(this))
            _0xd3fa6f84.Add(this);
        this._0xcca046e5 = this.GetComponent<Canvas>();
        this._0x17f26b23 = this.GetComponent<RectTransform>();
        this._0xfa74fed7 = this.transform.Find(_0xb840fd4a._0xcef0d807(new byte[8] { 246, 196, 195, 192, 228, 215, 192, 196 }, 165)) as RectTransform;
        if (!_0xc33082b1)
        {
            _0x4e27b0fc = Screen.orientation;
            _0xe8f30fdc.x = Screen.width;
            _0xe8f30fdc.y = Screen.height;
            _0x2425497a = Screen.safeArea;
            _0xc33082b1 = true;
        }

        this._0xb9acef32();
    }

    private Canvas _0xcca046e5;
    private void OnDestroy()
    {
        if (_0xd3fa6f84 != null && _0xd3fa6f84.Contains(this))
            _0xd3fa6f84.Remove(this);
    }

    private void Update()
    {
        if (_0xd3fa6f84[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x4e27b0fc)
            OrientationChanged();
        if (Screen.safeArea != _0x2425497a)
            SafeAreaChanged();
        if (Screen.width != _0xe8f30fdc.x || Screen.height != _0xe8f30fdc.y)
            ResolutionChanged();
    }

    private void _0xb9acef32()
    {
        if (this._0xfa74fed7 == null)
            return;
        Rect _0x4091385f = Screen.safeArea;
        Vector2 _0x24da2806 = _0x4091385f.position;
        Vector2 _0xe677ed88 = _0x4091385f.position + _0x4091385f.size;
        _0x24da2806.x /= this._0xcca046e5.pixelRect.width;
        _0x24da2806.y /= this._0xcca046e5.pixelRect.height;
        _0xe677ed88.x /= this._0xcca046e5.pixelRect.width;
        _0xe677ed88.y /= this._0xcca046e5.pixelRect.height;
        this._0xfa74fed7.anchorMin = _0x24da2806;
        this._0xfa74fed7.anchorMax = _0xe677ed88;
    }

    private static Vector2 _0xe8f30fdc = Vector2.zero;
    private static bool _0xc33082b1;
    private static UnityEvent _0xa5cb3475 = new();
    private RectTransform _0xfa74fed7;
    private static readonly List<_0xe3d73820> _0xd3fa6f84 = new();
    private RectTransform _0x17f26b23;
}

internal static class _0xb840fd4a
{
    internal static string _0xcef0d807(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}