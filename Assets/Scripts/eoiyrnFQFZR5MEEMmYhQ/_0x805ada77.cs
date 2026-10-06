using UnityEngine;

/// Shows and hides one piece of generated UI through a serialized reference.
/// Codegen only ever switches things it created itself; template objects are left
/// to the pipeline stage that owns them.
public sealed class _0x805ada77 : MonoBehaviour
{
    public void _0x1fd8e5c9(bool _0x27d548d8)
    {
        if (this._content == null)
            return;
        this._content.SetActive(_0x27d548d8);
    }

    [SerializeField]
    private GameObject _content;
    public bool _0xd47460e3
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }
}