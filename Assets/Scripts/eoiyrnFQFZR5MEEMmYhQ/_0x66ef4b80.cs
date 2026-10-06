using UnityEngine;
using UnityEngine.UI;

/// Dresses the loading screen: an abstract mark over a darkened field, and a
/// loading bar that actually reads.
///
/// The bar ships white-on-almost-nothing, so its fill gets the wheat accent and its
/// track gets ink at an alpha you can see. The mark is a feather in a broken ring —
/// a symbol from the game's own world, with no lettering of any kind.
public sealed class _0x66ef4b80 : MonoBehaviour
{
    private void Start()
    {
        _0x9614a5e3 _0x7414574c = _0x9614a5e3.Instance;
        if (_0x7414574c == null || _0x7414574c.Panels == null)
            return;
        int _0x15e536b1 = _0x0c2ee824._0xeaf43e11.SPLASH;
        if (_0x15e536b1 < 0 || _0x15e536b1 >= _0x7414574c.Panels.Count)
            return;
        _0x47449289 _0xa04c972f = _0x7414574c.Panels[_0x15e536b1];
        if (_0xa04c972f == null || _0xa04c972f.Content == null)
            return;
        if (this._splashViewPrefab != null)
        {
            GameObject _0xe64cb6fe = Instantiate(this._splashViewPrefab, _0xa04c972f.Content.transform, false);
            // behind the loading bar, which the template put there first
            _0xe64cb6fe.transform.SetAsFirstSibling();
        }

        Slider _0x741d175a = _0xa04c972f.Content.GetComponentInChildren<Slider>(true);
        if (_0x741d175a == null || _0x741d175a.fillRect == null)
            return;
        Image _0x8ca9d63a = _0x741d175a.fillRect.GetComponent<Image>();
        if (_0x8ca9d63a != null)
        {
            _0x8ca9d63a.color = _0x4f5b9c84._0xe1ed2d6d;
        }

        RectTransform _0x56fe1519 = _0x741d175a.fillRect.parent as RectTransform;
        if (_0x56fe1519 != null)
        {
            Image _0xbc09e1b4 = _0x56fe1519.GetComponent<Image>();
            if (_0xbc09e1b4 != null)
            {
                _0xbc09e1b4.color = _0x4f5b9c84._0xeb080c87;
            }
        }
    }

    [SerializeField]
    private GameObject _splashViewPrefab;
}