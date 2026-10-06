using UnityEngine;
using UnityEngine.UI;

public class _0x97158980 : MonoBehaviour
{
    private int _0x2ac8b202;
    private bool _0xa9ad44f9;
    private void Awake()
    {
        if (this._0xa5f19f0b == null)
            if (!this.TryGetComponent(out this._0xa5f19f0b))
                this._0xa5f19f0b = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0xa9ad44f9)
            this._0xa5f19f0b.onClick.AddListener(() => _0x9614a5e3.Instance._0x14718e0e());
        else
            this._0xa5f19f0b.onClick.AddListener(() => _0x9614a5e3.Instance._0x9b9c483a(this._0x2ac8b202));
    }

    private Button _0xa5f19f0b;
}