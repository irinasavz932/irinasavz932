using UnityEngine;

public class _0x8eca1543 : MonoBehaviour
{
    public bool IsLevelSelectorEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsBestScoreEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsStoryEnabled;
    private void _0x582c0abf()
    {
    }

    public static _0x8eca1543 Instance;
    public bool IsCheckScoreEnabled;
    public bool IsTutorialEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x8eca1543>();
            DontDestroyOnLoad(this.gameObject);
            this._0x7fa93698();
        }
        else
        {
            this._0x582c0abf();
            Destroy(this.gameObject);
        }
    }

    private void _0x7fa93698()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }
}