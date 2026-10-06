using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x316d6555 : MonoBehaviour
{
    public void _0x7a413ede()
    {
        this._0x32b313da?.Kill();
        this.AnimationSlider.value = _0x0fc45125 ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0x361cbff0()
    {
        this._0x32b313da?.Pause();
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x0c2ee824._0xa3bf5155.SCENE_0 && !_0x0fc45125)
        {
            this._0x4e601446();
        }
        else
        {
            this._0x4da60873();
        }
    }

    public Slider AnimationSlider;
    public GameObject Content;
    private void _0x4e601446()
    {
        this.AnimationSlider.value = 0.05f;
        _0x0fc45125 = !_0x0fc45125;
        this._0x32b313da = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xb0811e1b => this.AnimationSlider.value = _0xb0811e1b, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x4c524e80._0x35714317?._0x7940be07();
        });
    }

    public void _0x4da60873()
    {
        this._0x7a413ede();
        bool _0x20eaab39 = _0x0fc45125;
        this._0x32b313da = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xb0811e1b => this.AnimationSlider.value = _0xb0811e1b, _0x20eaab39 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x0fc45125 = !_0x0fc45125;
    }

    public void _0xd9392bea()
    {
        this._0x32b313da?.Play();
    }

    public GameObject Error;
    public float SecondPassSliderValue = 0.5f;
    public GameObject Background;
    public float FirstAnimationTime = 10.0f;
    public void _0x24b8ce55()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x32b313da?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x0fc45125 = false;
    }

    private Sequence _0x32b313da;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x316d6555>();
    }

    public float DefaultAnimationTime = 0.4f;
    public static _0x316d6555 Instance;
    private static bool _0x0fc45125 = false;
}