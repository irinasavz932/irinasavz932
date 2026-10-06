using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x0c2ee824;

public class _0xc21423fc : MonoBehaviour
{
    public void _0x80792e3c()
    {
        foreach (_0xc6291a4c _0x85b970bc in this.MoneyCountContainers)
            _0x85b970bc._0x83e32f13();
    }

    private void _0x99973141()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xa3bf5155.SCENE_0);
    }

    private static _0x647336da GAME_INDEX_SETTINGS(int _0x325b01d8)
    {
        return _0x647336da.ALL_SCENES_SETTING_SINGLETONS[_0x325b01d8];
    }

    [HideInInspector]
    public List<_0xc6291a4c> MoneyCountContainers = new();
    public int _0xe44d7569 => SceneManager.GetActiveScene().buildIndex;

    public Canvas MainCanvas;
    public void _0x34dfbd12()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public Transform Environment;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc21423fc>();
        this.RootGameObject = GameObject.FindWithTag(_0xe588a8fe._0x0528d4f2(new byte[4] { 224, 221, 221, 198 }, 178));
        if (this._0xe44d7569 == _0xa3bf5155.SCENE_0)
            this._0xdae972e4(true);
        else
            this._0xdae972e4(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xc6291a4c>(true).ToList();
    }

    private void _0xea535f03(bool _0x2520b5d4)
    {
        Rigidbody2D[] _0x94a02d56 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x9ea5176a in _0x94a02d56)
            if (_0x2520b5d4)
                _0x9ea5176a.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x9ea5176a.constraints = RigidbodyConstraints2D.None;
    }

    private static _0x647336da _0x21f2a091 => _0x647336da.ALL_SCENES_SETTING_SINGLETONS[0];

    private static void MakeGrid(List<RectTransform> _0xf9e985d3, AspectRatioFitter _0xb19c5628, float _0x63ddbc00, int _0x560cad62, int _0x8613d42e)
    {
        _0xb19c5628.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xb19c5628.aspectRatio = _0x63ddbc00;
        foreach (RectTransform _0xbd7ae11b in _0xf9e985d3)
        {
            int _0xeeeec7bc = _0xbd7ae11b.transform.GetSiblingIndex();
            _0xbd7ae11b.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xeeeec7bc % _0x560cad62) * (1f / _0x560cad62), (_0x8613d42e - (Mathf.FloorToInt((float)_0xeeeec7bc / _0x560cad62) % _0x8613d42e + 1f)) * (1f / _0x8613d42e));
            _0xbd7ae11b.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xeeeec7bc % _0x560cad62 + 1f) * (1f / _0x560cad62), (_0x8613d42e - Mathf.FloorToInt((float)_0xeeeec7bc / _0x560cad62) % _0x8613d42e) * (1f / _0x8613d42e));
            _0xbd7ae11b.offsetMin = Vector2.zero;
            _0xbd7ae11b.offsetMax = Vector2.zero;
        }
    }

    private IEnumerator _0x4fc9b53b(int _0xf0ac49c8)
    {
        _0x9614a5e3.Instance._0x9b9c483a(_0xeaf43e11.SPLASH);
        AsyncOperation _0x3d9d8bd4 = SceneManager.LoadSceneAsync(_0xf0ac49c8);
        while (!_0x3d9d8bd4.isDone)
            yield return null;
    }

    public static _0x647336da _0x82bad9dd => _0x647336da.ALL_SCENES_SETTING_SINGLETONS[Instance._0xe44d7569];

    public static _0xc21423fc Instance;
    public void LoadSceneByIndex(int _0x25a76624)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x4fc9b53b(_0x25a76624));
    }

    public Button DeleteProgressDataButton;
    private IEnumerator _0xd832f4c5(string _0x82700835)
    {
        _0x9614a5e3.Instance._0x9b9c483a(_0xeaf43e11.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xc276d79e = SceneManager.LoadSceneAsync(_0x82700835);
        while (!_0xc276d79e.isDone)
            yield return null;
    }

    private void Start()
    {
        if (this._0xe44d7569 != _0xa3bf5155.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xa3bf5155.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x82bad9dd._0x35d3e859 = false;
            _0xaa808aec.Instance._0x3734e294();
            _0x9614a5e3.Instance._0x9b9c483a(_0xeaf43e11.TUTORIAL0);
        });
    }

    public bool _0x90977c74 { get; private set; }

    public void _0xdae972e4(bool _0x1779f77e)
    {
        this._0x90977c74 = _0x1779f77e;
        this._0xea535f03(!this._0x90977c74);
        Physics2D.simulationMode = this._0x90977c74 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xcc7f3422(this.EnvironmentWithTweensToToggle);
    }

    public void _0x4ae75259()
    {
        _0x82bad9dd._0x35d3e859 = true;
    }

    public Transform EnvironmentWithTweensToToggle;
    public Button ShowResetTutorialButton;
    private void _0xcc7f3422(Transform _0x0012f67e)
    {
        Transform[] _0x88f22fc3 = _0x0012f67e.GetComponentsInChildren<Transform>();
        foreach (Transform _0xf7e55077 in _0x88f22fc3)
            if (_0xf7e55077 != null && DOTween.IsTweening(_0xf7e55077))
            {
                if (this._0x90977c74)
                    DOTween.Play(_0xf7e55077);
                else
                    DOTween.Pause(_0xf7e55077);
            }
    }

    public static bool IsAfterLevelFailed = false;
    private static void ExitGame()
    {
        Application.Quit();
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static bool IsAfterLevelComplete;
}

internal static class _0xe588a8fe
{
    internal static string _0x0528d4f2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}