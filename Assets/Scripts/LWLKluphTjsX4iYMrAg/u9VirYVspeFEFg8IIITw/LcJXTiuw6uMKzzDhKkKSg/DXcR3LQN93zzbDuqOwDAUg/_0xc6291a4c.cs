using TMPro;
using UnityEngine;
using static _0x0c2ee824;

public class _0xc6291a4c : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0x83e32f13()
    {
        this.MoneyCountText.text = _0xc63c2332._0xe393db65.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xc25bf07e;
            if (this.gameObject.TryGetComponent(out _0xc25bf07e))
                this.MoneyCountText = _0xc25bf07e;
        }

        this._0x83e32f13();
    }
}