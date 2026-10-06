using UnityEngine;

/// Puts the flight HUD inside the template's own DefaultPanel and hands it to the
/// director. Done in Start, because the panel pool is only populated once the
/// template's controllers have woken up.
public sealed class _0x8771e313 : MonoBehaviour
{
    private void Start()
    {
        _0x9614a5e3 _0x25769f84 = _0x9614a5e3.Instance;
        if (_0x25769f84 == null || _0x25769f84.Panels == null)
            return;
        int _0xc7f17bc5 = _0x0c2ee824._0xeaf43e11.DEFAULT;
        if (_0xc7f17bc5 < 0 || _0xc7f17bc5 >= _0x25769f84.Panels.Count)
            return;
        _0x47449289 _0x5dc3d687 = _0x25769f84.Panels[_0xc7f17bc5];
        if (_0x5dc3d687 == null || _0x5dc3d687.Content == null || this._flightHudPrefab == null)
            return;
        GameObject _0x9ce2ac15 = Instantiate(this._flightHudPrefab, _0x5dc3d687.Content.transform, false);
        _0xa38770b5 _0x30c7face = _0x9ce2ac15.GetComponent<_0xa38770b5>();
        if (this._director != null)
            this._director._0xcebcceda(_0x30c7face);
    }

    [SerializeField]
    private _0x00d0587d _director;
    [SerializeField]
    private GameObject _flightHudPrefab;
}