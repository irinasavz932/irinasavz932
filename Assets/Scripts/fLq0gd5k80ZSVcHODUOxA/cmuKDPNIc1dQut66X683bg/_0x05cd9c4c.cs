using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x05cd9c4c : MonoBehaviour
{
    private AspectRatioFitter _0x13a6a8a3;
    private float _0xd40be597 = 4;
    private float _0xd1c284a7 = 0.6f;
    private float _0xea144a10;
    private void Update()
    {
        int _0x0dea94ba = 1;
        if (this._0x76919a6c.Count > 0)
        {
            string _0xda3646b2 = this._0xb5a13073.text;
            foreach (string _0xea082536 in this._0x76919a6c)
                while (_0xda3646b2.Contains(_0xea082536))
                    _0xda3646b2 = _0xda3646b2.Replace(_0xea082536, "");
            _0x0dea94ba = _0xda3646b2.Length;
        }
        else
        {
            _0x0dea94ba = this._0xb5a13073.text.Length;
        }

        float _0x82bebbb4 = Mathf.Clamp(this._0xea144a10 + this._0xd1c284a7 * _0x0dea94ba, this._0x6089c4ba, this._0xd40be597);
        if (!Mathf.Approximately(this._0x13a6a8a3.aspectRatio, _0x82bebbb4))
            this._0x13a6a8a3.aspectRatio = _0x82bebbb4;
    }

    private float _0x6089c4ba = 1.5f;
    private List<string> _0x76919a6c = new();
    private TMP_Text _0xb5a13073;
}