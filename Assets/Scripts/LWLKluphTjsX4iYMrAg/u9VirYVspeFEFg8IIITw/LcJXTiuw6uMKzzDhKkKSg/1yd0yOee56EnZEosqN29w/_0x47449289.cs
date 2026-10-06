using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x47449289 : MonoBehaviour
{
    public void _0xf20d9a19()
    {
        this._0xbd0c6cf7();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0xcf3fe6a3()
    {
        if (this.OuterBackground != null)
        {
            Image _0x0159a3f6 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x0159a3f6, true);
            _0x0159a3f6.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public bool IsScaledDownOnAwake = true;
    public TMP_Text MainText;
    private void _0xd8f3fae3()
    {
        if (this.OuterBackground != null)
        {
            Image _0x4667a3e8 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x4667a3e8, true);
            _0x4667a3e8.DOFade(1f, 0f);
        }
    }

    private void _0xc951ae27()
    {
        if (this.OuterBackground != null)
        {
            Image _0xe686ccac = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xe686ccac, true);
            _0xe686ccac.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public GameObject Content;
    public GameObject OuterBackground;
    public Ease Ease = Ease.OutSine;
    public void Show()
    {
        this._0xcf3fe6a3();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x9614a5e3.Instance._0x57771d46(_0x9614a5e3.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xbd0c6cf7()
    {
        if (this.OuterBackground != null)
        {
            Image _0x6be17885 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x6be17885, true);
            _0x6be17885.DOFade(0f, this.ScaleDuration);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc951ae27();
    }

    public float ScaleDuration = 0.4f;
    private bool _0x4e0f354a => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text HeaderText;
    public void _0xc39a473c()
    {
        this._0xd8f3fae3();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x9614a5e3.Instance._0x57771d46(_0x9614a5e3.Instance.CurrentPanelIndex);
    }
}