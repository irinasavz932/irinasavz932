using TMPro;
using UnityEngine;

/// Puts this game's menu inside the template's own DefaultPanel and clears the
/// placeholder copy out of the tutorial panels this game does not dress.
///
/// Both halves go through SETTINGS indices rather than object names, which is the
/// only addressing that survives obfuscation.
public sealed class _0xbc45d8aa : MonoBehaviour
{
    private void _0xc809bdf9(_0x9614a5e3 _0x61b2df69, int _0xac6ee86d)
    {
        _0x47449289 _0xec88ff23 = this._0x4634e819(_0x61b2df69, _0xac6ee86d);
        if (_0xec88ff23 == null)
            return;
        TMP_Text[] _0x052f2278 = _0xec88ff23.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xf9b23b28 = 0; _0xf9b23b28 < _0x052f2278.Length; _0xf9b23b28++)
        {
            _0x0988f69c.Clear(_0x052f2278[_0xf9b23b28]);
        }
    }

    private _0x47449289 _0x4634e819(_0x9614a5e3 _0xc5879446, int _0xd7794b08)
    {
        if (_0xc5879446.Panels == null)
            return null;
        if (_0xd7794b08 < 0 || _0xd7794b08 >= _0xc5879446.Panels.Count)
            return null;
        return _0xc5879446.Panels[_0xd7794b08];
    }

    private void Start()
    {
        _0x9614a5e3 _0x72c88b66 = _0x9614a5e3.Instance;
        if (_0x72c88b66 == null)
            return;
        _0x47449289 _0x878c5cfe = this._0x4634e819(_0x72c88b66, _0x0c2ee824._0xeaf43e11.DEFAULT);
        if (_0x878c5cfe != null && _0x878c5cfe.Content != null && this._menuViewsPrefab != null)
        {
            Instantiate(this._menuViewsPrefab, _0x878c5cfe.Content.transform, false);
        }

        // Panels the template ships but this game never dresses still carry its
        // "Lorem Ipsum" copy. Blank them; never switch them off, because the
        // controller addresses the pool by index (rule C.15).
        this._0xc809bdf9(_0x72c88b66, _0x0c2ee824._0xeaf43e11.TUTORIAL0);
        this._0xc809bdf9(_0x72c88b66, _0x0c2ee824._0xeaf43e11.TUTORIAL1);
        this._0xc809bdf9(_0x72c88b66, _0x0c2ee824._0xeaf43e11.TUTORIAL2);
        this._0xc809bdf9(_0x72c88b66, _0x0c2ee824._0xeaf43e11.TUTORIAL3);
        this._0xc809bdf9(_0x72c88b66, _0x0c2ee824._0xeaf43e11.TUTORIAL4);
        this._0xc809bdf9(_0x72c88b66, _0x0c2ee824._0xeaf43e11.TUTORIAL5);
        this._0xc809bdf9(_0x72c88b66, _0x0c2ee824._0xeaf43e11.TUTORIAL6);
    }

    [SerializeField]
    private GameObject _menuViewsPrefab;
}