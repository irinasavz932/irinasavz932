using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x0c2ee824
{
    public class _0x647336da
    {
        private static readonly _0x647336da _0x476cd6ae = new();
        public static readonly _0x647336da[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x476cd6ae,
            _0x476cd6ae,
            _0x476cd6ae,
        };
        private int _0xdee27614 => 0;
        private int _0xbf648cf1 => 10;
        private string _0x238c9142 => _0xf45c0a96._0xa5092467(new byte[4] { 200, 224, 235, 240 }, 133);
        private string _0xee339bbc => _0xf45c0a96._0xa5092467(new byte[8] { 66, 75, 88, 75, 66, 117, 62, 115 }, 14);

        private int _0xa3d45331
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xf45c0a96._0xa5092467(new byte[25] { 32, 22, 17, 17, 6, 13, 23, 36, 15, 12, 1, 2, 15, 32, 11, 2, 19, 23, 6, 17, 42, 13, 7, 6, 27 }, 99)))
                    PlayerPrefs.SetInt(_0xf45c0a96._0xa5092467(new byte[25] { 51, 5, 2, 2, 21, 30, 4, 55, 28, 31, 18, 17, 28, 51, 24, 17, 0, 4, 21, 2, 57, 30, 20, 21, 8 }, 112), 0);
                return PlayerPrefs.GetInt(_0xf45c0a96._0xa5092467(new byte[25] { 14, 56, 63, 63, 40, 35, 57, 10, 33, 34, 47, 44, 33, 14, 37, 44, 61, 57, 40, 63, 4, 35, 41, 40, 53 }, 77));
            }

            set => PlayerPrefs.SetInt(_0xf45c0a96._0xa5092467(new byte[25] { 175, 153, 158, 158, 137, 130, 152, 171, 128, 131, 142, 141, 128, 175, 132, 141, 156, 152, 137, 158, 165, 130, 136, 137, 148 }, 236), value);
        }

        public int _0xcc31434b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x238c9142}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x238c9142}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x238c9142}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x238c9142}CurrentLevelIndex", value);
        }

        public int _0xe1b5c356
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x238c9142}BestScore"))
                    this._0xe1b5c356 = 0;
                return PlayerPrefs.GetInt($"{this._0x238c9142}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x238c9142}BestScore", value);
        }

        public bool _0x35d3e859
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x238c9142}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x238c9142}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x238c9142}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x238c9142}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x90e98ada
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0xc63c2332
    {
        public static int _0xe393db65
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xf45c0a96._0xa5092467(new byte[5] { 151, 187, 189, 186, 167 }, 212)))
                    PlayerPrefs.SetInt(_0xf45c0a96._0xa5092467(new byte[5] { 35, 15, 9, 14, 19 }, 96), 0);
                return PlayerPrefs.GetInt(_0xf45c0a96._0xa5092467(new byte[5] { 65, 109, 107, 108, 113 }, 2));
            }

            set
            {
                PlayerPrefs.SetInt(_0xf45c0a96._0xa5092467(new byte[5] { 229, 201, 207, 200, 213 }, 166), value);
                _0xc21423fc.Instance._0x80792e3c();
            }
        }
    }

    public static class _0xa3bf5155
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xeaf43e11
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0xf45c0a96
{
    internal static string _0xa5092467(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}