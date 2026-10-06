using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x27a906ad : MonoBehaviour
{
    private RectTransform _0x75ae8c34;
    private static void ResolutionChanged()
    {
        _0xb8f3ce58.x = Screen.width;
        _0xb8f3ce58.y = Screen.height;
        _0x43c395f1 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xa5ed04e0.Invoke();
    }

    private void Update()
    {
        if (_0x8cbd8a6a.Count == 0 || _0x8cbd8a6a[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xf07e9074)
            OrientationChanged();
        if (Screen.safeArea != _0x43c395f1)
            SafeAreaChanged();
        if (Screen.width != _0xb8f3ce58.x || Screen.height != _0xb8f3ce58.y)
            ResolutionChanged();
    }

    private void Awake()
    {
        if (!_0x8cbd8a6a.Contains(this))
            _0x8cbd8a6a.Add(this);
        this._0x3fa5a583 = this.GetComponent<Canvas>();
        this._0xbfcbae2c = this.GetComponent<CanvasScaler>();
        if (this._0xbfcbae2c != null)
            this._0x49a6c97e = this._0xbfcbae2c.referenceResolution;
        this._0x75ae8c34 = this.GetComponent<RectTransform>();
        this._0x7b2e2ab1 = this.transform.Find(_0x16b4e5d0._0x2febfd11(new byte[8] { 106, 88, 95, 92, 120, 75, 92, 88 }, 57)) as RectTransform;
        if (!_0xf248f911)
        {
            _0xf07e9074 = Screen.orientation;
            _0xb8f3ce58.x = Screen.width;
            _0xb8f3ce58.y = Screen.height;
            _0x43c395f1 = Screen.safeArea;
            _0xf248f911 = true;
        }

        this._0x78d8428e();
    }

    private Canvas _0x3fa5a583;
    private static ScreenOrientation _0xf07e9074 = ScreenOrientation.LandscapeLeft;
    private static Rect _0x43c395f1 = Rect.zero;
    private void OnDestroy()
    {
        if (_0x8cbd8a6a != null && _0x8cbd8a6a.Contains(this))
            _0x8cbd8a6a.Remove(this);
    }

    private static void OrientationChanged()
    {
        _0xf07e9074 = Screen.orientation;
        _0xb8f3ce58.x = Screen.width;
        _0xb8f3ce58.y = Screen.height;
        _0x43c395f1 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xa5ed04e0.Invoke();
    }

    private void _0x78d8428e()
    {
        if (this._0x7b2e2ab1 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x7b248101 = Screen.safeArea;
        Vector2 _0x639f9aea = _0x7b248101.position;
        Vector2 _0xf3a0df46 = _0x7b248101.position + _0x7b248101.size;
        _0x639f9aea.x /= screenWidth;
        _0x639f9aea.y /= screenHeight;
        _0xf3a0df46.x /= screenWidth;
        _0xf3a0df46.y /= screenHeight;
        this._0x7b2e2ab1.anchorMin = _0x639f9aea;
        this._0x7b2e2ab1.anchorMax = _0xf3a0df46;
        this._0x7b2e2ab1.offsetMin = Vector2.zero;
        this._0x7b2e2ab1.offsetMax = Vector2.zero;
        if (this._0xbfcbae2c == null)
            return;
        Vector2 _0x241d74e5 = _0xf3a0df46 - _0x639f9aea;
        float _0xc9a29dfa = 2f - _0x241d74e5.x;
        float _0x61585901 = 2f - _0x241d74e5.y;
        this._0xbfcbae2c.referenceResolution = this._0x49a6c97e * new Vector2(_0xc9a29dfa, _0x61585901);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x78b1b0b1 = 0; _0x78b1b0b1 < _0x8cbd8a6a.Count; _0x78b1b0b1++)
            _0x8cbd8a6a[_0x78b1b0b1]._0x78d8428e();
    }

    private static Vector2 _0xb8f3ce58 = Vector2.zero;
    private static void SafeAreaChanged()
    {
        _0x43c395f1 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private CanvasScaler _0xbfcbae2c;
    private static UnityEvent _0xa5ed04e0 = new();
    private void Start()
    {
    }

    private static readonly List<_0x27a906ad> _0x8cbd8a6a = new();
    private static bool _0xf248f911;
    private RectTransform _0x7b2e2ab1;
    private Vector2 _0x49a6c97e;
}

internal static class _0x16b4e5d0
{
    internal static string _0x2febfd11(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}