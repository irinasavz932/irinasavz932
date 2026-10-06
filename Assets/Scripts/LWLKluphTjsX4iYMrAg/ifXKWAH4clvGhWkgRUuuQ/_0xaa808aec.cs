using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x0c2ee824;

public class _0xaa808aec : MonoBehaviour
{
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x9421d7b0 _0x8b62c226 in this.Pops)
            if (_0x8b62c226 != null)
                _0x8b62c226.gameObject.SetActive(true);
    }

    public List<_0x9421d7b0> Pops;
    private void _0x430fa881()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public int CurrentPopIndex;
    public static _0xaa808aec Instance;
    public void _0xad4e48ee(int _0xfef021bd)
    {
        this.CurrentPopIndex = _0xfef021bd;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xe59a4de5(true);
        this._0x430fa881();
        this.Pops[_0xfef021bd].Show();
        foreach (GameObject _0x38b233b5 in this.GameObjectsToHide)
            _0x38b233b5.SetActive(false);
    }

    public float ScaleDuration = 0.4f;
    private void _0xc9c02a12()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public _0x9421d7b0 _0xd1903ab5(int _0x24af5c21)
    {
        return this.Pops[_0x24af5c21];
    }

    public void _0x3734e294()
    {
        this.LastPopIndexes.Clear();
        this._0xe59a4de5();
        foreach (GameObject _0x64ff8462 in this.GameObjectsToHide)
            if (_0x64ff8462 != null)
                _0x64ff8462.SetActive(true);
        this._0xc9c02a12();
    }

    public List<int> LastPopIndexes = new();
    public GameObject BlurBackground;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xaa808aec>();
    }

    public List<GameObject> GameObjectsToHide;
    private void _0xe59a4de5(bool _0x358f2b3b = false)
    {
        for (int _0x9689eb02 = 0; _0x9689eb02 < this.Pops.Count; ++_0x9689eb02)
            if (this.Pops[_0x9689eb02] != null && !(_0x9689eb02 == this.CurrentPopIndex && _0x358f2b3b))
                this.Pops[_0x9689eb02]._0xce2fa470();
    }

    public void _0xbdfc66fb()
    {
        this.LastPopIndexes.RemoveAll(_0xdcc967ed => _0xdcc967ed == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x3734e294();
        else
            this._0xad4e48ee(this.LastPopIndexes.Last());
    }
}