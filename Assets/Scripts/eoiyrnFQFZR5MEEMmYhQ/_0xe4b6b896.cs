using TMPro;
using UnityEngine;

/// Fills the three result pops with this game's own wording and colours.
///
/// The pops are reached by INDEX through the template's controller, never by name,
/// and the three text slots come from the Pop component's own serialized fields, so
/// nothing here depends on an object name surviving obfuscation. The static chrome
/// around them (button captions, the close cross, the dead "Score:" / "Reward:"
/// labels) is set on the scene's own prefab modifications.
public sealed class _0xe4b6b896 : MonoBehaviour
{
    /// Raise the win or the lose pop with the numbers of the run just finished.
    public void _0x4b6908d6(bool _0x6976bf4a, string _0x03719d05, int _0xb8f45c6b, int _0xe078f1d5, string _0xbfbfe0b8, int _0x9af1a270)
    {
        _0xaa808aec _0x5b8223a4 = _0xaa808aec.Instance;
        if (_0x5b8223a4 == null)
            return;
        string _0xe5341559 = _0xb8f45c6b + _0xd422243d._0x5e5d5020(new byte[3] { 224, 239, 224 }, 192) + _0xe078f1d5 + _0xd422243d._0x5e5d5020(new byte[14] { 172, 203, 205, 216, 201, 223, 172, 207, 192, 201, 205, 222, 201, 200 }, 140);
        string _0xfcf3ea25 = _0xd422243d._0x5e5d5020(new byte[9] { 173, 175, 175, 185, 190, 173, 175, 181, 204 }, 236) + _0xbfbfe0b8 + _0xd422243d._0x5e5d5020(new byte[13] { 104, 104, 52, 104, 104, 27, 28, 9, 5, 24, 27, 104, 99 }, 72) + _0x9af1a270;
        if (_0x6976bf4a)
        {
            _0x9421d7b0 _0x60546fa4 = _0x5b8223a4._0xd1903ab5(_0x0c2ee824._0x90e98ada.WIN);
            this._0xd250aa48(_0x60546fa4, _0x03719d05, _0xe5341559, _0xfcf3ea25);
            _0x5b8223a4._0xad4e48ee(_0x0c2ee824._0x90e98ada.WIN);
            return;
        }

        _0x9421d7b0 _0x31ed36c2 = _0x5b8223a4._0xd1903ab5(_0x0c2ee824._0x90e98ada.LOSE);
        this._0xd250aa48(_0x31ed36c2, _0x03719d05, _0xe5341559, _0xfcf3ea25);
        _0x5b8223a4._0xad4e48ee(_0x0c2ee824._0x90e98ada.LOSE);
    }

    private void _0xd250aa48(_0x9421d7b0 _0x2e68f068, string _0xa3809f72, string _0xdfb1a152, string _0x16594829)
    {
        if (_0x2e68f068 == null)
            return;
        this._0xc0d3d9a3(_0x2e68f068.ContentHeaderText, _0xa3809f72, _0x4f5b9c84._0xe1ed2d6d, 48f, 72f);
        this._0xc0d3d9a3(_0x2e68f068.ContentMainText, _0xdfb1a152, _0x4f5b9c84._0x53c78623, 40f, 56f);
        if (_0x16594829.Length > 0)
        {
            this._0xc0d3d9a3(_0x2e68f068.ContentAdditionalText, _0x16594829, _0x4f5b9c84._0x53c78623, 36f, 48f);
        }
        else
        {
            _0x0988f69c.Clear(_0x2e68f068.ContentAdditionalText);
        }
    }

    private void _0xc0d3d9a3(TMP_Text _0x40f3daf9, string _0x4ec48c8a, Color _0x2e1246db, float _0xa8e3beef, float _0xf264bcd0)
    {
        if (_0x40f3daf9 == null)
            return;
        _0x0988f69c.Apply(_0x40f3daf9, _0x2e1246db, _0xa8e3beef, _0xf264bcd0);
        _0x0988f69c.SetText(_0x40f3daf9, _0x4ec48c8a);
    }

    /// The pause pop is opened by the template's own button driver, so all this has
    /// to do is dress it — which matters, because it is the pop players see most.
    public void _0xd0c1700d(int _0xf0c8edc5, int _0x3c5c8078, int _0x58ba20f3)
    {
        _0xaa808aec _0x96d77a8f = _0xaa808aec.Instance;
        if (_0x96d77a8f == null)
            return;
        _0x9421d7b0 _0xa1f0cc1f = _0x96d77a8f._0xd1903ab5(_0x0c2ee824._0x90e98ada.PAUSE);
        this._0xd250aa48(_0xa1f0cc1f, _0xd422243d._0x5e5d5020(new byte[19] { 86, 65, 87, 80, 77, 74, 67, 36, 75, 74, 36, 80, 76, 65, 36, 83, 77, 86, 65 }, 4), _0xd422243d._0x5e5d5020(new byte[38] { 89, 94, 93, 85, 49, 69, 94, 49, 66, 70, 88, 95, 86, 49, 60, 49, 67, 84, 93, 84, 80, 66, 84, 49, 69, 94, 49, 85, 80, 66, 89, 27, 86, 80, 69, 84, 66, 49 }, 17) + _0xf0c8edc5 + _0xd422243d._0x5e5d5020(new byte[3] { 143, 128, 143 }, 175) + _0x3c5c8078 + _0xd422243d._0x5e5d5020(new byte[12] { 18, 18, 78, 18, 18, 119, 124, 119, 96, 117, 107, 18 }, 50) + _0x58ba20f3 + _0xd422243d._0x5e5d5020(new byte[1] { 78 }, 107), string.Empty);
    }
}

internal static class _0xd422243d
{
    internal static string _0x5e5d5020(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}