using UnityEngine;
using UnityEngine.UI;

public class _0x15776bcf : MonoBehaviour
{
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public bool IsTutorialEndPanel;
    public Button NextTutorialButton;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x9614a5e3.Instance._0x9b9c483a(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xc21423fc.Instance._0x4ae75259());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x9614a5e3.Instance._0x9b9c483a(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x9614a5e3.Instance._0x9b9c483a(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xc21423fc.Instance._0x4ae75259());
        }
    }
}