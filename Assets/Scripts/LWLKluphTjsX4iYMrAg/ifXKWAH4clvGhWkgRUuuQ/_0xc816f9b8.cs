using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xc816f9b8 : MonoBehaviour
{
    private Touch? _0x62f78dac(Bounds _0x050b4eb5, TouchPhase _0x9db5861f)
    {
        if (!_0xc21423fc.Instance._0x90977c74)
            return null;
        foreach (Touch _0xddde8991 in Touch.activeTouches)
            if (_0xddde8991.phase == _0x9db5861f)
            {
                Vector3 _0xf238bbd0 = Camera.main.ScreenToWorldPoint(_0xddde8991.screenPosition);
                Vector3 _0x38857e1e = new(_0xf238bbd0.x, _0xf238bbd0.y, _0x050b4eb5.center.z);
                if (_0x050b4eb5.Contains(_0x38857e1e) && this._0xc1ea611c(_0xddde8991))
                    return _0xddde8991;
            }

        return null;
    }

    private Touch? _0x427b2506(Bounds _0x41981d36)
    {
        if (!_0xc21423fc.Instance._0x90977c74)
            return null;
        foreach (Touch _0x95bc38cf in Touch.activeTouches)
            if (!_0x95bc38cf.ended)
            {
                Vector3 _0x11573aa7 = Camera.main.ScreenToWorldPoint(_0x95bc38cf.screenPosition);
                Vector3 _0x0c2b02fd = new(_0x11573aa7.x, _0x11573aa7.y, _0x41981d36.center.z);
                if (_0x41981d36.Contains(_0x0c2b02fd) && this._0xc1ea611c(_0x95bc38cf))
                    return _0x95bc38cf;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xb5d5c8de = this.gameObject.GetComponent<_0xc816f9b8>();
    }

    private Touch? _0x43ad1ddb()
    {
        if (!_0xc21423fc.Instance._0x90977c74)
            return null;
        foreach (Touch _0x0b03f916 in Touch.activeTouches)
            if (_0x0b03f916.ended)
                if (this._0xc1ea611c(_0x0b03f916))
                    return _0x0b03f916;
        return null;
    }

    private bool _0xc1ea611c(Touch? _0x3b966853)
    {
        if (!_0x3b966853.HasValue)
            return false;
        Vector3 _0x0dba990d = Camera.main.ScreenToWorldPoint(_0x3b966853.Value.screenPosition);
        Vector3 _0x2a8e9f2e = _0x0dba990d;
        _0x2a8e9f2e.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x2a8e9f2e))
            return true;
        _0x3b966853 = null;
        return false;
    }

    private bool _0xd0f06332(Touch? _0x21e570a5, Bounds _0x023ba2c3, TouchPhase _0x1c1f6100)
    {
        if (!_0xc21423fc.Instance._0x90977c74)
        {
            _0x21e570a5 = null;
            return false;
        }

        if (_0x21e570a5 != null)
            if (_0x21e570a5.Value.phase == _0x1c1f6100)
            {
                Vector3 _0xf77c2527 = Camera.main.ScreenToWorldPoint(_0x21e570a5.Value.screenPosition);
                Vector3 _0x7cfc7f99 = new(_0xf77c2527.x, _0xf77c2527.y, _0x023ba2c3.center.z);
                if (_0x023ba2c3.Contains(_0x7cfc7f99) && this._0xc1ea611c(_0x21e570a5.Value))
                    return true;
            }

        return false;
    }

    private static _0xc816f9b8 _0xb5d5c8de;
    private Touch? _0x943b758a(Bounds _0xb92397d0)
    {
        if (!_0xc21423fc.Instance._0x90977c74)
            return null;
        foreach (Touch _0x595c4e48 in Touch.activeTouches)
            if (_0x595c4e48.ended)
            {
                Vector3 _0x95c9862b = Camera.main.ScreenToWorldPoint(_0x595c4e48.screenPosition);
                Vector3 _0x7bee0833 = new(_0x95c9862b.x, _0x95c9862b.y, _0xb92397d0.center.z);
                if (_0xb92397d0.Contains(_0x7bee0833) && this._0xc1ea611c(_0x595c4e48))
                    return _0x595c4e48;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private void _0xb6589ee6(Touch? _0xe694cd6a)
    {
        if (!_0xc21423fc.Instance._0x90977c74)
        {
            _0xe694cd6a = null;
            return;
        }

        int _0xb6fa37e4 = _0xe694cd6a.Value.touchId;
        _0xe694cd6a = Touch.activeTouches.FirstOrDefault(_0x95d8ea6c => _0x95d8ea6c.touchId == _0xb6fa37e4);
        if (!this._0xc1ea611c(_0xe694cd6a.Value))
            _0xe694cd6a = null;
    }

    private Touch? _0x4305dd3f()
    {
        if (!_0xc21423fc.Instance._0x90977c74)
            return null;
        foreach (Touch _0x06df008c in Touch.activeTouches)
            if (!_0x06df008c.ended)
                if (this._0xc1ea611c(_0x06df008c))
                    return _0x06df008c;
        return null;
    }
}