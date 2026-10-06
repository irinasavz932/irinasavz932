using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x0c2ee824;

public class _0x9614a5e3 : MonoBehaviour
{
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private _0x47449289 _0x4b5b3233(int _0x0d9f2bf0)
    {
        return this.Panels[_0x0d9f2bf0];
    }

    public static _0x9614a5e3 Instance;
    public int CurrentPanelIndex;
    private void _0xdc02818a()
    {
        this._0x3045b918(_0xeaf43e11.SPLASH);
        if (_0xc21423fc.Instance._0xe44d7569 == _0xa3bf5155.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x316d6555.Instance.DefaultAnimationTime);
        }
    }

    public List<_0x47449289> Panels;
    private void _0xa52896cc(int _0xb9163ded)
    {
        this.LastPanelIndexes.Add(_0xb9163ded);
        this.CurrentPanelIndex = _0xb9163ded;
        for (int _0x25690a24 = 0; _0x25690a24 < this.Panels.Count; _0x25690a24++)
            if (_0x25690a24 != _0xb9163ded && this.Panels[_0x25690a24] != null)
                this.Panels[_0x25690a24]._0xf20d9a19();
    }

    public float StaticBlurMaterialInitialValue;
    public float ScaleDuration = 0.4f;
    public void _0x9b9c483a(int _0xc771af3e)
    {
        this._0xa15637fb(_0xc771af3e);
        this._0x900871c3(_0xc771af3e);
        this.CurrentPanelIndex = _0xc771af3e;
        this.Panels[_0xc771af3e].Show();
    }

    private void Start()
    {
        this._0xdc02818a();
    }

    public bool IsShowSplashOnStart = true;
    public void _0x14718e0e()
    {
        this.LastPanelIndexes.RemoveAll(_0xdcc967ed => _0xdcc967ed == this.CurrentPanelIndex);
        int _0x50077f8a = this.LastPanelIndexes.Last();
        this._0x900871c3(_0x50077f8a);
        this._0xa52896cc(_0x50077f8a);
        this.CurrentPanelIndex = _0x50077f8a;
        this.Panels[_0x50077f8a].Show();
    }

    private void SwitchSplash()
    {
        if (_0x8eca1543.Instance.IsTutorialEnabled && !_0xc21423fc._0x82bad9dd._0x35d3e859)
            this._0x9b9c483a(_0xeaf43e11.TUTORIAL0);
        else
            this._0x9b9c483a(_0xeaf43e11.DEFAULT);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x9614a5e3>();
    }

    public void _0x57771d46(int _0x32317764)
    {
        if (_0x32317764 == _0xeaf43e11.SPLASH && _0xc21423fc.Instance._0xe44d7569 != _0xa3bf5155.SCENE_0)
            _0x316d6555.Instance._0x4da60873();
        if (_0xc21423fc.Instance._0xe44d7569 != _0xa3bf5155.SCENE_0)
        {
            if (_0x32317764 == _0xeaf43e11.SPLASH || _0x32317764 == _0xeaf43e11.TUTORIAL0)
                _0xc21423fc.Instance._0xdae972e4(false);
            else if (_0x32317764 == _0xeaf43e11.DEFAULT)
                _0xc21423fc.Instance._0xdae972e4(true);
        }
    }

    private void _0xa15637fb(int _0xc7cd73de)
    {
        this.LastPanelIndexes.Add(_0xc7cd73de);
        this.CurrentPanelIndex = _0xc7cd73de;
        for (int _0x4f3ae1aa = 0; _0x4f3ae1aa < this.Panels.Count; _0x4f3ae1aa++)
            if (_0x4f3ae1aa != _0xc7cd73de && this.Panels[_0x4f3ae1aa] != null)
                this.Panels[_0x4f3ae1aa]._0xf20d9a19();
    }

    private void _0x900871c3(int _0xfafab35c)
    {
        if (_0xfafab35c == _0xeaf43e11.SPLASH)
            _0x316d6555.Instance._0x7a413ede();
        if (_0xc21423fc.Instance._0xe44d7569 == _0xa3bf5155.SCENE_0)
        {
        }
    }

    private void _0x3045b918(int _0x12fb0213)
    {
        this._0xa15637fb(_0x12fb0213);
        this._0x900871c3(_0x12fb0213);
        this.CurrentPanelIndex = _0x12fb0213;
        this.Panels[_0x12fb0213]._0xc39a473c();
    }
}