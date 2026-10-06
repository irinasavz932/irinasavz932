using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9421d7b0 : MonoBehaviour
{
    public void _0xce2fa470()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public float scaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xa5172883();
    }

    public bool IsScaledDownOnAwake = true;
    public Ease ease = Ease.OutSine;
    public bool IsOnlyYScale;
    public GameObject Content;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentHeaderText;
    public TMP_Text ContentAdditionalText;
    public Image ContentImage;
    public static void HideAllPops()
    {
        _0xaa808aec.Instance._0x3734e294();
    }

    private void Start()
    {
    // Content.SetActive(false);
    }

    private bool _0xb50e975c => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentMainText;
    private void _0xa5172883()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }
}