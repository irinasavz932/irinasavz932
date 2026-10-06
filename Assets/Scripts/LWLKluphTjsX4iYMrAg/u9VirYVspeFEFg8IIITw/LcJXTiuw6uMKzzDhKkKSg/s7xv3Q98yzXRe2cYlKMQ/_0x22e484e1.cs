using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x22e484e1 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xc21423fc.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xc21423fc.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
    public int LoadSceneId;
}