using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x6321601e : MonoBehaviour
{
    private void Update()
    {
        this._0x7aeb6d74();
    }

    private void _0x7aeb6d74()
    {
        if (this._0xa367ba06.canvasRenderer.GetColor() != this._0xfcdee931.canvasRenderer.GetColor())
            this._0xfcdee931.canvasRenderer.SetColor(this._0xa367ba06.canvasRenderer.GetColor());
    }

    private TMP_Text _0xfcdee931;
    private Image _0xa367ba06;
}