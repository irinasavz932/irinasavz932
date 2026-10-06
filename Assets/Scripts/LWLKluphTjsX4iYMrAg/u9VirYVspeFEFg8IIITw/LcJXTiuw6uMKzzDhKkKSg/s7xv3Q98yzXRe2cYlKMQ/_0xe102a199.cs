using UnityEngine;
using UnityEngine.UI;

public class _0xe102a199 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xc21423fc.Instance._0xdae972e4(this.IsPhysicsRunOnClick));
    }

    public Button Button;
}