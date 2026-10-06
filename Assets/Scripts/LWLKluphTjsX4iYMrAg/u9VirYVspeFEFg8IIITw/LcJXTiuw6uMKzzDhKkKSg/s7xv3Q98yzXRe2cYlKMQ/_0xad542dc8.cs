using UnityEngine;
using UnityEngine.UI;

public class _0xad542dc8 : MonoBehaviour
{
    public bool IsShowLastPop;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int PopToShowIndex;
    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xaa808aec.Instance._0xbdfc66fb();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xaa808aec.Instance._0x3734e294());
        else
            this.Button.onClick.AddListener(() => _0xaa808aec.Instance._0xad4e48ee(this.PopToShowIndex));
    }
}