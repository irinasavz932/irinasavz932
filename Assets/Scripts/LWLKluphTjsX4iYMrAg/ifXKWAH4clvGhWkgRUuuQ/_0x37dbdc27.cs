using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x37dbdc27 : MonoBehaviour
{
    private void _0xceada1a7()
    {
        if (this.ScoreCurrent > _0xc21423fc._0x82bad9dd._0xe1b5c356)
            _0xc21423fc._0x82bad9dd._0xe1b5c356 = this.ScoreCurrent;
        if (_0x8eca1543.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x5c563790)
                this._0xa9321767();
    }

    private void _0x09b77932()
    {
        if (this.ScoreCurrent >= this._0x5c563790)
            this._0xa9321767();
        else
            this._0xee3ad81f();
    }

    public int CustomTimeInitial = 30;
    public void _0xee3ad81f()
    {
        if (_0x8eca1543.Instance.IsOnlyWinGameEndEnabled)
            this._0xa9321767();
        if (!this.IsGameEnd)
        {
            this._0x1760476a();
            _0xc21423fc.IsAfterLevelComplete = false;
            _0xc21423fc.IsAfterLevelFailed = true;
            _0x9421d7b0 _0x1381d2cc = _0xaa808aec.Instance._0xd1903ab5(_0x0c2ee824._0x90e98ada.LOSE).GetComponent<_0x9421d7b0>();
            if (_0x8eca1543.Instance.IsCheckScoreEnabled)
                _0x1381d2cc.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x5c563790}";
            else
                _0x1381d2cc.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x1381d2cc.ContentAdditionalText.text = $"{0}";
            _0x0c2ee824._0xc63c2332._0xe393db65 += 0;
            _0xaa808aec.Instance._0xad4e48ee(_0x0c2ee824._0x90e98ada.LOSE);
        }
    }

    public List<Button> HomeButtons = new();
    private void _0x3beb4f7e()
    {
        if (_0x8eca1543.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xfd97a2fb => _0xfd97a2fb.text = $"{this.ScoreCurrent}/{this._0x5c563790}");
        else
            this.ScoreText.ForEach(_0xfd97a2fb => _0xfd97a2fb.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> TimerText = new();
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x04ea8fd2;
        this.CurrentGameIndex = _0xc21423fc.Instance._0xe44d7569;
        foreach (Button _0x41e9d84b in this.HomeButtons)
            _0x41e9d84b.onClick.AddListener(() =>
            {
                this._0x04d8fd0f();
            });
        foreach (Button _0xabc6f0ee in this.PauseButtons)
            _0xabc6f0ee.onClick.AddListener(() =>
            {
                _0xc21423fc.Instance._0xdae972e4(false);
                _0xaa808aec.Instance._0xad4e48ee(_0x0c2ee824._0x90e98ada.PAUSE);
            });
        this._0x3beb4f7e();
        this.LevelNumberText.ForEach(_0xfd97a2fb => _0xfd97a2fb.text = $"LVL {_0xc21423fc._0x82bad9dd._0xcc31434b + 1}");
        if (_0x8eca1543.Instance.IsTimerEnabled)
        {
            this._0x6af5e27f();
            this.StartCoroutine(this._0x5fa00189());
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    private int _0x04ea8fd2 => this.CustomTimeInitial + _0xc21423fc._0x82bad9dd._0xcc31434b * 10;

    [HideInInspector]
    public int CurrentGameIndex;
    [HideInInspector]
    public int TimeLeft;
    public List<TMP_Text> ScoreText = new();
    [HideInInspector]
    public bool IsGameEnd;
    public void _0x04d8fd0f()
    {
        _0xc21423fc.Instance._0xdae972e4(true);
        _0xc21423fc.Instance.LoadSceneByIndex(_0x0c2ee824._0xa3bf5155.SCENE_0);
    }

    private int _0x5c563790 => this.CustomTargetScore + _0xc21423fc._0x82bad9dd._0xcc31434b * 10;

    private static _0x37dbdc27 _0x073ebabc;
    private void Awake()
    {
        _0x073ebabc = this.gameObject.GetComponent<_0x37dbdc27>();
    }

    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> SubtitleText = new();
    private void _0x6af5e27f()
    {
        this.TimerText.ForEach(_0xfd97a2fb => _0xfd97a2fb.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x49429ff8._0x1ce106fc(new byte[6] { 172, 172, 157, 251, 178, 178 }, 193)));
    }

    private int _0x73b52e87 => this.ScoreCurrent;

    public List<Button> PauseButtons = new();
    private void _0x1760476a()
    {
        this.IsGameEnd = true;
        _0xc21423fc.IsAfterLevelComplete = true;
    }

    public void _0x4a6ac56c(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x3beb4f7e();
            this._0xceada1a7();
        }
    }

    private IEnumerator _0x5fa00189()
    {
        this._0x6af5e27f();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xc21423fc.Instance._0xe44d7569 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xc21423fc.Instance._0x90977c74)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x6af5e27f();
            }
        }

        if (!this.IsGameEnd)
            this._0xee3ad81f();
    }

    public void _0xa9321767()
    {
        if (!this.IsGameEnd)
        {
            this._0x1760476a();
            _0xc21423fc.IsAfterLevelComplete = true;
            _0xc21423fc.IsAfterLevelFailed = false;
            _0x9421d7b0 _0x681a1d9d = _0xaa808aec.Instance._0xd1903ab5(_0x0c2ee824._0x90e98ada.WIN).GetComponent<_0x9421d7b0>();
            if (_0x8eca1543.Instance.IsCheckScoreEnabled)
                _0x681a1d9d.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x5c563790}";
            else
                _0x681a1d9d.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x8eca1543.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x0c2ee824._0xc63c2332._0xe393db65)
                    _0x0c2ee824._0xc63c2332._0xe393db65 = this.ScoreCurrent;
                _0x681a1d9d.ContentAdditionalText.text = $"{_0x0c2ee824._0xc63c2332._0xe393db65}";
            }
            else
            {
                _0x681a1d9d.ContentAdditionalText.text = $"{this._0x73b52e87}";
                _0x0c2ee824._0xc63c2332._0xe393db65 += this._0x73b52e87;
            }

            if (_0x8eca1543.Instance.IsLevelIncrementOnWin)
                ++_0xc21423fc._0x82bad9dd._0xcc31434b;
            _0xaa808aec.Instance._0xad4e48ee(_0x0c2ee824._0x90e98ada.WIN);
        }
    }

    public int CustomTargetScore = 10;
}

internal static class _0x49429ff8
{
    internal static string _0x1ce106fc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}