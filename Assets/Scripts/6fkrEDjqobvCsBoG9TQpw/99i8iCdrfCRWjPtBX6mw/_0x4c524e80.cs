using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x4c524e80 : MonoBehaviour
{
    private bool _0x2a28fa6e(string _0xb555efd9)
    {
        if (string.IsNullOrEmpty(_0xb555efd9))
            return false;
        try
        {
            using (var _0x24f84dc7 = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[30] { 52, 56, 58, 121, 34, 57, 62, 35, 46, 100, 51, 121, 39, 59, 54, 46, 50, 37, 121, 2, 57, 62, 35, 46, 7, 59, 54, 46, 50, 37 }, 87)))
            using (var _0x433fba80 = _0x24f84dc7.GetStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[15] { 66, 84, 83, 83, 68, 79, 85, 96, 66, 85, 72, 87, 72, 85, 88 }, 33)))
            using (var _0x09957051 = _0x433fba80.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[17] { 80, 82, 67, 103, 86, 84, 92, 86, 80, 82, 122, 86, 89, 86, 80, 82, 69 }, 55)))
            using (var _0x25a9b7b2 = _0x09957051.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[25] { 185, 187, 170, 146, 191, 171, 176, 189, 182, 151, 176, 170, 187, 176, 170, 152, 177, 172, 142, 191, 189, 181, 191, 185, 187 }, 222), _0xb555efd9))
            {
                if (_0x25a9b7b2 == null)
                    return false;
                WLog(_0x08c919e9._0x91bf5dc8(new byte[37] { 62, 21, 15, 18, 16, 24, 49, 20, 22, 24, 93, 17, 28, 8, 19, 30, 21, 93, 20, 19, 14, 9, 28, 17, 17, 24, 25, 93, 13, 28, 30, 22, 28, 26, 24, 71, 93 }, 125) + _0xb555efd9);
                _0x25a9b7b2.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[8] { 232, 237, 237, 207, 229, 232, 238, 250 }, 137), 0x10000000);
                _0x433fba80.Call(_0x08c919e9._0x91bf5dc8(new byte[13] { 176, 183, 162, 177, 183, 130, 160, 183, 170, 181, 170, 183, 186 }, 195), _0x25a9b7b2);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0xa1f115dc()
    {
        return _0x08c919e9._0x91bf5dc8(new byte[12] { 190, 240, 227, 248, 245, 226, 255, 249, 248, 190, 191, 237 }, 150) + _0x08c919e9._0x91bf5dc8(new byte[8] { 36, 51, 32, 114, 39, 51, 111, 117 }, 82) + WindowsDesktopUserAgent + _0x08c919e9._0x91bf5dc8(new byte[2] { 33, 61 }, 6) + _0x08c919e9._0x91bf5dc8(new byte[30] { 227, 244, 231, 181, 229, 231, 250, 225, 250, 168, 219, 244, 227, 252, 242, 244, 225, 250, 231, 187, 229, 231, 250, 225, 250, 225, 236, 229, 240, 174 }, 149) + _0x08c919e9._0x91bf5dc8(new byte[121] { 163, 176, 171, 166, 177, 172, 170, 171, 229, 161, 160, 163, 237, 170, 167, 175, 233, 174, 160, 188, 233, 179, 164, 169, 236, 190, 177, 183, 188, 190, 138, 167, 175, 160, 166, 177, 235, 161, 160, 163, 172, 171, 160, 149, 183, 170, 181, 160, 183, 177, 188, 237, 170, 167, 175, 233, 174, 160, 188, 233, 190, 162, 160, 177, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 179, 164, 169, 254, 184, 233, 166, 170, 171, 163, 172, 162, 176, 183, 164, 167, 169, 160, 255, 177, 183, 176, 160, 184, 236, 254, 184, 166, 164, 177, 166, 173, 237, 160, 236, 190, 184, 184 }, 197) + _0x08c919e9._0x91bf5dc8(new byte[26] { 222, 223, 220, 146, 202, 200, 213, 206, 213, 150, 157, 207, 201, 223, 200, 251, 221, 223, 212, 206, 157, 150, 207, 219, 147, 129 }, 186) + _0x08c919e9._0x91bf5dc8(new byte[130] { 129, 128, 131, 205, 149, 151, 138, 145, 138, 201, 194, 132, 149, 149, 179, 128, 151, 150, 140, 138, 139, 194, 201, 194, 208, 203, 213, 197, 205, 178, 140, 139, 129, 138, 146, 150, 197, 171, 177, 197, 212, 213, 203, 213, 222, 197, 178, 140, 139, 211, 209, 222, 197, 157, 211, 209, 204, 197, 164, 149, 149, 137, 128, 178, 128, 135, 174, 140, 145, 202, 208, 214, 210, 203, 214, 211, 197, 205, 174, 173, 177, 168, 169, 201, 197, 137, 140, 142, 128, 197, 162, 128, 134, 142, 138, 204, 197, 166, 141, 151, 138, 136, 128, 202, 212, 215, 213, 203, 213, 203, 213, 203, 213, 197, 182, 132, 131, 132, 151, 140, 202, 208, 214, 210, 203, 214, 211, 194, 204, 222 }, 229) + _0x08c919e9._0x91bf5dc8(new byte[30] { 46, 47, 44, 98, 58, 56, 37, 62, 37, 102, 109, 58, 38, 43, 62, 44, 37, 56, 39, 109, 102, 109, 29, 35, 36, 121, 120, 109, 99, 113 }, 74) + _0x08c919e9._0x91bf5dc8(new byte[34] { 17, 16, 19, 93, 5, 7, 26, 1, 26, 89, 82, 3, 16, 27, 17, 26, 7, 82, 89, 82, 50, 26, 26, 18, 25, 16, 85, 60, 27, 22, 91, 82, 92, 78 }, 117) + _0x08c919e9._0x91bf5dc8(new byte[30] { 233, 232, 235, 165, 253, 255, 226, 249, 226, 161, 170, 224, 236, 245, 217, 226, 248, 238, 229, 221, 226, 228, 227, 249, 254, 170, 161, 189, 164, 182 }, 141) + _0x08c919e9._0x91bf5dc8(new byte[449] { 61, 59, 48, 50, 63, 40, 59, 105, 60, 40, 45, 116, 50, 43, 59, 40, 39, 45, 58, 115, 18, 50, 43, 59, 40, 39, 45, 115, 110, 10, 33, 59, 38, 36, 32, 60, 36, 110, 101, 63, 44, 59, 58, 32, 38, 39, 115, 110, 120, 123, 121, 110, 52, 101, 50, 43, 59, 40, 39, 45, 115, 110, 14, 38, 38, 46, 37, 44, 105, 10, 33, 59, 38, 36, 44, 110, 101, 63, 44, 59, 58, 32, 38, 39, 115, 110, 120, 123, 121, 110, 52, 101, 50, 43, 59, 40, 39, 45, 115, 110, 7, 38, 61, 116, 8, 118, 11, 59, 40, 39, 45, 110, 101, 63, 44, 59, 58, 32, 38, 39, 115, 110, 123, 125, 110, 52, 20, 101, 36, 38, 43, 32, 37, 44, 115, 47, 40, 37, 58, 44, 101, 57, 37, 40, 61, 47, 38, 59, 36, 115, 110, 30, 32, 39, 45, 38, 62, 58, 110, 101, 46, 44, 61, 1, 32, 46, 33, 12, 39, 61, 59, 38, 57, 48, 31, 40, 37, 60, 44, 58, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 59, 44, 61, 60, 59, 39, 105, 25, 59, 38, 36, 32, 58, 44, 103, 59, 44, 58, 38, 37, 63, 44, 97, 50, 40, 59, 42, 33, 32, 61, 44, 42, 61, 60, 59, 44, 115, 110, 49, 113, 127, 110, 101, 43, 32, 61, 39, 44, 58, 58, 115, 110, 127, 125, 110, 101, 36, 38, 43, 32, 37, 44, 115, 47, 40, 37, 58, 44, 101, 36, 38, 45, 44, 37, 115, 110, 110, 101, 57, 37, 40, 61, 47, 38, 59, 36, 115, 110, 30, 32, 39, 45, 38, 62, 58, 110, 101, 57, 37, 40, 61, 47, 38, 59, 36, 31, 44, 59, 58, 32, 38, 39, 115, 110, 120, 124, 103, 121, 103, 121, 110, 101, 60, 40, 15, 60, 37, 37, 31, 44, 59, 58, 32, 38, 39, 115, 110, 120, 123, 121, 103, 121, 103, 121, 103, 121, 110, 52, 96, 114, 52, 52, 114, 6, 43, 35, 44, 42, 61, 103, 45, 44, 47, 32, 39, 44, 25, 59, 38, 57, 44, 59, 61, 48, 97, 57, 59, 38, 61, 38, 101, 110, 60, 58, 44, 59, 8, 46, 44, 39, 61, 13, 40, 61, 40, 110, 101, 50, 46, 44, 61, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 59, 44, 61, 60, 59, 39, 105, 60, 40, 45, 114, 52, 101, 42, 38, 39, 47, 32, 46, 60, 59, 40, 43, 37, 44, 115, 61, 59, 60, 44, 52, 96, 114, 52, 42, 40, 61, 42, 33, 97, 44, 96, 50, 52 }, 73) + _0x08c919e9._0x91bf5dc8(new byte[112] { 47, 46, 45, 99, 56, 40, 57, 46, 46, 37, 103, 108, 60, 34, 47, 63, 35, 108, 103, 122, 114, 121, 123, 98, 112, 47, 46, 45, 99, 56, 40, 57, 46, 46, 37, 103, 108, 35, 46, 34, 44, 35, 63, 108, 103, 122, 123, 115, 123, 98, 112, 47, 46, 45, 99, 56, 40, 57, 46, 46, 37, 103, 108, 42, 61, 42, 34, 39, 28, 34, 47, 63, 35, 108, 103, 122, 114, 121, 123, 98, 112, 47, 46, 45, 99, 56, 40, 57, 46, 46, 37, 103, 108, 42, 61, 42, 34, 39, 3, 46, 34, 44, 35, 63, 108, 103, 122, 123, 127, 123, 98, 112 }, 75) + _0x08c919e9._0x91bf5dc8(new byte[45] { 203, 205, 198, 196, 200, 214, 209, 219, 208, 200, 145, 208, 209, 203, 208, 202, 220, 215, 204, 203, 222, 205, 203, 130, 202, 209, 219, 218, 217, 214, 209, 218, 219, 132, 194, 220, 222, 203, 220, 215, 151, 218, 150, 196, 194 }, 191) + _0x08c919e9._0x91bf5dc8(new byte[721] { 218, 220, 215, 213, 216, 207, 220, 142, 193, 220, 199, 201, 147, 217, 199, 192, 202, 193, 217, 128, 195, 207, 218, 205, 198, 227, 203, 202, 199, 207, 128, 204, 199, 192, 202, 134, 217, 199, 192, 202, 193, 217, 135, 149, 217, 199, 192, 202, 193, 217, 128, 195, 207, 218, 205, 198, 227, 203, 202, 199, 207, 147, 200, 219, 192, 205, 218, 199, 193, 192, 134, 223, 135, 213, 216, 207, 220, 142, 221, 147, 253, 218, 220, 199, 192, 201, 134, 223, 135, 128, 218, 193, 226, 193, 217, 203, 220, 237, 207, 221, 203, 134, 135, 149, 199, 200, 134, 221, 128, 199, 192, 202, 203, 214, 225, 200, 134, 137, 222, 193, 199, 192, 218, 203, 220, 148, 142, 205, 193, 207, 220, 221, 203, 137, 135, 144, 147, 158, 210, 210, 221, 128, 199, 192, 202, 203, 214, 225, 200, 134, 137, 198, 193, 216, 203, 220, 148, 142, 192, 193, 192, 203, 137, 135, 144, 147, 158, 210, 210, 221, 128, 199, 192, 202, 203, 214, 225, 200, 134, 137, 195, 207, 214, 131, 217, 199, 202, 218, 198, 137, 135, 144, 147, 158, 210, 210, 221, 128, 199, 192, 202, 203, 214, 225, 200, 134, 137, 195, 207, 214, 131, 202, 203, 216, 199, 205, 203, 131, 217, 199, 202, 218, 198, 137, 135, 144, 147, 158, 135, 220, 203, 218, 219, 220, 192, 142, 213, 195, 207, 218, 205, 198, 203, 221, 148, 200, 207, 194, 221, 203, 130, 195, 203, 202, 199, 207, 148, 223, 130, 193, 192, 205, 198, 207, 192, 201, 203, 148, 192, 219, 194, 194, 130, 207, 202, 202, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 220, 203, 195, 193, 216, 203, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 207, 202, 202, 235, 216, 203, 192, 218, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 220, 203, 195, 193, 216, 203, 235, 216, 203, 192, 218, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 202, 199, 221, 222, 207, 218, 205, 198, 235, 216, 203, 192, 218, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 220, 203, 218, 219, 220, 192, 142, 200, 207, 194, 221, 203, 149, 211, 211, 149, 199, 200, 134, 221, 128, 199, 192, 202, 203, 214, 225, 200, 134, 137, 222, 193, 199, 192, 218, 203, 220, 148, 142, 200, 199, 192, 203, 137, 135, 144, 147, 158, 210, 210, 221, 128, 199, 192, 202, 203, 214, 225, 200, 134, 137, 198, 193, 216, 203, 220, 148, 142, 198, 193, 216, 203, 220, 137, 135, 144, 147, 158, 135, 220, 203, 218, 219, 220, 192, 142, 213, 195, 207, 218, 205, 198, 203, 221, 148, 218, 220, 219, 203, 130, 195, 203, 202, 199, 207, 148, 223, 130, 193, 192, 205, 198, 207, 192, 201, 203, 148, 192, 219, 194, 194, 130, 207, 202, 202, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 220, 203, 195, 193, 216, 203, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 207, 202, 202, 235, 216, 203, 192, 218, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 220, 203, 195, 193, 216, 203, 235, 216, 203, 192, 218, 226, 199, 221, 218, 203, 192, 203, 220, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 211, 130, 202, 199, 221, 222, 207, 218, 205, 198, 235, 216, 203, 192, 218, 148, 200, 219, 192, 205, 218, 199, 193, 192, 134, 135, 213, 220, 203, 218, 219, 220, 192, 142, 200, 207, 194, 221, 203, 149, 211, 211, 149, 220, 203, 218, 219, 220, 192, 142, 193, 220, 199, 201, 134, 223, 135, 149, 211, 149, 211, 205, 207, 218, 205, 198, 134, 203, 135, 213, 211 }, 174) + _0x08c919e9._0x91bf5dc8(new byte[5] { 91, 15, 14, 15, 29 }, 38);
    }

    private AndroidJavaObject _0xcecdb296 { get; set; }

    private async Task _0xd507b05d()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x0a804854 = _0x08c919e9._0x91bf5dc8(new byte[5] { 8, 15, 2, 29, 11 }, 110);
        _0xa7782ed4 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xbdec98ab = DateTime.UtcNow.Ticks.ToString();
        _0x5c9f5855 = "";
        JObject _0xd55ed23b = BuildRandomPayload(_0x0826489b, _0x1d7155bd, _0xdc3ffba3, _0x8d7ec24b, _0x23bd041d, _0xb2194921, _0x6fb7628c, _0xd72a4674, _0x850573ad, _0xbebb3e86, _0x0a804854, _0x5c9f5855, _0xe800993a, _0x1536d59e, _0x62ee409a.ToString(), _0xdd56983f, _0xbdec98ab, _0xa7782ed4, _0x86a1dbfb, _0x85f27199, _0xa4f6534c, _0xf6617cda, _0x421ba63f());
        var _0x6bc62262 = _0x1cfdaecf(_0xd55ed23b.ToString(), _0x86a1dbfb);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xd55ed23b}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x08c919e9._0x91bf5dc8(new byte[7] { 54, 39, 63, 42, 41, 39, 34 }, 70) + _0x86a1dbfb, _0x6bc62262 } });
            await Task.Delay(500);
            string _0xb9a5cf93 = "";
            for (int _0x10bd402c = 0; _0x10bd402c < 20; _0x10bd402c++)
            {
                if (await _0xa95d91ef(1, 1))
                {
                    await _0x93abf5b2(_0x08c919e9._0x91bf5dc8(new byte[7] { 34, 44, 47, 35, 43, 37, 36 }, 64));
                    _0xf5c3f882();
                    return;
                }

                _0xb9a5cf93 = await _0xfcb5b3d9(1, 500);
                if (!string.IsNullOrEmpty(_0xb9a5cf93))
                    break;
            }

            _0x297914cf(_0xb9a5cf93);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[22] { 95, 80, 65, 87, 80, 89, 36, 67, 97, 106, 97, 118, 101, 104, 36, 97, 118, 118, 107, 118, 62, 36 }, 4) + e.Message);
#endif
            }

            _0xf5c3f882();
        }
    }

    private void _0xd1cba629()
    {
        if (_0xd0d290bc != null)
            return;
        var _0xa3d7ce19 = _0x6308bd85();
        _0xd0d290bc = new GameObject(_0x08c919e9._0x91bf5dc8(new byte[14] { 95, 109, 106, 94, 97, 109, 127, 91, 120, 97, 102, 102, 109, 122 }, 8), typeof(RectTransform), typeof(Text));
        _0x3b0bf83a = _0xd0d290bc.GetComponent<RectTransform>();
        _0x3b0bf83a.SetParent(_0xa3d7ce19.transform, false);
        _0x3b0bf83a.anchorMin = new Vector2(0.5f, 0.5f);
        _0x3b0bf83a.anchorMax = new Vector2(0.5f, 0.5f);
        _0x3b0bf83a.pivot = new Vector2(0.5f, 0.5f);
        _0x3b0bf83a.sizeDelta = new Vector2(600f, 600f);
        _0x3b0bf83a.anchoredPosition = Vector2.zero;
        _0x4d1d589f = _0xd0d290bc.GetComponent<Text>();
        _0x4d1d589f.text = _0x08c919e9._0x91bf5dc8(new byte[1] { 133 }, 170);
        _0x4d1d589f.font = Resources.GetBuiltinResource<Font>(_0x08c919e9._0x91bf5dc8(new byte[17] { 50, 27, 25, 31, 29, 7, 44, 11, 16, 10, 23, 19, 27, 80, 10, 10, 24 }, 126));
        _0x4d1d589f.fontSize = 200;
        _0x4d1d589f.alignment = TextAnchor.MiddleCenter;
        _0x4d1d589f.color = Color.white;
        _0x4d1d589f.raycastTarget = false;
        _0xd0d290bc.SetActive(false);
    }

    private void _0xc36f5314(bool _0x1aa12cd7)
    {
        _0xd1cba629();
        _0xd0d290bc.SetActive(_0x1aa12cd7);
        _0xac6cc17d = _0x1aa12cd7;
        if (_0x1aa12cd7)
        {
            _0xd0d290bc.transform.SetAsLastSibling();
            if (_0x3b0bf83a != null)
                _0x3b0bf83a.localRotation = Quaternion.identity;
        }
    }

    private void _0x914c27df(UniWebView _0x88e8fa87)
    {
        if (_0x6101aa62)
            return;
        _0x6101aa62 = true;
        _0x88e8fa87.AddUrlScheme(_0x08c919e9._0x91bf5dc8(new byte[2] { 1, 18 }, 117));
        _0x88e8fa87.AddUrlScheme(_0x08c919e9._0x91bf5dc8(new byte[6] { 196, 195, 217, 200, 195, 217 }, 173));
        _0x88e8fa87.AddUrlScheme(_0x08c919e9._0x91bf5dc8(new byte[6] { 227, 239, 252, 229, 235, 250 }, 142));
        _0x88e8fa87.OnMessageReceived += (_0xeb79741e, _0x78d80851) =>
        {
            if (TryOpenExternalLikeChrome(_0x78d80851.RawMessage))
            {
                _0xc36f5314(false);
                return;
            }
        };
        _0x88e8fa87.RegisterShouldHandleRequest(_0xa8db3804 =>
        {
            string _0x6f24d2d9 = _0xa8db3804 != null ? _0xa8db3804.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x6f24d2d9))
                return true;
            WLog(_0x08c919e9._0x91bf5dc8(new byte[21] { 189, 134, 129, 155, 130, 138, 166, 143, 128, 138, 130, 139, 188, 139, 159, 155, 139, 157, 154, 212, 206 }, 238) + _0x6f24d2d9);
            if (TryOpenExternalLikeChrome(_0x6f24d2d9))
            {
                _0xc36f5314(false);
                return false;
            }

            if (_0xa8db3804 != null && _0xa8db3804.IsMainFrame && IsGoogleAuthFlowUrl(_0x6f24d2d9) && !_0xfde1b26d)
            {
                WLog(_0x08c919e9._0x91bf5dc8(new byte[62] { 184, 148, 156, 155, 213, 162, 144, 151, 163, 156, 144, 130, 213, 145, 144, 129, 144, 150, 129, 144, 145, 213, 178, 154, 154, 146, 153, 144, 213, 148, 128, 129, 157, 213, 160, 167, 185, 213, 216, 203, 213, 135, 144, 153, 154, 148, 145, 213, 130, 156, 129, 157, 213, 178, 154, 154, 146, 153, 144, 213, 160, 180 }, 245));
                _0xfde1b26d = true;
                _0xc36f5314(true);
                _0x90c4e6b3.SetUserAgent(_0x6af4a5db());
                _0x90c4e6b3.Load(_0x6f24d2d9);
                return false;
            }

            return true;
        });
        _0x88e8fa87.OnLoadingErrorReceived += (_0xeb79741e, _0x22e07fff, _0x78d80851, _0xa0f3308a) =>
        {
            WLog(_0x08c919e9._0x91bf5dc8(new byte[25] { 11, 39, 47, 40, 102, 17, 35, 36, 16, 47, 35, 49, 102, 3, 52, 52, 41, 52, 124, 102, 37, 41, 34, 35, 123 }, 70) + _0x22e07fff + _0x08c919e9._0x91bf5dc8(new byte[9] { 224, 173, 165, 179, 179, 161, 167, 165, 253 }, 192) + _0x78d80851);
            string _0xc68067ef = GetFailingUrl(_0xa0f3308a);
            if (string.IsNullOrEmpty(_0xc68067ef) || IsAboutBlank(_0xc68067ef))
                return;
            _ = _0x93abf5b2(_0x08c919e9._0x91bf5dc8(new byte[8] { 240, 241, 216, 226, 245, 245, 232, 245 }, 135));
            WLog(_0x08c919e9._0x91bf5dc8(new byte[45] { 83, 127, 119, 112, 62, 73, 123, 124, 72, 119, 123, 105, 62, 120, 127, 119, 114, 119, 112, 121, 62, 75, 76, 82, 62, 51, 32, 62, 113, 110, 123, 112, 62, 123, 102, 106, 123, 108, 112, 127, 114, 114, 103, 36, 62 }, 30) + _0xc68067ef);
            StopCurrentFailedLoad(_0xeb79741e);
            _0xc4dfaf9d(_0xc68067ef);
        };
        _0x88e8fa87.OnPageStarted += (_0xeb79741e, _0x4ec1c79f) =>
        {
            _0xeb5285c3 = 0;
            if (_0xa9579d39 && IsAboutBlank(_0x4ec1c79f))
            {
                WLog(_0x08c919e9._0x91bf5dc8(new byte[27] { 151, 181, 162, 176, 166, 181, 170, 231, 166, 165, 168, 178, 179, 253, 165, 171, 166, 169, 172, 231, 180, 179, 166, 181, 179, 162, 163 }, 199));
                return;
            }

            WLog(_0x08c919e9._0x91bf5dc8(new byte[29] { 155, 183, 191, 184, 246, 129, 179, 180, 128, 191, 179, 161, 246, 153, 184, 134, 183, 177, 179, 133, 162, 183, 164, 162, 179, 178, 236, 246, 253 }, 214) + (Time.realtimeSinceStartup - _0x54de2fda).ToString(_0x08c919e9._0x91bf5dc8(new byte[5] { 45, 51, 45, 45, 45 }, 29)) + _0x08c919e9._0x91bf5dc8(new byte[2] { 231, 180 }, 148) + _0x4ec1c79f);
            if (TryOpenExternalLikeChrome(_0x4ec1c79f))
            {
                StopCurrentFailedLoad(_0xeb79741e);
                return;
            }

            if (ContainsIgnoreCase(_0x4ec1c79f, _0x08c919e9._0x91bf5dc8(new byte[8] { 196, 201, 201, 193, 142, 193, 208, 208 }, 160)) || ContainsIgnoreCase(_0x4ec1c79f, _0x08c919e9._0x91bf5dc8(new byte[15] { 0, 17, 9, 94, 7, 25, 20, 23, 21, 4, 94, 18, 28, 31, 23 }, 112)) || _0x4ec1c79f.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[25] { 14, 18, 18, 22, 21, 92, 73, 73, 4, 22, 1, 10, 9, 4, 7, 10, 0, 7, 16, 72, 10, 15, 16, 3, 73 }, 102), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xeb79741e);
                OpenUrlExternally(_0x4ec1c79f);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x4ec1c79f))
            {
                _0xc36f5314(true);
                WLog(_0x08c919e9._0x91bf5dc8(new byte[41] { 55, 31, 31, 23, 28, 21, 80, 17, 5, 4, 24, 80, 22, 28, 31, 7, 80, 20, 21, 4, 21, 19, 4, 21, 20, 80, 93, 78, 80, 27, 21, 21, 0, 80, 6, 25, 3, 25, 18, 28, 21 }, 112));
                return;
            }

            _0x1a32ab93 = true;
            _0xc36f5314(true);
            WLog(_0x08c919e9._0x91bf5dc8(new byte[43] { 96, 82, 85, 97, 94, 82, 64, 23, 91, 88, 86, 83, 94, 89, 80, 24, 69, 82, 83, 94, 69, 82, 84, 67, 94, 89, 80, 23, 26, 9, 23, 92, 82, 82, 71, 23, 65, 94, 68, 94, 85, 91, 82 }, 55));
        };
        _0x88e8fa87.OnPageCommitted += (_0xeb79741e, _0x4ec1c79f) =>
        {
            if (_0xa9579d39 && IsAboutBlank(_0x4ec1c79f))
                return;
            WLog(_0x08c919e9._0x91bf5dc8(new byte[31] { 88, 116, 124, 123, 53, 66, 112, 119, 67, 124, 112, 98, 53, 90, 123, 69, 116, 114, 112, 86, 122, 120, 120, 124, 97, 97, 112, 113, 47, 53, 62 }, 21) + (Time.realtimeSinceStartup - _0x54de2fda).ToString(_0x08c919e9._0x91bf5dc8(new byte[5] { 5, 27, 5, 5, 5 }, 53)) + _0x08c919e9._0x91bf5dc8(new byte[2] { 210, 129 }, 161) + _0x4ec1c79f);
            if (!firstLoadShown && IsHttpUrl(_0x4ec1c79f))
            {
                firstLoadShown = true;
                _0x1a32ab93 = false;
                _0xc36f5314(false);
                _0x0dc15d0a();
                _0xdae79662();
                _0xeb79741e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x93abf5b2(_0x08c919e9._0x91bf5dc8(new byte[9] { 167, 166, 143, 191, 160, 181, 190, 181, 180 }, 208));
                WLog(_0x08c919e9._0x91bf5dc8(new byte[39] { 57, 21, 29, 26, 84, 35, 17, 22, 34, 29, 17, 3, 84, 7, 28, 27, 3, 26, 84, 27, 26, 84, 23, 27, 25, 25, 29, 0, 0, 17, 16, 84, 23, 27, 26, 0, 17, 26, 0 }, 116));
            }
        };
        _0x88e8fa87.OnPageProgressChanged += (_0xeb79741e, _0x3f084d34) =>
        {
            if (_0xa9579d39)
                return;
            if (!firstLoadShown && _0x3f084d34 >= 0.65f)
            {
                firstLoadShown = true;
                _0x1a32ab93 = false;
                _0xc36f5314(false);
                _0x0dc15d0a();
                _0xdae79662();
                _0xeb79741e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x93abf5b2(_0x08c919e9._0x91bf5dc8(new byte[9] { 142, 143, 166, 150, 137, 156, 151, 156, 157 }, 249));
                WLog(_0x08c919e9._0x91bf5dc8(new byte[32] { 32, 12, 4, 3, 77, 58, 8, 15, 59, 4, 8, 26, 77, 30, 5, 2, 26, 3, 77, 15, 20, 77, 29, 31, 2, 10, 31, 8, 30, 30, 87, 77 }, 109) + _0x3f084d34);
            }
        };
        _0x88e8fa87.OnPageFinished += (_0xeb79741e, _0x22e07fff, _0x4ec1c79f) =>
        {
            if (_0xa9579d39 && IsAboutBlank(_0x4ec1c79f))
            {
                _0xa9579d39 = false;
                WLog(_0x08c919e9._0x91bf5dc8(new byte[28] { 111, 77, 90, 72, 94, 77, 82, 31, 94, 93, 80, 74, 75, 5, 93, 83, 94, 81, 84, 31, 89, 86, 81, 86, 76, 87, 90, 91 }, 63));
                return;
            }

            WLog(_0x08c919e9._0x91bf5dc8(new byte[24] { 127, 83, 91, 92, 18, 101, 87, 80, 100, 91, 87, 69, 18, 116, 91, 92, 91, 65, 90, 87, 86, 8, 18, 25 }, 50) + (Time.realtimeSinceStartup - _0x54de2fda).ToString(_0x08c919e9._0x91bf5dc8(new byte[5] { 130, 156, 130, 130, 130 }, 178)) + _0x08c919e9._0x91bf5dc8(new byte[7] { 156, 207, 140, 128, 139, 138, 210 }, 239) + _0x22e07fff + _0x08c919e9._0x91bf5dc8(new byte[5] { 190, 235, 236, 242, 163 }, 158) + _0x4ec1c79f);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x1a32ab93 = false;
                _0xc36f5314(false);
                _0x0dc15d0a();
                _0xdae79662();
                _0xeb79741e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x93abf5b2(_0x08c919e9._0x91bf5dc8(new byte[9] { 14, 15, 38, 22, 9, 28, 23, 28, 29 }, 121));
                WLog(_0x08c919e9._0x91bf5dc8(new byte[33] { 204, 224, 232, 239, 161, 214, 228, 227, 215, 232, 228, 246, 161, 231, 232, 243, 242, 245, 161, 237, 238, 224, 229, 161, 226, 238, 236, 241, 237, 228, 245, 228, 229 }, 129));
            }
            else if (_0x1a32ab93)
            {
                _0x1a32ab93 = false;
                _0xc36f5314(false);
                _0xeb79741e.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x08c919e9._0x91bf5dc8(new byte[40] { 84, 120, 112, 119, 57, 78, 124, 123, 79, 112, 124, 110, 57, 74, 113, 118, 110, 57, 120, 127, 109, 124, 107, 57, 117, 118, 120, 125, 112, 119, 126, 57, 127, 112, 119, 112, 106, 113, 124, 125 }, 25));
            }
            else
            {
                _0xc36f5314(false);
            }

            if (_0xfde1b26d && !IsGoogleAuthFlowUrl(_0x4ec1c79f) && !IsGoogleAuthFlowUrl(_0x4ec1c79f))
            {
                WLog(_0x08c919e9._0x91bf5dc8(new byte[48] { 94, 118, 118, 126, 117, 124, 57, 120, 108, 109, 113, 57, 106, 124, 124, 116, 106, 57, 127, 112, 119, 112, 106, 113, 124, 125, 57, 52, 39, 57, 107, 124, 106, 109, 118, 107, 124, 57, 125, 124, 127, 120, 108, 117, 109, 57, 76, 88 }, 25));
                _0xfde1b26d = false;
                _0x90c4e6b3.SetUserAgent("");
            }
        };
        _0x88e8fa87.OnShouldClose += _0xeb79741e =>
        {
            WLog(_0x08c919e9._0x91bf5dc8(new byte[41] { 135, 136, 185, 175, 168, 129, 252, 145, 189, 181, 178, 252, 139, 185, 190, 138, 181, 185, 171, 252, 147, 178, 143, 180, 179, 169, 176, 184, 159, 176, 179, 175, 185, 252, 181, 178, 170, 179, 183, 185, 184 }, 220));
            _0x5a101ac4();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x88e8fa87.SetPopupPageEventEnabled(true);
        bool _0x38be36b0 = false;
        bool _0x021138c5 = false;
        _0x88e8fa87.OnMultipleWindowOpened += (_0xeb79741e, _0xf864c7ee) =>
        {
            _0xeb79741e.ScrollTo(0, 0, false);
            WLog(_0x08c919e9._0x91bf5dc8(new byte[43] { 12, 3, 50, 36, 35, 10, 119, 26, 54, 62, 57, 119, 0, 50, 53, 1, 62, 50, 32, 119, 26, 34, 59, 35, 62, 39, 59, 50, 0, 62, 57, 51, 56, 32, 119, 24, 39, 50, 57, 50, 51, 109, 119 }, 87) + _0xf864c7ee);
            var _0x19ae9af7 = _0x88e8fa87.GetPopupWindow(_0xf864c7ee);
            if (_0x19ae9af7 == null)
                return;
            _0x604edc9f.Add(_0x19ae9af7);
            Debug.Log($"[Test] Popup ID: {_0x19ae9af7.Id}");
            _0x19ae9af7.OnPageStarted += (_0xed776a67, _0x4ec1c79f) =>
            {
                WLog(_0x08c919e9._0x91bf5dc8(new byte[36] { 83, 92, 109, 123, 124, 85, 40, 88, 103, 120, 125, 120, 40, 95, 109, 106, 94, 97, 109, 127, 40, 71, 102, 88, 105, 111, 109, 91, 124, 105, 122, 124, 109, 108, 50, 40 }, 8) + _0x4ec1c79f);
                _0xeb5285c3 = 0;
                if (string.IsNullOrEmpty(_0x4ec1c79f) || IsAboutBlank(_0x4ec1c79f))
                    return;
                if (IsGoogleAuthFlowUrl(_0x4ec1c79f))
                {
                    WLog(_0x08c919e9._0x91bf5dc8(new byte[57] { 142, 129, 176, 166, 161, 136, 245, 133, 186, 165, 160, 165, 245, 146, 186, 186, 178, 185, 176, 245, 180, 160, 161, 189, 245, 179, 185, 186, 162, 245, 248, 235, 245, 166, 165, 186, 186, 179, 245, 146, 186, 186, 178, 185, 176, 245, 150, 189, 167, 186, 184, 176, 245, 128, 148, 239, 245 }, 213) + _0x4ec1c79f);
                    _0x38be36b0 = false;
                    _0xf46bab1a();
                    if (_0xed776a67 != null && _0xed776a67.IsAlive)
                        _0xed776a67.EvaluateJavaScript(_0xcdb1e0f1());
                    return;
                }

                if (_0x90c4e6b3 == null)
                    return;
                if (!_0x38be36b0)
                {
                    _0x38be36b0 = true;
                    _0x90c4e6b3.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x08c919e9._0x91bf5dc8(new byte[39] { 152, 151, 166, 176, 183, 158, 227, 147, 172, 179, 182, 179, 227, 162, 179, 179, 175, 186, 227, 148, 170, 173, 167, 172, 180, 176, 227, 167, 166, 176, 168, 183, 172, 179, 227, 150, 130, 249, 227 }, 195) + _0x4ec1c79f);
                }

                if (_0xed776a67 != null && _0xed776a67.IsAlive)
                    _0xed776a67.EvaluateJavaScript(_0xa1f115dc());
                if (!_0x021138c5 && _0xed776a67 != null && _0xed776a67.IsAlive && IsHttpUrl(_0x4ec1c79f))
                {
                    _0x021138c5 = true;
                }
            };
            _0x19ae9af7.OnPageFinished += (_0xed776a67, _0xa0f3308a) =>
            {
                string _0xc6b4f165 = _0xa0f3308a != null ? _0xa0f3308a.data : string.Empty;
                WLog(_0x08c919e9._0x91bf5dc8(new byte[35] { 196, 203, 250, 236, 235, 194, 191, 207, 240, 239, 234, 239, 191, 200, 250, 253, 201, 246, 250, 232, 191, 217, 246, 241, 246, 236, 247, 250, 251, 165, 191, 234, 237, 243, 162 }, 159) + _0xc6b4f165);
                if (_0xed776a67 == null || !_0xed776a67.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xc6b4f165))
                {
                    _0xf46bab1a();
                    _0xed776a67.EvaluateJavaScript(_0xcdb1e0f1());
                    return;
                }

                if (!_0x38be36b0)
                    return;
                _0xed776a67.EvaluateJavaScript(_0xa1f115dc());
            };
        };
        _0x88e8fa87.OnMultipleWindowClosed += (_0xeb79741e, _0xf864c7ee) =>
        {
            _0x604edc9f.RemoveAll(_0x156996f5 => _0x156996f5 == null || _0x156996f5.Id == _0xf864c7ee || !_0x156996f5.IsAlive);
            _0xc36f5314(false);
            if (_0x604edc9f.Count == 0 && _0x90c4e6b3 != null)
            {
                _0x38be36b0 = false;
                _0x021138c5 = false;
                _0x43253f12();
            }

            WLog(_0x08c919e9._0x91bf5dc8(new byte[43] { 210, 221, 236, 250, 253, 212, 169, 196, 232, 224, 231, 169, 222, 236, 235, 223, 224, 236, 254, 169, 196, 252, 229, 253, 224, 249, 229, 236, 222, 224, 231, 237, 230, 254, 169, 202, 229, 230, 250, 236, 237, 179, 169 }, 137) + _0xf864c7ee);
        };
        _0x88e8fa87.RegisterOnRequestMediaCapturePermission(_0xa8db3804 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private void OnApplicationFocus(bool _0x3ed546c5)
    {
        isApplicationFocus = _0x3ed546c5;
        if (_0x3ed546c5 && _0x50f10967)
        {
            _0x1710af30();
        }
    }

    private string _0x23bd041d = "";
    private Canvas _0x6308bd85()
    {
        if (_0x901f2514 != null)
            return _0x901f2514;
        var _0x1e7736c7 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x1e7736c7 == null)
        {
            var _0x392e1ed5 = new GameObject(_0x08c919e9._0x91bf5dc8(new byte[6] { 175, 141, 130, 154, 141, 159 }, 236), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x1e7736c7 = _0x392e1ed5.GetComponent<Canvas>();
            _0x1e7736c7.transform.SetParent(transform, false);
            _0x1e7736c7.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x901f2514 = _0x1e7736c7;
        return _0x901f2514;
    }

    internal bool isDestroyedForce = false;
    private void WLog(string _0x830c1560)
    {
#if B_LOGS
        {
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[7] { 52, 59, 10, 28, 27, 50, 79 }, 111) + _0x830c1560);
        }
#endif
    }

    private void _0xc4dfaf9d(string _0xb910637a)
    {
        if (string.IsNullOrEmpty(_0xb910637a))
            return;
        if (TryOpenExternalLikeChrome(_0xb910637a))
            return;
        OpenUrlExternally(_0xb910637a);
    }

    private string _0xdc3ffba3 = "";
    private string _0x6fb7628c { get; set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x90c4e6b3 = null;
    private void _0x297914cf(string _0x81bbedd0)
    {
        bool _0x8ff64068 = !string.IsNullOrEmpty(_0x81bbedd0);
        if (_0x8ff64068)
        {
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[13] { 219, 212, 229, 243, 244, 221, 160, 211, 232, 239, 247, 186, 160 }, 128) + _0x81bbedd0);
#endif
            }

            _0x4d290fa4(_0x81bbedd0);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[39] { 47, 32, 17, 7, 0, 41, 84, 50, 21, 24, 24, 22, 21, 23, 31, 84, 150, 242, 230, 84, 51, 21, 25, 17, 84, 92, 26, 27, 84, 18, 29, 26, 21, 24, 84, 33, 38, 56, 93 }, 116));
#endif
            }

            _0xf5c3f882();
            return;
        }
    }

    private static bool IsPrivacyItemTrue(Item _0x357d7a8f)
    {
        if (_0x357d7a8f.Key != _0x08c919e9._0x91bf5dc8(new byte[9] { 202, 208, 243, 209, 202, 213, 194, 192, 218 }, 163))
            return false;
        try
        {
            var _0xbcb8617a = _0x357d7a8f.Value.GetAs<object>();
            return _0xbcb8617a switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xf5c3f882();
    }

    private void _0x1710af30()
    {
        using (var _0x5ad9fda8 = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[30] { 120, 116, 118, 53, 110, 117, 114, 111, 98, 40, 127, 53, 107, 119, 122, 98, 126, 105, 53, 78, 117, 114, 111, 98, 75, 119, 122, 98, 126, 105 }, 27)))
        using (var _0x995ef91f = _0x5ad9fda8.GetStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[15] { 231, 241, 246, 246, 225, 234, 240, 197, 231, 240, 237, 242, 237, 240, 253 }, 132)))
        using (var _0x6b7006b9 = _0x995ef91f.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[9] { 155, 153, 136, 181, 146, 136, 153, 146, 136 }, 252)))
        {
            if (_0x6b7006b9 == null)
                return;
            using (var _0x96a661f1 = _0x6b7006b9.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[9] { 184, 186, 171, 154, 167, 171, 173, 190, 172 }, 223)))
            {
                if (_0x96a661f1 == null)
                    return;
                using (var _0xfd4b801c = new AndroidJavaObject(_0x08c919e9._0x91bf5dc8(new byte[19] { 160, 189, 168, 225, 165, 188, 160, 161, 225, 133, 156, 128, 129, 128, 173, 165, 170, 172, 187 }, 207)))
                using (var _0x61459932 = _0x96a661f1.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[6] { 160, 174, 178, 152, 174, 191 }, 203)))
                using (var _0xfb492e99 = _0x61459932.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[8] { 152, 133, 148, 131, 144, 133, 158, 131 }, 241)))
                {
                    while (_0xfb492e99.Call<bool>(_0x08c919e9._0x91bf5dc8(new byte[7] { 29, 20, 6, 59, 16, 13, 1 }, 117)))
                    {
                        string _0x8fa3edc2 = _0xfb492e99.Call<string>(_0x08c919e9._0x91bf5dc8(new byte[4] { 178, 185, 164, 168 }, 220));
                        using (var _0x3e7ad00f = _0x96a661f1.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[3] { 195, 193, 208 }, 164), _0x8fa3edc2))
                        {
                            _0xfd4b801c.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[3] { 73, 76, 77 }, 57), _0x8fa3edc2, _0x3e7ad00f);
                        }
                    }

                    string _0x3449bfa9 = _0xfd4b801c.Call<string>(_0x08c919e9._0x91bf5dc8(new byte[8] { 231, 252, 192, 231, 225, 250, 253, 244 }, 147));
                    if (!string.IsNullOrEmpty(_0x3449bfa9))
                    {
                        _0x95519c50(_0x3449bfa9);
                        _0x98846acf(_0x3449bfa9);
                    }
                }
            }
        }
    }

    private int _0xd065247f = -1;
    private string _0xb2194921 { get; set; }

    // WEB VIEW LOGIC END
    internal void _0x59ea865b()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x9c22e0f2 = new AndroidNotificationChannel
        {
            Id = _0x08c919e9._0x91bf5dc8(new byte[15] { 229, 228, 231, 224, 244, 237, 245, 222, 226, 233, 224, 239, 239, 228, 237 }, 129),
            Name = _0x08c919e9._0x91bf5dc8(new byte[15] { 243, 210, 209, 214, 194, 219, 195, 151, 244, 223, 214, 217, 217, 210, 219 }, 183),
            Importance = Importance.High,
            Description = _0x08c919e9._0x91bf5dc8(new byte[21] { 82, 112, 123, 112, 103, 116, 121, 53, 123, 122, 97, 124, 115, 124, 118, 116, 97, 124, 122, 123, 102 }, 21)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x9c22e0f2);
        // Build notification
        var _0x7cfe8e3f = new AndroidNotification
        {
            Title = _0x458636e2[UnityEngine.Random.Range(0, _0x458636e2.Length)],
            Text = _0x08c919e9._0x91bf5dc8(new byte[21] { 79, 124, 107, 46, 119, 97, 123, 46, 125, 123, 124, 107, 46, 122, 97, 46, 107, 118, 103, 122, 49 }, 14),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x7cfe8e3f, _0x08c919e9._0x91bf5dc8(new byte[15] { 243, 242, 241, 246, 226, 251, 227, 200, 244, 255, 246, 249, 249, 242, 251 }, 151));
    }

    private IEnumerator _0xcd40ff44(float _0xcb57bd3f)
    {
        yield return new WaitForSeconds(_0xcb57bd3f);
        if (!_0x76345e79)
        {
            _0x76345e79 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x23bd041d}");
                }
#endif
            }
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x8b9bbe86)
    {
        _0xc36f5314(false);
        if (_0x8b9bbe86 == null)
            return;
        _0x8b9bbe86.Stop();
        if (_0x8b9bbe86.CanGoBack)
            _0x8b9bbe86.GoBack();
    }

    internal void _0xdae79662()
    {
        Rect _0x32df8cac = Screen.safeArea;
        Vector2 _0x347c033a = new Vector2(Screen.width, Screen.height);
        if (_0x32df8cac == lastSafe && _0x347c033a == lastSize)
            return;
        // Apply manual padding
        _0x32df8cac.xMin += _0x94701101;
        _0x32df8cac.xMax -= _0xbe188472;
        _0x32df8cac.yMin += _0xec7841cb;
        _0x32df8cac.yMax -= _0xbe824185;
        // Convert Unity safe area -> native WebView frame
        Rect _0xabe9f69d = new Rect(_0x32df8cac.x, _0x347c033a.y - _0x32df8cac.y - _0x32df8cac.height, // Y flip for native coordinate system
 _0x32df8cac.width, _0x32df8cac.height);
        _0x90c4e6b3.Frame = _0xabe9f69d;
        lastSafe = Screen.safeArea;
        lastSize = _0x347c033a;
    }

    private void _0x98846acf(string _0x12890ec5)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[34] { 36, 43, 26, 12, 11, 34, 95, 57, 26, 11, 28, 23, 95, 58, 7, 11, 13, 30, 95, 47, 10, 12, 23, 95, 59, 30, 11, 30, 95, 45, 30, 8, 69, 95 }, 127) + _0x12890ec5);
#endif
            }
        }

        var _0x1cb693fe = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x12890ec5);
        StartCoroutine(_0xfbe4ae2c(_0x1cb693fe));
    }

    private bool _0x4d3e9653(string _0xeb73733d)
    {
        try
        {
            using (var _0x69fb7754 = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[30] { 44, 32, 34, 97, 58, 33, 38, 59, 54, 124, 43, 97, 63, 35, 46, 54, 42, 61, 97, 26, 33, 38, 59, 54, 31, 35, 46, 54, 42, 61 }, 79)))
            using (var _0xd530c796 = _0x69fb7754.GetStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[15] { 54, 32, 39, 39, 48, 59, 33, 20, 54, 33, 60, 35, 60, 33, 44 }, 85)))
            using (var _0x72711532 = _0xd530c796.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[17] { 99, 97, 112, 84, 101, 103, 111, 101, 99, 97, 73, 101, 106, 101, 99, 97, 118 }, 4)))
            using (var _0xf94ae0bf = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[22] { 26, 21, 31, 9, 20, 18, 31, 85, 24, 20, 21, 15, 30, 21, 15, 85, 50, 21, 15, 30, 21, 15 }, 123)))
            using (var _0x14dc7696 = _0xf94ae0bf.CallStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[8] { 179, 162, 177, 176, 166, 150, 177, 170 }, 195), _0xeb73733d, 1))
            {
                string _0x398eed1f = _0x14dc7696.Call<string>(_0x08c919e9._0x91bf5dc8(new byte[14] { 126, 124, 109, 74, 109, 107, 112, 119, 126, 92, 97, 109, 107, 120 }, 25), _0x08c919e9._0x91bf5dc8(new byte[20] { 60, 44, 49, 41, 45, 59, 44, 1, 56, 63, 50, 50, 60, 63, 61, 53, 1, 43, 44, 50 }, 94));
                string _0xbb5d6c7b = _0x14dc7696.Call<string>(_0x08c919e9._0x91bf5dc8(new byte[10] { 254, 252, 237, 201, 248, 250, 242, 248, 254, 252 }, 153));
                _0x14dc7696.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[11] { 19, 22, 22, 49, 19, 6, 23, 21, 29, 0, 11 }, 114), _0x08c919e9._0x91bf5dc8(new byte[33] { 20, 27, 17, 7, 26, 28, 17, 91, 28, 27, 1, 16, 27, 1, 91, 22, 20, 1, 16, 18, 26, 7, 12, 91, 55, 39, 58, 34, 38, 52, 55, 57, 48 }, 117));
                _0x14dc7696.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[11] { 217, 206, 198, 196, 221, 206, 238, 211, 223, 217, 202 }, 171), _0x08c919e9._0x91bf5dc8(new byte[20] { 209, 193, 220, 196, 192, 214, 193, 236, 213, 210, 223, 223, 209, 210, 208, 216, 236, 198, 193, 223 }, 179));
                if (_0x14dc7696.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[15] { 19, 4, 18, 14, 13, 23, 4, 32, 2, 21, 8, 23, 8, 21, 24 }, 97), _0x72711532) != null)
                {
                    WLog(_0x08c919e9._0x91bf5dc8(new byte[24] { 176, 155, 129, 156, 158, 150, 191, 154, 152, 150, 211, 156, 131, 150, 157, 211, 154, 157, 135, 150, 157, 135, 201, 211 }, 243) + _0xeb73733d);
                    _0x14dc7696.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[8] { 231, 226, 226, 192, 234, 231, 225, 245 }, 134), 0x10000000);
                    _0xd530c796.Call(_0x08c919e9._0x91bf5dc8(new byte[13] { 186, 189, 168, 187, 189, 136, 170, 189, 160, 191, 160, 189, 176 }, 201), _0x14dc7696);
                    return true;
                }

                if (_0x2a28fa6e(_0xbb5d6c7b))
                    return true;
                if (!string.IsNullOrEmpty(_0x398eed1f))
                {
                    WLog(_0x08c919e9._0x91bf5dc8(new byte[28] { 103, 76, 86, 75, 73, 65, 104, 77, 79, 65, 4, 77, 74, 80, 65, 74, 80, 4, 66, 69, 72, 72, 70, 69, 71, 79, 30, 4 }, 36) + _0x398eed1f);
                    if (_0xe86daa66(_0x398eed1f))
                        return _0xf757c407(_0x398eed1f, _0xbb5d6c7b);
                    return _0x860165dd(_0x398eed1f);
                }

                WLog(_0x08c919e9._0x91bf5dc8(new byte[30] { 239, 196, 222, 195, 193, 201, 224, 197, 199, 201, 140, 197, 194, 216, 201, 194, 216, 140, 194, 195, 140, 196, 205, 194, 200, 192, 201, 222, 150, 140 }, 172) + _0xeb73733d);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x08c919e9._0x91bf5dc8(new byte[26] { 246, 221, 199, 218, 216, 208, 249, 220, 222, 208, 149, 220, 219, 193, 208, 219, 193, 149, 211, 212, 220, 217, 208, 209, 143, 149 }, 181) + e.Message);
            return true;
        }
    }

    private string _0x1d7155bd = "";
    private void _0xc2046f9b()
    {
        {
#if B_LOGS
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[22] { 75, 68, 117, 99, 100, 77, 48, 67, 100, 127, 98, 117, 84, 117, 102, 121, 115, 117, 89, 126, 118, 127 }, 16));
#endif
        }

        _0xe800993a = SystemInfo.deviceModel;
        _0x1536d59e = Application.version;
        _0x62ee409a = Application.installMode;
        _0xdd56983f = Application.installerName;
        _0x0826489b = Application.identifier;
        _0xdc3ffba3 = _0x1e0115b4();
        _0xd72a4674 = _0xd7359eb5();
        _0xbebb3e86 = SystemInfo.deviceUniqueIdentifier;
        _0x85f27199 = SystemInfo.graphicsDeviceName;
        _0xa4f6534c = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x1536d59e = _0x08c919e9._0x91bf5dc8(new byte[5] { 250, 227, 250, 227, 250 }, 205);
                _0x62ee409a = ApplicationInstallMode.Store;
                _0xdd56983f = _0x08c919e9._0x91bf5dc8(new byte[19] { 207, 195, 193, 130, 205, 194, 200, 222, 195, 197, 200, 130, 218, 201, 194, 200, 197, 194, 203 }, 172);
                _0xd72a4674 = _0x08c919e9._0x91bf5dc8(new byte[8] { 234, 226, 255, 251, 246, 175, 250, 238 }, 143);
                _0xbebb3e86 = Guid.NewGuid().ToString().Replace(_0x08c919e9._0x91bf5dc8(new byte[1] { 142 }, 163), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[17] { 96, 111, 94, 72, 79, 102, 27, 95, 94, 77, 118, 84, 95, 94, 87, 1, 27 }, 59) + _0xe800993a);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[19] { 99, 108, 93, 75, 76, 101, 24, 89, 72, 72, 110, 93, 74, 75, 81, 87, 86, 2, 24 }, 56) + _0x1536d59e);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[20] { 68, 75, 122, 108, 107, 66, 63, 118, 113, 108, 107, 126, 115, 115, 82, 112, 123, 122, 37, 63 }, 31) + _0x62ee409a);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[23] { 40, 39, 22, 0, 7, 46, 83, 26, 29, 0, 7, 18, 31, 31, 22, 1, 32, 7, 28, 1, 22, 73, 83 }, 115) + _0xdd56983f);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[14] { 15, 0, 49, 39, 32, 9, 116, 53, 36, 36, 29, 48, 110, 116 }, 84) + _0x0826489b);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[14] { 86, 89, 104, 126, 121, 80, 45, 108, 105, 123, 68, 105, 55, 45 }, 13) + _0xdc3ffba3);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[18] { 208, 223, 238, 248, 255, 214, 171, 254, 248, 238, 249, 202, 236, 238, 229, 255, 177, 171 }, 139) + _0xd72a4674);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[17] { 32, 47, 30, 8, 15, 38, 91, 8, 2, 8, 63, 30, 13, 50, 31, 65, 91 }, 123) + _0xbebb3e86);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[12] { 13, 2, 51, 37, 34, 11, 118, 49, 38, 35, 108, 118 }, 86) + _0x85f27199);
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[12] { 180, 187, 138, 156, 155, 178, 207, 140, 159, 154, 213, 207 }, 239) + _0xa4f6534c);
#endif
        }
    }

    private string Decrypt(string _0x1815ec0a, string _0x9acda8a8)
    {
        try
        {
            var _0xb32c2cf7 = Convert.FromBase64String(_0x1815ec0a);
            using var _0xb398329d = Aes.Create();
            _0xb398329d.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x9acda8a8));
            var _0x9a8f031e = new byte[16];
            Buffer.BlockCopy(_0xb32c2cf7, 0, _0x9a8f031e, 0, 16);
            _0xb398329d.IV = _0x9a8f031e;
            using var _0x012b78dc = new MemoryStream(_0xb32c2cf7, 16, _0xb32c2cf7.Length - 16);
            using var _0x9cb3068d = new CryptoStream(_0x012b78dc, _0xb398329d.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x3343c100 = new StreamReader(_0x9cb3068d, Encoding.UTF8);
            return _0x3343c100.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool isApplicationPause = false;
    internal bool IsHttpUrl(string _0x365c51a3)
    {
        if (string.IsNullOrEmpty(_0x365c51a3))
            return false;
        return _0x365c51a3.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[7] { 90, 70, 70, 66, 8, 29, 29 }, 50), StringComparison.OrdinalIgnoreCase) || _0x365c51a3.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[8] { 72, 84, 84, 80, 83, 26, 15, 15 }, 32), StringComparison.OrdinalIgnoreCase);
    }

    private string _0xe800993a = "";
    private IEnumerator _0x453559aa(string _0x6dfdb8f5)
    {
        if (_0x90c4e6b3 != null && _0x50f10967)
            yield break;
        _0x90c4e6b3 = gameObject.AddComponent<UniWebView>();
        _0xbad6e02d(_0x90c4e6b3);
        _0x914c27df(_0x90c4e6b3);
        _0x90c4e6b3.BackgroundColor = Color.clear;
        var _0xab4d84dd = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xdae79662();
        yield return new WaitForEndOfFrame();
        _0x50f10967 = true;
        _0xd1cba629();
        _0xc36f5314(true);
        _0xa9579d39 = false;
        _0xfde1b26d = false;
        _0x604edc9f.Clear();
        _0xd065247f = -1;
        firstLoadShown = false;
        _0x1a32ab93 = false;
        _0x4c04d501 = false;
        _0x90c4e6b3.SetUserAgent("");
        _0x54de2fda = Time.realtimeSinceStartup;
        _0x90c4e6b3.Stop();
        _0x90c4e6b3.Load(_0x6dfdb8f5);
        _0x90c4e6b3.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x08c919e9._0x91bf5dc8(new byte[25] { 210, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 214, 241, 246, 235, 246, 254, 243, 191, 204, 247, 240, 232 }, 159));
    }

    // WS_SOURCE MONO
    public static _0x4c524e80 _0x35714317 { get; private set; }

    // PART 3
    private string _0x1e0115b4()
    {
        try
        {
            var _0x9a880fcf = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[30] { 253, 241, 243, 176, 235, 240, 247, 234, 231, 173, 250, 176, 238, 242, 255, 231, 251, 236, 176, 203, 240, 247, 234, 231, 206, 242, 255, 231, 251, 236 }, 158));
            var _0x188085ac = _0x9a880fcf.GetStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[15] { 163, 181, 178, 178, 165, 174, 180, 129, 163, 180, 169, 182, 169, 180, 185 }, 192));
            var _0xe6ff0e2c = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[57] { 128, 140, 142, 205, 132, 140, 140, 132, 143, 134, 205, 130, 141, 135, 145, 140, 138, 135, 205, 132, 142, 144, 205, 130, 135, 144, 205, 138, 135, 134, 141, 151, 138, 133, 138, 134, 145, 205, 162, 135, 149, 134, 145, 151, 138, 144, 138, 141, 132, 170, 135, 160, 143, 138, 134, 141, 151 }, 227));
            var _0xcfa06bca = _0xe6ff0e2c.CallStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[20] { 229, 231, 246, 195, 230, 244, 231, 240, 246, 235, 241, 235, 236, 229, 203, 230, 203, 236, 228, 237 }, 130), _0x188085ac);
            var _0xa96d23ca = _0xcfa06bca.Call<string>(_0x08c919e9._0x91bf5dc8(new byte[5] { 81, 83, 66, 127, 82 }, 54));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xa96d23ca}");
#endif
            }

            return string.IsNullOrEmpty(_0xa96d23ca) ? "" : _0xa96d23ca;
        }
        catch
        {
            return "";
        }
    }

    private string _0xa97ec193;
    private string _0x86a1dbfb = "";
    private IEnumerator _0xdfc2714d()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    internal Vector2 lastSize = Vector2.zero;
    private string _0x5c9f5855 = "";
    private string _0x0826489b = "";
    private bool _0x94574494()
    {
        if (_0x35934dec())
            return true;
        if (_0x90c4e6b3 != null && _0x90c4e6b3.CanGoBack)
        {
            WLog(_0x08c919e9._0x91bf5dc8(new byte[36] { 17, 56, 43, 61, 46, 56, 43, 60, 121, 59, 56, 58, 50, 121, 116, 103, 121, 52, 56, 48, 55, 121, 14, 60, 59, 15, 48, 60, 46, 121, 30, 54, 27, 56, 58, 50 }, 89));
            _0x90c4e6b3.GoBack();
            return true;
        }

        return false;
    }

    private bool _0x6b018350()
    {
        var _0x5ef47ab6 = Keyboard.current;
        return _0x5ef47ab6 != null && _0x5ef47ab6.escapeKey.wasPressedThisFrame;
    }

    private IEnumerator _0xfbe4ae2c(Dictionary<string, object> _0x3839c608)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[30] { 38, 41, 24, 14, 9, 32, 93, 59, 24, 9, 30, 21, 93, 56, 5, 9, 15, 28, 93, 45, 8, 14, 21, 93, 57, 28, 9, 28, 71, 93 }, 125) + string.Join(_0x08c919e9._0x91bf5dc8(new byte[1] { 193 }, 200), _0x3839c608));
#endif
            }
        }

        string _0xced84666 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x3839c608 != null && _0x3839c608.TryGetValue(_0x08c919e9._0x91bf5dc8(new byte[16] { 71, 70, 93, 64, 79, 64, 74, 72, 93, 64, 70, 71, 109, 72, 93, 72 }, 41), out var raw))
        {
            try
            {
                var _0x2934221f = raw?.ToString();
                var _0x35f472de = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x2934221f);
                if (_0x35f472de != null && _0x35f472de.TryGetValue(_0x08c919e9._0x91bf5dc8(new byte[6] { 48, 38, 45, 39, 42, 39 }, 67), out var val))
                {
                    _0xced84666 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x08c919e9._0x91bf5dc8(new byte[30] { 30, 17, 32, 54, 49, 101, 21, 48, 54, 45, 24, 101, 15, 22, 10, 11, 101, 53, 36, 55, 54, 32, 101, 32, 55, 55, 42, 55, 127, 101 }, 69) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xced84666) && _0x3839c608 != null && _0x3839c608.TryGetValue(_0x08c919e9._0x91bf5dc8(new byte[6] { 125, 107, 96, 106, 103, 106 }, 14), out var lab))
        {
            _0xced84666 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[38] { 237, 226, 211, 197, 194, 150, 230, 195, 197, 222, 235, 150, 240, 211, 194, 213, 222, 211, 210, 150, 197, 211, 216, 210, 223, 210, 150, 208, 196, 217, 219, 150, 220, 197, 217, 216, 140, 150 }, 182) + _0xced84666);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xced84666))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[38] { 200, 199, 246, 224, 231, 179, 195, 230, 224, 251, 206, 179, 196, 242, 250, 231, 179, 231, 252, 179, 252, 227, 246, 253, 179, 228, 250, 231, 251, 179, 224, 246, 253, 247, 250, 247, 169, 179 }, 147) + _0xced84666);
            }
#endif
        }

        _0xa97ec193 = _0xced84666;
        yield return new WaitUntil(() => _0x50f10967);
        var _0xa6014e24 = _0xfcb5b3d9(2, 100);
        yield return new WaitUntil(() => _0xa6014e24.IsCompleted);
        string _0x5c35f022 = _0xa6014e24.Result;
        if (!string.IsNullOrEmpty(_0x5c35f022))
        {
            string _0xf1ca483a = _0x15207161(_0x5c35f022, _0xced84666);
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[33] { 60, 51, 2, 20, 19, 71, 55, 18, 20, 15, 58, 71, 53, 2, 11, 8, 6, 3, 71, 48, 2, 5, 49, 14, 2, 16, 71, 16, 14, 19, 15, 93, 71 }, 103) + _0xf1ca483a);
#endif
            }

            _0x90c4e6b3.Load(_0xf1ca483a);
        }
    }

    internal Button _0x5d5a1d3e(string _0xdef8ec99, Transform _0xbc919ce0)
    {
        var _0xb4fcea1d = new GameObject(_0xdef8ec99 + _0x08c919e9._0x91bf5dc8(new byte[3] { 26, 44, 54 }, 88), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xaf602f27 = _0xb4fcea1d.GetComponent<RectTransform>();
        _0xaf602f27.SetParent(_0xbc919ce0, false);
        var _0xa3b2e30f = _0xb4fcea1d.GetComponent<Image>();
        _0xa3b2e30f.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xba0fe773 = _0xb4fcea1d.GetComponent<Button>();
        var _0xad97919d = _0xba0fe773.colors;
        _0xad97919d.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xad97919d.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xba0fe773.colors = _0xad97919d;
        var _0x6b88f205 = new GameObject(_0x08c919e9._0x91bf5dc8(new byte[4] { 211, 226, 255, 243 }, 135), typeof(RectTransform), typeof(Text));
        var _0x4b10b5e2 = _0x6b88f205.GetComponent<RectTransform>();
        _0x4b10b5e2.SetParent(_0xb4fcea1d.transform, false);
        _0x4b10b5e2.anchorMin = Vector2.zero;
        _0x4b10b5e2.anchorMax = Vector2.one;
        _0x4b10b5e2.offsetMin = _0x4b10b5e2.offsetMax = Vector2.zero;
        var _0xe9ac3bbe = _0x6b88f205.GetComponent<Text>();
        _0xe9ac3bbe.text = _0xdef8ec99;
        _0xe9ac3bbe.alignment = TextAnchor.MiddleCenter;
        _0xe9ac3bbe.color = Color.black;
        _0xe9ac3bbe.font = Resources.GetBuiltinResource<Font>(_0x08c919e9._0x91bf5dc8(new byte[9] { 241, 194, 217, 209, 220, 158, 196, 196, 214 }, 176));
        _0xe9ac3bbe.fontSize = 28;
        WLog(_0x08c919e9._0x91bf5dc8(new byte[14] { 226, 211, 196, 192, 213, 196, 227, 212, 213, 213, 206, 207, 129, 134 }, 161) + _0xdef8ec99 + _0x08c919e9._0x91bf5dc8(new byte[1] { 226 }, 197));
        return _0xba0fe773;
    }

    private int _0xeb5285c3 = 0;
    public void _0x7940be07()
    {
        if (_0x50f10967)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[33] { 4, 11, 58, 44, 43, 2, 127, 11, 54, 50, 58, 45, 127, 48, 42, 43, 127, 114, 97, 127, 50, 48, 41, 58, 127, 43, 48, 127, 44, 60, 58, 49, 58 }, 95));
            }
#endif
        }

        _0xf5c3f882();
    }

    // WEB VIEW LOGIC
    public bool _0x50f10967 { get; set; }

    private bool _0x1a32ab93 = false;
    private string _0x85f27199 = "";
    private bool _0x35934dec()
    {
        var _0x5d36da42 = _0x8405eb15();
        if (_0x5d36da42 == null)
            return false;
        WLog(_0x08c919e9._0x91bf5dc8(new byte[31] { 8, 33, 50, 36, 55, 33, 50, 37, 96, 34, 33, 35, 43, 96, 109, 126, 96, 48, 47, 48, 53, 48, 96, 7, 47, 2, 33, 35, 43, 122, 96 }, 64) + _0x5d36da42.Id);
        _0x5d36da42.GoBack();
        return true;
    }

    private string _0xa7782ed4 = "";
    private void _0x95519c50(string _0xae454bd2)
    {
        Dictionary<string, object> _0xa684765a;
        try
        {
            _0xa684765a = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xae454bd2);
        }
        catch
        {
            return;
        }

        var _0x68fbb2d5 = ReadPushField(_0xa684765a, _0x08c919e9._0x91bf5dc8(new byte[3] { 254, 249, 231 }, 139));
        if (string.IsNullOrWhiteSpace(_0x68fbb2d5))
            return;
        _0x68fbb2d5 = _0x68fbb2d5.Trim();
        if (!IsHttpUrl(_0x68fbb2d5))
            return;
        if (string.Equals(_0x68fbb2d5, _0x586e4c4f, StringComparison.Ordinal))
            return;
        _0x586e4c4f = _0x68fbb2d5;
        OpenUrlExternally(_0x68fbb2d5);
    }

    private Canvas _0x901f2514;
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0x5b667c52)
    {
        if (Permission.HasUserAuthorizedPermission(_0x5b667c52))
            yield break;
        bool _0xdd9a8c52 = false;
        var _0x44ba55b4 = new PermissionCallbacks();
        _0x44ba55b4.PermissionGranted += _0x3769391d => _0xdd9a8c52 = true;
        _0x44ba55b4.PermissionDenied += _0x3769391d => _0xdd9a8c52 = true;
        Permission.RequestUserPermission(_0x5b667c52, _0x44ba55b4);
        yield return new WaitUntil(() => _0xdd9a8c52);
    }

    private void _0x5a101ac4()
    {
        WLog(_0x08c919e9._0x91bf5dc8(new byte[21] { 177, 152, 139, 157, 142, 152, 139, 156, 217, 155, 152, 154, 146, 217, 137, 139, 156, 138, 138, 156, 157 }, 249));
        if (Time.frameCount == _0xd065247f)
            return;
        _0xd065247f = Time.frameCount;
        if (_0x94574494())
            return;
        _0xbf8161bd();
    }

    private async Task<string> _0xfcb5b3d9(int _0x4d073a72 = 5, int _0xfb05715d = 500)
    {
        try
        {
            List<EntityData> _0xd652e7a4 = new List<EntityData>();
            int _0x6c39ed73 = 0;
            do
            {
                _0xd652e7a4 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x08c919e9._0x91bf5dc8(new byte[8] { 153, 133, 136, 144, 140, 155, 160, 141 }, 233), _0x86a1dbfb, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x86a1dbfb }), new QueryOptions())).ToList();
                await Task.Delay(_0xfb05715d);
            }
            while (_0xd652e7a4.Count == 0 && _0x6c39ed73++ < _0x4d073a72);
            {
#if B_LOGS
                {
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[33] { 30, 17, 32, 54, 49, 24, 101, 22, 36, 51, 32, 33, 101, 9, 44, 43, 46, 101, 20, 48, 32, 55, 60, 101, 55, 32, 54, 48, 41, 49, 54, 127, 101 }, 69) + JsonConvert.SerializeObject(_0xd652e7a4, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[39] { 61, 50, 3, 21, 18, 59, 70, 53, 7, 16, 3, 2, 70, 42, 15, 8, 13, 70, 55, 19, 3, 20, 31, 70, 20, 3, 21, 19, 10, 18, 21, 70, 5, 9, 19, 8, 18, 92, 70 }, 102) + _0xd652e7a4.Count);
                }
#endif
            }

            var _0xe1929b1d = _0xd652e7a4.SelectMany(_0x83ed1e47 => _0x83ed1e47.Data).FirstOrDefault(_0x170f7657 => _0x170f7657.Key == _0x86a1dbfb)?.Value.GetAs<string>() ?? string.Empty;
            _0xe1929b1d = Decrypt(_0xe1929b1d, _0x86a1dbfb);
            {
#if B_LOGS
                {
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[24] { 179, 188, 141, 155, 156, 181, 200, 164, 135, 137, 140, 200, 155, 137, 158, 141, 140, 200, 132, 129, 134, 131, 210, 200 }, 232) + _0xe1929b1d);
                }
#endif
            }

            return _0xe1929b1d;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[39] { 106, 101, 84, 66, 69, 108, 17, 118, 84, 69, 17, 94, 67, 17, 65, 80, 67, 66, 84, 17, 66, 80, 71, 84, 85, 17, 93, 88, 95, 90, 17, 87, 80, 88, 93, 84, 85, 11, 17 }, 49) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private void OnApplicationPause(bool _0x15e6ef44)
    {
        isApplicationPause = _0x15e6ef44;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x3ee4111c()
    {
        var _0x8155adb7 = _0x08c919e9._0x91bf5dc8(new byte[40] { 54, 42, 42, 46, 45, 100, 113, 113, 41, 41, 41, 112, 61, 50, 49, 43, 58, 56, 50, 63, 44, 59, 112, 61, 49, 51, 113, 61, 58, 48, 115, 61, 57, 55, 113, 42, 44, 63, 61, 59 }, 94);
        using (UnityWebRequest _0xb89be760 = UnityWebRequest.Get(_0x8155adb7))
        {
            await _0xb89be760.SendWebRequest();
            string[] _0xa8c78311 = _0xb89be760.downloadHandler.text.Split('\n');
            foreach (string _0x07052b41 in _0xa8c78311)
            {
                if (_0x07052b41.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[3] { 24, 1, 76 }, 113)))
                {
                    string _0x5f354412 = _0x07052b41.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x5f354412} from {_0x8155adb7}");
                        }
#endif
                    }

                    return _0x5f354412;
                }
            }
        }

        return "";
    }

    private float _0x54de2fda = 0f;
    internal bool firstLoadShown = false;
    private bool _0x900757e4()
    {
        _0x604edc9f.RemoveAll(_0x156996f5 => _0x156996f5 == null || !_0x156996f5.IsAlive);
        return _0x604edc9f.Count > 0;
    }

    private string _0x639b009f = "";
    private string _0xdd56983f = "";
    private string _0x850573ad = "";
    private string _0x586e4c4f;
    private bool OpenUrlExternally(string _0xdb37cba8)
    {
        return _0x860165dd(_0xdb37cba8);
    }

    private async Task<bool> _0x2ea0ece2()
    {
        {
#if B_LOGS
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[37] { 153, 150, 167, 177, 182, 159, 226, 145, 171, 165, 172, 139, 172, 151, 172, 171, 182, 187, 145, 167, 176, 180, 171, 161, 167, 177, 131, 172, 173, 172, 187, 175, 173, 183, 177, 174, 187 }, 194));
#endif
        }

        try
        {
            var _0x22a5f8c6 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x22a5f8c6);
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[32] { 61, 50, 3, 21, 18, 59, 70, 51, 8, 15, 18, 31, 53, 3, 20, 16, 15, 5, 3, 21, 70, 47, 8, 15, 18, 15, 7, 10, 15, 28, 3, 2 }, 102));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[20] { 127, 110, 120, 127, 11, 126, 69, 66, 95, 82, 120, 78, 89, 93, 66, 72, 78, 88, 17, 11 }, 43) + ex.Message);
#endif
            }

            _0x35714317?._0xf5c3f882();
            return true;
        }

        bool _0xaa4d9acd = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xaa4d9acd = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[37] { 222, 209, 224, 246, 241, 216, 165, 214, 236, 226, 235, 168, 236, 235, 165, 196, 235, 234, 235, 252, 232, 234, 240, 246, 171, 165, 213, 233, 228, 252, 224, 247, 165, 204, 193, 191, 165 }, 133) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x86a1dbfb = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[25] { 191, 174, 184, 191, 203, 184, 130, 140, 133, 198, 130, 133, 203, 170, 158, 159, 131, 203, 174, 185, 185, 164, 185, 209, 203 }, 235) + ex.Message);
#endif
                }

                _0x35714317?._0xf5c3f882();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[28] { 132, 149, 131, 132, 240, 131, 185, 183, 190, 253, 185, 190, 240, 130, 181, 161, 165, 181, 163, 164, 240, 149, 130, 130, 159, 130, 234, 240 }, 208) + ex.Message);
#endif
                }

                _0x35714317?._0xf5c3f882();
                return true;
            }
        }
        while (!_0xaa4d9acd);
        return false;
    }

    private bool _0xa9579d39 = false;
    private string _0xa4f6534c = "";
    private JObject BuildRandomPayload(params string[] _0xb182d61a)
    {
        JObject _0x9e5e5ae1 = new JObject();
        foreach (var _0x8e69cb4e in _0xb182d61a)
        {
            string _0x95f00b45 = _0xa7daa412();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x95f00b45} val={_0x8e69cb4e}");
#endif
            }

            _0x9e5e5ae1.Add(_0x95f00b45, _0x8e69cb4e == null ? "" : _0x8e69cb4e);
        }

        return _0x9e5e5ae1;
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x1cfdaecf(string _0x45cfe2dd, string _0x60d79a41)
    {
        try
        {
            using var _0x6d9a835c = Aes.Create();
            _0x6d9a835c.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x60d79a41));
            _0x6d9a835c.GenerateIV();
            using var _0xe91fd8f4 = new MemoryStream();
            _0xe91fd8f4.Write(_0x6d9a835c.IV, 0, _0x6d9a835c.IV.Length);
            using (var _0xf612b9ef = new CryptoStream(_0xe91fd8f4, _0x6d9a835c.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xbaaec891 = Encoding.UTF8.GetBytes(_0x45cfe2dd);
                _0xf612b9ef.Write(_0xbaaec891, 0, _0xbaaec891.Length);
                _0xf612b9ef.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xe91fd8f4.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private readonly string[] _0x458636e2 = new string[]
    {
        _0x08c919e9._0x91bf5dc8(new byte[60] { 125, 18, 3, 61, 173, 217, 229, 232, 173, 255, 232, 232, 225, 254, 173, 236, 255, 232, 173, 229, 226, 249, 173, 255, 228, 234, 229, 249, 173, 227, 226, 250, 173, 111, 13, 30, 173, 233, 226, 227, 111, 13, 20, 249, 173, 224, 228, 254, 254, 173, 244, 226, 248, 255, 173, 254, 253, 228, 227, 172 }, 141),
        _0x08c919e9._0x91bf5dc8(new byte[52] { 104, 7, 21, 24, 184, 209, 236, 184, 251, 247, 237, 244, 252, 184, 250, 253, 184, 225, 247, 237, 234, 184, 244, 237, 251, 243, 225, 184, 245, 247, 245, 253, 246, 236, 184, 122, 24, 11, 184, 239, 240, 225, 184, 235, 236, 247, 232, 184, 246, 247, 239, 167 }, 152),
        _0x08c919e9._0x91bf5dc8(new byte[66] { 177, 201, 242, 188, 235, 220, 115, 17, 58, 52, 115, 36, 58, 61, 32, 115, 50, 33, 54, 115, 59, 58, 39, 39, 58, 61, 52, 115, 62, 60, 33, 54, 115, 60, 53, 39, 54, 61, 115, 39, 60, 55, 50, 42, 115, 177, 211, 192, 115, 32, 39, 50, 42, 115, 58, 61, 115, 39, 59, 54, 115, 52, 50, 62, 54, 125 }, 83),
        _0x08c919e9._0x91bf5dc8(new byte[54] { 226, 141, 135, 128, 50, 70, 122, 123, 97, 50, 123, 97, 50, 98, 96, 123, 127, 119, 50, 102, 123, 127, 119, 50, 240, 146, 129, 50, 102, 122, 119, 50, 112, 119, 97, 102, 50, 98, 126, 115, 107, 119, 96, 97, 50, 98, 126, 115, 107, 50, 124, 125, 101, 60 }, 18),
        _0x08c919e9._0x91bf5dc8(new byte[48] { 41, 70, 77, 124, 249, 128, 182, 172, 171, 249, 174, 176, 183, 183, 176, 183, 190, 249, 170, 173, 171, 188, 184, 178, 249, 186, 182, 172, 181, 189, 249, 187, 188, 249, 182, 183, 188, 249, 170, 169, 176, 183, 249, 184, 174, 184, 160, 247 }, 217),
        _0x08c919e9._0x91bf5dc8(new byte[65] { 227, 140, 137, 147, 51, 89, 114, 112, 120, 99, 124, 103, 96, 51, 114, 97, 118, 51, 126, 124, 97, 118, 51, 114, 112, 103, 122, 101, 118, 51, 103, 124, 125, 122, 116, 123, 103, 51, 241, 147, 128, 51, 96, 103, 114, 106, 51, 114, 125, 119, 51, 103, 97, 106, 51, 106, 124, 102, 97, 51, 127, 102, 112, 120, 61 }, 19),
        _0x08c919e9._0x91bf5dc8(new byte[55] { 4, 107, 122, 70, 212, 177, 130, 145, 134, 141, 212, 135, 132, 157, 154, 212, 151, 155, 129, 154, 128, 135, 212, 22, 116, 103, 212, 128, 156, 145, 212, 154, 145, 140, 128, 212, 155, 154, 145, 212, 151, 155, 129, 152, 144, 212, 150, 145, 212, 141, 155, 129, 134, 135, 218 }, 244),
        _0x08c919e9._0x91bf5dc8(new byte[63] { 59, 116, 73, 54, 97, 86, 249, 137, 181, 184, 160, 188, 171, 170, 249, 171, 176, 190, 177, 173, 249, 183, 182, 174, 249, 184, 171, 188, 249, 174, 176, 183, 183, 176, 183, 190, 249, 59, 89, 74, 249, 189, 182, 183, 59, 89, 64, 173, 249, 174, 184, 181, 178, 249, 184, 174, 184, 160, 249, 160, 188, 173, 247 }, 217),
        _0x08c919e9._0x91bf5dc8(new byte[51] { 150, 249, 233, 224, 70, 41, 8, 10, 31, 70, 18, 14, 9, 21, 3, 70, 17, 14, 9, 70, 21, 18, 7, 31, 70, 15, 8, 70, 18, 14, 3, 70, 1, 7, 11, 3, 70, 17, 15, 8, 70, 18, 14, 3, 70, 22, 20, 15, 28, 3, 72 }, 102),
        _0x08c919e9._0x91bf5dc8(new byte[64] { 126, 6, 61, 115, 36, 19, 188, 209, 243, 241, 249, 242, 232, 233, 241, 188, 245, 239, 188, 249, 234, 249, 238, 229, 232, 244, 245, 242, 251, 188, 126, 28, 15, 188, 247, 249, 249, 236, 188, 239, 236, 245, 242, 242, 245, 242, 251, 188, 250, 243, 238, 188, 229, 243, 233, 238, 188, 255, 244, 253, 242, 255, 249, 178 }, 156)
    };
    internal bool IsGoogleAuthFlowUrl(string _0x1e0d0482)
    {
        if (string.IsNullOrEmpty(_0x1e0d0482))
            return false;
        return _0x1e0d0482.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[19] { 24, 26, 26, 22, 12, 23, 13, 10, 87, 30, 22, 22, 30, 21, 28, 87, 26, 22, 20 }, 121), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1e0d0482.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[16] { 68, 70, 70, 74, 80, 75, 81, 86, 11, 66, 74, 74, 66, 73, 64, 11 }, 37), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1e0d0482.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[21] { 68, 76, 76, 68, 79, 70, 86, 80, 70, 81, 64, 76, 77, 87, 70, 77, 87, 13, 64, 76, 78 }, 35), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1e0d0482.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[11] { 170, 190, 185, 172, 185, 164, 174, 227, 174, 162, 160 }, 205), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private ApplicationInstallMode _0x62ee409a = ApplicationInstallMode.Unknown;
    private void _0xbad6e02d(UniWebView _0xf7c60ac1)
    {
        _0xf7c60ac1.BackgroundColor = Color.clear;
        _0xf7c60ac1.SetSupportMultipleWindows(true, true);
        _0xf7c60ac1.SetBackButtonEnabled(false);
        _0x90c4e6b3.SetUserAgent(_0x6af4a5db());
    }

    internal bool _0xe86daa66(string _0x9138fa7a)
    {
        return _0x9138fa7a.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[9] { 45, 33, 50, 43, 37, 52, 122, 111, 111 }, 64), StringComparison.OrdinalIgnoreCase) || _0x9138fa7a.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[24] { 231, 251, 251, 255, 252, 181, 160, 160, 255, 227, 238, 246, 161, 232, 224, 224, 232, 227, 234, 161, 236, 224, 226, 160 }, 143), StringComparison.OrdinalIgnoreCase) || _0x9138fa7a.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[23] { 50, 46, 46, 42, 96, 117, 117, 42, 54, 59, 35, 116, 61, 53, 53, 61, 54, 63, 116, 57, 53, 55, 117 }, 90), StringComparison.OrdinalIgnoreCase);
    }

    internal string _0x5bc9b8c6(string _0xbacaa710)
    {
        int _0x06714eda = _0xbacaa710.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[3] { 41, 36, 125 }, 64), StringComparison.OrdinalIgnoreCase);
        if (_0x06714eda < 0)
            return null;
        string _0x47a8e509 = _0xbacaa710.Substring(_0x06714eda + 3);
        int _0x70099d7f = _0x47a8e509.IndexOf('&');
        return _0x70099d7f >= 0 ? _0x47a8e509.Substring(0, _0x70099d7f) : _0x47a8e509;
    }

    private IEnumerator _0x9ec47673()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[26] { 5, 10, 59, 45, 42, 3, 126, 23, 48, 55, 42, 55, 63, 50, 55, 36, 59, 12, 59, 56, 56, 59, 44, 59, 44, 126 }, 94));
            }
#endif
        }

        bool _0xa01db32e = false;
        InstallReferrer.GetReferrer((_0xdd5810ab) =>
        {
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[24] { 110, 97, 80, 70, 65, 21, 103, 80, 83, 80, 71, 71, 80, 71, 104, 21, 82, 80, 65, 21, 215, 179, 167, 21 }, 53) + _0x23bd041d);
            if (_0xdd5810ab.IsSuccess)
            {
                _0x23bd041d = _0xdd5810ab.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[28] { 178, 189, 140, 154, 157, 201, 187, 140, 143, 140, 155, 155, 140, 155, 180, 201, 186, 156, 138, 138, 140, 154, 154, 201, 11, 111, 123, 201 }, 233) + _0x23bd041d);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[27] { 204, 195, 242, 228, 227, 183, 197, 242, 241, 242, 229, 229, 242, 229, 202, 183, 209, 246, 254, 251, 242, 243, 183, 117, 17, 5, 183 }, 151) + _0xdd5810ab);
#endif
                }

                _0x23bd041d = "";
            }

            _0x76345e79 = true;
        });
        StartCoroutine(_0xcd40ff44(2f));
        yield return new WaitUntil(() => _0x76345e79);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x23bd041d}");
#endif
        }

        bool _0x9bd06071 = _0x23bd041d.Contains(_0x08c919e9._0x91bf5dc8(new byte[6] { 151, 147, 156, 153, 148, 205 }, 240));
        _0xa01db32e = _0x9bd06071 || _0x23bd041d.Contains(_0x08c919e9._0x91bf5dc8(new byte[18] { 147, 130, 130, 129, 220, 155, 156, 129, 134, 147, 149, 128, 147, 159, 220, 145, 157, 159 }, 242)) || _0x23bd041d.Contains(_0x08c919e9._0x91bf5dc8(new byte[17] { 242, 227, 227, 224, 189, 245, 242, 240, 246, 241, 252, 252, 248, 189, 240, 252, 254 }, 147));
        _0xb2194921 = _0x9bd06071 ? "" : (_0xa01db32e ? "" : _0xb2194921);
        _0xb2194921 = _0xb2194921 ?? "";
        _0x6fb7628c = _0x6fb7628c ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xb2194921}");
#endif
        }
    }

    private bool _0x5cc8deaf(int _0x0514c057, string _0x5d422c8b, string _0xa5f15b82)
    {
        if (string.IsNullOrEmpty(_0xa5f15b82))
            return false;
        if (!IsHttpUrl(_0xa5f15b82))
            return true;
        if (string.IsNullOrEmpty(_0x5d422c8b))
            return false;
        return _0x5d422c8b.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[20] { 221, 202, 202, 199, 219, 215, 214, 214, 221, 219, 204, 209, 215, 214, 199, 202, 221, 203, 221, 204 }, 152), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5d422c8b.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[22] { 143, 152, 152, 149, 137, 133, 132, 132, 143, 137, 158, 131, 133, 132, 149, 152, 143, 140, 159, 153, 143, 142 }, 202), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5d422c8b.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[21] { 148, 131, 131, 142, 146, 158, 159, 159, 148, 146, 133, 152, 158, 159, 142, 146, 157, 158, 130, 148, 149 }, 209), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5d422c8b.IndexOf(_0x08c919e9._0x91bf5dc8(new byte[22] { 196, 211, 211, 222, 212, 207, 202, 207, 206, 214, 207, 222, 212, 211, 205, 222, 210, 194, 201, 196, 204, 196 }, 129), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task _0x070455c9()
    {
        if (await _0x2ea0ece2())
            return;
        if (await _0x22d0616b())
            return;
        if (await _0xd5b107da())
            return;
        _0xc2046f9b();
        await _0xa1b9d1b6(_0x9ec47673());
        _0x850573ad = await _0x3ee4111c();
        await _0xd507b05d();
    }

    // MAIN FLOW
    private bool _0x76345e79 { get; set; }

    internal bool ContainsIgnoreCase(string _0xb0390645, string _0x941cbcd9)
    {
        if (string.IsNullOrEmpty(_0xb0390645) || string.IsNullOrEmpty(_0x941cbcd9))
            return false;
        return _0xb0390645.IndexOf(_0x941cbcd9, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x860165dd(string _0x84e600cb)
    {
        try
        {
            using (var _0x7dfd03cc = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[30] { 197, 201, 203, 136, 211, 200, 207, 210, 223, 149, 194, 136, 214, 202, 199, 223, 195, 212, 136, 243, 200, 207, 210, 223, 246, 202, 199, 223, 195, 212 }, 166)))
            using (var _0x97f8ee67 = _0x7dfd03cc.GetStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[15] { 239, 249, 254, 254, 233, 226, 248, 205, 239, 248, 229, 250, 229, 248, 245 }, 140)))
            using (var _0x2b1d3144 = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[15] { 110, 97, 107, 125, 96, 102, 107, 33, 97, 106, 123, 33, 90, 125, 102 }, 15)))
            using (var _0x447cc8bb = _0x2b1d3144.CallStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[5] { 10, 27, 8, 9, 31 }, 122), _0x84e600cb))
            using (var _0x39b716bf = new AndroidJavaObject(_0x08c919e9._0x91bf5dc8(new byte[22] { 230, 233, 227, 245, 232, 238, 227, 169, 228, 232, 233, 243, 226, 233, 243, 169, 206, 233, 243, 226, 233, 243 }, 135), _0x08c919e9._0x91bf5dc8(new byte[26] { 152, 151, 157, 139, 150, 144, 157, 215, 144, 151, 141, 156, 151, 141, 215, 152, 154, 141, 144, 150, 151, 215, 175, 176, 188, 174 }, 249), _0x447cc8bb))
            {
                WLog(_0x08c919e9._0x91bf5dc8(new byte[26] { 90, 113, 107, 118, 116, 124, 85, 112, 114, 124, 57, 118, 105, 124, 119, 57, 124, 97, 109, 124, 107, 119, 120, 117, 35, 57 }, 25) + _0x84e600cb);
                _0x39b716bf.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[11] { 46, 43, 43, 12, 46, 59, 42, 40, 32, 61, 54 }, 79), _0x08c919e9._0x91bf5dc8(new byte[33] { 210, 221, 215, 193, 220, 218, 215, 157, 218, 221, 199, 214, 221, 199, 157, 208, 210, 199, 214, 212, 220, 193, 202, 157, 241, 225, 252, 228, 224, 242, 241, 255, 246 }, 179));
                _0x39b716bf.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[8] { 228, 225, 225, 195, 233, 228, 226, 246 }, 133), 0x10000000);
                _0x97f8ee67.Call(_0x08c919e9._0x91bf5dc8(new byte[13] { 93, 90, 79, 92, 90, 111, 77, 90, 71, 88, 71, 90, 87 }, 46), _0x39b716bf);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x08c919e9._0x91bf5dc8(new byte[28] { 213, 254, 228, 249, 251, 243, 218, 255, 253, 243, 182, 243, 238, 226, 243, 228, 248, 247, 250, 182, 240, 247, 255, 250, 243, 242, 172, 182 }, 150) + e.Message);
            Application.OpenURL(_0x84e600cb);
            return true;
        }
    }

    private async Task<bool> _0x22d0616b()
    {
        _0x316d6555.Instance?._0x361cbff0();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xfd741fd3) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[32] { 122, 117, 68, 82, 85, 124, 1, 116, 79, 72, 85, 88, 1, 113, 84, 82, 73, 1, 111, 78, 85, 72, 71, 72, 66, 64, 85, 72, 78, 79, 27, 1 }, 33) + string.Join(_0x08c919e9._0x91bf5dc8(new byte[1] { 141 }, 132), _0xfd741fd3));
                }
#endif
            }
        };
        try
        {
            _0x8d7ec24b = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[31] { 252, 243, 194, 212, 211, 250, 135, 225, 198, 206, 203, 194, 195, 135, 211, 200, 135, 192, 194, 211, 135, 215, 210, 212, 207, 135, 211, 200, 204, 194, 201 }, 167));
                }
#endif
            }

            _0x8d7ec24b = "";
        }

        _0x78a8460d = !string.IsNullOrEmpty(_0x8d7ec24b);
        _0xf6617cda = _0x421ba63f();
        {
#if B_LOGS
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[25] { 183, 184, 137, 159, 152, 177, 204, 185, 130, 133, 152, 149, 204, 188, 153, 159, 132, 204, 184, 131, 135, 137, 130, 214, 204 }, 236) + _0x8d7ec24b);
#endif
        }

        _0x316d6555.Instance?._0xd9392bea();
        return false;
    }

    private async Task _0x93abf5b2(string _0x3ab5fa16)
    {
        if (_0x11a5fad1 || string.IsNullOrEmpty(_0x86a1dbfb) || string.IsNullOrEmpty(_0x3ab5fa16) || _0x920c8147)
            return;
        _0x11a5fad1 = true;
        try
        {
            JObject _0x986cfab8 = BuildRandomPayload(_0x3ab5fa16, _0x86a1dbfb, _0x421ba63f());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x3ab5fa16} payload: {_0x986cfab8}");
                }
#endif
            }

            var _0x5b570d00 = _0x1cfdaecf(_0x986cfab8.ToString(), _0x86a1dbfb);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x08c919e9._0x91bf5dc8(new byte[4] { 168, 171, 165, 160 }, 196) + _0x86a1dbfb, _0x5b570d00 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[24] { 85, 90, 75, 93, 90, 83, 46, 66, 97, 111, 106, 46, 126, 111, 125, 125, 46, 107, 124, 124, 97, 124, 52, 46 }, 14) + e.Message);
#endif
            }
        }
    }

    private async void Start()
    {
        await _0x070455c9();
    }

    private string _0x1536d59e = "";
    private string _0xbdec98ab = "";
    private bool _0x11a5fad1 = false;
    private bool _0x4c04d501 = false;
    private void Awake()
    {
        if (_0x35714317 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x35714317 = gameObject.GetComponent<_0x4c524e80>();
        DontDestroyOnLoad(gameObject);
        _0x8d7ec24b = _0xb2194921 = _0x6fb7628c = "";
        _0x639b009f = "";
        _0x50f10967 = false;
    }

    internal bool isApplicationFocus = false;
    private UniWebViewPopup _0x8405eb15()
    {
        for (int _0x2d90c31b = _0x604edc9f.Count - 1; _0x2d90c31b >= 0; _0x2d90c31b--)
        {
            var _0xba5bc046 = _0x604edc9f[_0x2d90c31b];
            if (_0xba5bc046 != null && _0xba5bc046.IsAlive)
                return _0xba5bc046;
            _0x604edc9f.RemoveAt(_0x2d90c31b);
        }

        return null;
    }

    private Action _0xa677d803;
    private Text _0x4d1d589f;
    private static readonly string WindowsDesktopUserAgent = _0x08c919e9._0x91bf5dc8(new byte[111] { 221, 255, 234, 249, 252, 252, 241, 191, 165, 190, 160, 176, 184, 199, 249, 254, 244, 255, 231, 227, 176, 222, 196, 176, 161, 160, 190, 160, 171, 176, 199, 249, 254, 166, 164, 171, 176, 232, 166, 164, 185, 176, 209, 224, 224, 252, 245, 199, 245, 242, 219, 249, 228, 191, 165, 163, 167, 190, 163, 166, 176, 184, 219, 216, 196, 221, 220, 188, 176, 252, 249, 251, 245, 176, 215, 245, 243, 251, 255, 185, 176, 211, 248, 226, 255, 253, 245, 191, 161, 162, 160, 190, 160, 190, 160, 190, 160, 176, 195, 241, 246, 241, 226, 249, 191, 165, 163, 167, 190, 163, 166 }, 144);
    private void _0xbf8161bd()
    {
        if (_0x4c04d501)
        {
            WLog(_0x08c919e9._0x91bf5dc8(new byte[18] { 116, 73, 88, 69, 17, 80, 93, 67, 84, 80, 85, 72, 17, 66, 89, 94, 70, 95 }, 49));
            return;
        }

        _0xc36f5314(false);
        WLog(_0x08c919e9._0x91bf5dc8(new byte[46] { 126, 82, 90, 93, 19, 100, 86, 81, 101, 90, 86, 68, 19, 99, 70, 64, 91, 19, 125, 92, 71, 90, 85, 90, 80, 82, 71, 90, 92, 93, 19, 27, 91, 82, 65, 87, 68, 82, 65, 86, 19, 81, 82, 80, 88, 26 }, 51));
        ++_0xeb5285c3;
        _0x59ea865b();
        if (_0xeb5285c3 <= 1)
            return;
        if (_0x900757e4())
        {
            WLog(_0x08c919e9._0x91bf5dc8(new byte[37] { 72, 117, 100, 121, 45, 126, 102, 100, 125, 125, 104, 105, 45, 32, 51, 45, 125, 98, 125, 120, 125, 126, 45, 126, 121, 100, 97, 97, 45, 98, 125, 104, 99, 104, 105, 55, 45 }, 13) + _0x604edc9f.Count);
            return;
        }

        Application.Quit();
    }

    private IEnumerator _0xd107eb60(IEnumerator _0x046011e8, TaskCompletionSource<bool> _0x53d51bcb)
    {
        yield return _0x046011e8;
        _0x53d51bcb.SetResult(true);
    }

    internal Rect lastSafe = Rect.zero;
    private string _0xf6617cda = "";
    private static string ReadPushField(Dictionary<string, object> _0x6adef5df, string _0x68027b1e)
    {
        if (_0x6adef5df == null || string.IsNullOrEmpty(_0x68027b1e))
            return string.Empty;
        if (_0x6adef5df.TryGetValue(_0x08c919e9._0x91bf5dc8(new byte[16] { 135, 134, 157, 128, 143, 128, 138, 136, 157, 128, 134, 135, 173, 136, 157, 136 }, 233), out var raw))
        {
            try
            {
                var _0x9f35035e = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x9f35035e != null && _0x9f35035e.TryGetValue(_0x68027b1e, out var nestedVal))
                {
                    var _0x944b74d1 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x944b74d1))
                        return _0x944b74d1;
                }
            }
            catch
            {
            }
        }

        if (_0x6adef5df.TryGetValue(_0x68027b1e, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0xd7359eb5()
    {
        try
        {
            using (var _0xedd5f6d5 = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[30] { 68, 72, 74, 9, 82, 73, 78, 83, 94, 20, 67, 9, 87, 75, 70, 94, 66, 85, 9, 114, 73, 78, 83, 94, 119, 75, 70, 94, 66, 85 }, 39)))
            {
                var _0x266ad62f = _0xedd5f6d5.GetStatic<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[15] { 212, 194, 197, 197, 210, 217, 195, 246, 212, 195, 222, 193, 222, 195, 206 }, 183));
                var _0x68f99533 = _0x266ad62f.Call<AndroidJavaObject>(_0x08c919e9._0x91bf5dc8(new byte[21] { 130, 128, 145, 164, 149, 149, 137, 140, 134, 132, 145, 140, 138, 139, 166, 138, 139, 145, 128, 157, 145 }, 229));
                using (var _0x4fb247c8 = new AndroidJavaClass(_0x08c919e9._0x91bf5dc8(new byte[26] { 148, 155, 145, 135, 154, 156, 145, 219, 130, 144, 151, 158, 156, 129, 219, 162, 144, 151, 166, 144, 129, 129, 156, 155, 146, 134 }, 245)))
                {
                    return _0x4fb247c8.CallStatic<string>(_0x08c919e9._0x91bf5dc8(new byte[19] { 193, 195, 210, 226, 195, 192, 199, 211, 202, 210, 243, 213, 195, 212, 231, 193, 195, 200, 210 }, 166), _0x68f99533);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private int _0xbe824185 = 5, _0xec7841cb = 5, _0x94701101 = 5, _0xbe188472 = 5;
    private string _0x15207161(string _0x5cedaa8b, string _0xfea45f0e)
    {
        if (string.IsNullOrEmpty(_0xfea45f0e))
            return _0x5cedaa8b;
        if (_0x5cedaa8b.Contains(_0x08c919e9._0x91bf5dc8(new byte[1] { 96 }, 95)))
            return _0x5cedaa8b + _0x08c919e9._0x91bf5dc8(new byte[8] { 91, 14, 24, 19, 25, 20, 25, 64 }, 125) + UnityWebRequest.EscapeURL(_0xfea45f0e);
        else
            return _0x5cedaa8b + _0x08c919e9._0x91bf5dc8(new byte[8] { 125, 49, 39, 44, 38, 43, 38, 127 }, 66) + UnityWebRequest.EscapeURL(_0xfea45f0e);
    }

    private string _0xd72a4674 = "";
    internal bool IsAboutBlank(string _0x355bf11d)
    {
        if (string.IsNullOrEmpty(_0x355bf11d))
            return false;
        return _0x355bf11d.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[11] { 41, 42, 39, 61, 60, 114, 42, 36, 41, 38, 35 }, 72), StringComparison.OrdinalIgnoreCase);
    }

    private string _0xa7daa412()
    {
        string _0xbf6b4eac = _0x08c919e9._0x91bf5dc8(new byte[62] { 69, 70, 71, 64, 65, 66, 67, 76, 77, 78, 79, 72, 73, 74, 75, 84, 85, 86, 87, 80, 81, 82, 83, 92, 93, 94, 101, 102, 103, 96, 97, 98, 99, 108, 109, 110, 111, 104, 105, 106, 107, 116, 117, 118, 119, 112, 113, 114, 115, 124, 125, 126, 20, 21, 22, 23, 16, 17, 18, 19, 28, 29 }, 36);
        System.Random _0xf681107e = new System.Random();
        int _0xb46797a8 = _0xf681107e.Next(8, 16);
        return new string (Enumerable.Repeat(_0xbf6b4eac, _0xb46797a8).Select(_0xabb93ecf => _0xabb93ecf[_0xf681107e.Next(_0xabb93ecf.Length)]).ToArray());
    }

    private bool _0x920c8147 = false;
    internal void Update()
    {
        if (_0x90c4e6b3 == null)
            return;
        if (_0x6b018350())
            _0x5a101ac4();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xdae79662();
        if (_0xac6cc17d && _0x3b0bf83a != null)
            _0x3b0bf83a.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private void _0x43253f12()
    {
        if (_0x90c4e6b3 == null)
            return;
        if (_0xfde1b26d)
            _0x90c4e6b3.SetUserAgent(_0x6af4a5db());
        else
            _0x90c4e6b3.SetUserAgent("");
    }

    private bool _0xac6cc17d = false;
    private Task _0xa1b9d1b6(IEnumerator _0x0632f4ef)
    {
        var _0xaedc80fa = new TaskCompletionSource<bool>();
        StartCoroutine(_0xd107eb60(_0x0632f4ef, _0xaedc80fa));
        return _0xaedc80fa.Task;
    }

    private bool _0xfde1b26d = false;
    private async Task<bool> _0xa95d91ef(int _0x1af97f23 = 5, int _0x21262483 = 500)
    {
        List<EntityData> _0xca552064 = new List<EntityData>();
        int _0x2adc7de6 = 0;
        do
        {
            try
            {
                _0xca552064 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x08c919e9._0x91bf5dc8(new byte[8] { 40, 52, 57, 33, 61, 42, 17, 60 }, 88), _0x86a1dbfb, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x08c919e9._0x91bf5dc8(new byte[9] { 215, 205, 238, 204, 215, 200, 223, 221, 199 }, 190) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[32] { 74, 69, 116, 98, 101, 76, 49, 96, 100, 116, 99, 104, 80, 98, 104, 127, 114, 67, 116, 98, 100, 125, 101, 98, 49, 116, 99, 99, 126, 99, 43, 49 }, 17) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x21262483);
        }
        while (_0xca552064.Count == 0 && _0x2adc7de6++ < _0x1af97f23);
        {
#if B_LOGS
            {
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[32] { 49, 62, 15, 25, 30, 55, 74, 35, 25, 58, 24, 3, 28, 11, 9, 19, 74, 59, 31, 15, 24, 19, 74, 24, 15, 25, 31, 6, 30, 25, 80, 74 }, 106) + JsonConvert.SerializeObject(_0xca552064, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[38] { 241, 254, 207, 217, 222, 247, 138, 227, 217, 250, 216, 195, 220, 203, 201, 211, 138, 251, 223, 207, 216, 211, 138, 216, 207, 217, 223, 198, 222, 217, 138, 201, 197, 223, 196, 222, 144, 138 }, 170) + _0xca552064.Count);
            }
#endif
        }

        bool _0xbf00abe3 = true;
        if (_0xca552064.Count == 0)
        {
            _0xbf00abe3 = false;
        }
        else
        {
            _0xbf00abe3 = _0xca552064.Any(_0x83ed1e47 => _0x83ed1e47.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[25] { 192, 207, 254, 232, 239, 198, 187, 210, 232, 203, 233, 242, 237, 250, 248, 226, 187, 233, 254, 232, 238, 247, 239, 161, 187 }, 155) + _0xbf00abe3);
            }
#endif
        }

        return _0xbf00abe3;
    }

    private bool _0xf757c407(string _0x4d81379a, string _0x3a8160fb)
    {
        string _0x2d9c463f = _0x5bc9b8c6(_0x4d81379a);
        if (string.IsNullOrEmpty(_0x2d9c463f))
            _0x2d9c463f = _0x3a8160fb;
        if (_0x2a28fa6e(_0x2d9c463f))
            return true;
        string _0x7e69bc49 = string.IsNullOrEmpty(_0x2d9c463f) ? _0x08c919e9._0x91bf5dc8(new byte[29] { 187, 167, 167, 163, 160, 233, 252, 252, 163, 191, 178, 170, 253, 180, 188, 188, 180, 191, 182, 253, 176, 188, 190, 252, 160, 167, 188, 161, 182 }, 211) : _0x08c919e9._0x91bf5dc8(new byte[46] { 64, 92, 92, 88, 91, 18, 7, 7, 88, 68, 73, 81, 6, 79, 71, 71, 79, 68, 77, 6, 75, 71, 69, 7, 91, 92, 71, 90, 77, 7, 73, 88, 88, 91, 7, 76, 77, 92, 73, 65, 68, 91, 23, 65, 76, 21 }, 40) + _0x2d9c463f;
        WLog(_0x08c919e9._0x91bf5dc8(new byte[35] { 2, 41, 51, 46, 44, 36, 13, 40, 42, 36, 97, 44, 32, 51, 42, 36, 53, 97, 39, 32, 45, 45, 35, 32, 34, 42, 97, 32, 50, 97, 54, 36, 35, 123, 97 }, 65) + _0x7e69bc49);
        return _0x860165dd(_0x7e69bc49);
    }

    private bool _0x78a8460d = false;
    private void _0x4d290fa4(string _0x80dd9720)
    {
        _0x1710af30();
        StartCoroutine(_0x453559aa(_0x80dd9720));
    }

    private string _0x6af4a5db()
    {
        if (string.IsNullOrEmpty(_0xd72a4674) && _0x90c4e6b3 != null)
            _0xd72a4674 = _0x90c4e6b3.GetUserAgent();
        if (string.IsNullOrEmpty(_0xd72a4674))
            return string.Empty;
        string _0x1232c282 = Regex.Replace(_0xd72a4674, _0x08c919e9._0x91bf5dc8(new byte[11] { 249, 214, 143, 158, 249, 214, 143, 210, 211, 249, 199 }, 165), string.Empty);
        _0x1232c282 = Regex.Replace(_0x1232c282, _0x08c919e9._0x91bf5dc8(new byte[15] { 230, 201, 145, 248, 207, 211, 214, 222, 149, 225, 228, 129, 147, 231, 145 }, 186), string.Empty);
        _0x1232c282 = Regex.Replace(_0x1232c282, _0x08c919e9._0x91bf5dc8(new byte[15] { 103, 84, 67, 66, 88, 94, 95, 30, 5, 109, 31, 1, 109, 66, 27 }, 49), string.Empty);
        return Regex.Replace(_0x1232c282, _0x08c919e9._0x91bf5dc8(new byte[6] { 193, 238, 230, 175, 177, 224 }, 157), _0x08c919e9._0x91bf5dc8(new byte[1] { 233 }, 201)).Trim();
    }

    private string _0x421ba63f()
    {
        float _0x21d02993 = Time.realtimeSinceStartup;
        if (_0x21d02993 < 0f)
            _0x21d02993 = 0f;
        int _0xab9f743d = (int)(_0x21d02993 * 1000f);
        int _0xf7b3cb2b = _0xab9f743d / 60000;
        int _0x436896cd = (_0xab9f743d / 1000) % 60;
        int _0xa1d1330b = _0xab9f743d % 1000;
        return string.Format(_0x08c919e9._0x91bf5dc8(new byte[21] { 104, 35, 41, 35, 35, 110, 41, 104, 34, 41, 35, 35, 110, 41, 104, 33, 41, 35, 35, 35, 110 }, 19), _0xf7b3cb2b, _0x436896cd, _0xa1d1330b);
    }

    private void _0xf46bab1a()
    {
        _0xfde1b26d = true;
        if (_0x90c4e6b3 != null)
            _0x90c4e6b3.SetUserAgent(_0x6af4a5db());
    }

    private string _0xcdb1e0f1()
    {
        string _0xbdafa2a9 = _0x6af4a5db();
        if (string.IsNullOrEmpty(_0xbdafa2a9))
            return _0x08c919e9._0x91bf5dc8(new byte[7] { 63, 38, 32, 45, 105, 121, 114 }, 73);
        string _0x6d2df6fe = _0xbdafa2a9.Replace(_0x08c919e9._0x91bf5dc8(new byte[1] { 91 }, 7), _0x08c919e9._0x91bf5dc8(new byte[2] { 146, 146 }, 206)).Replace(_0x08c919e9._0x91bf5dc8(new byte[1] { 173 }, 138), _0x08c919e9._0x91bf5dc8(new byte[2] { 102, 29 }, 58));
        var _0xedbd2ea9 = Regex.Match(_0xbdafa2a9, _0x08c919e9._0x91bf5dc8(new byte[12] { 227, 200, 210, 207, 205, 197, 143, 136, 252, 196, 139, 137 }, 160));
        string _0x1b402214 = _0xedbd2ea9.Success ? _0xedbd2ea9.Groups[1].Value : _0x08c919e9._0x91bf5dc8(new byte[3] { 127, 124, 126 }, 78);
        return _0x08c919e9._0x91bf5dc8(new byte[12] { 178, 252, 239, 244, 249, 238, 243, 245, 244, 178, 179, 225 }, 154) + _0x08c919e9._0x91bf5dc8(new byte[8] { 212, 195, 208, 130, 215, 195, 159, 133 }, 162) + _0x6d2df6fe + _0x08c919e9._0x91bf5dc8(new byte[2] { 193, 221 }, 230) + _0x08c919e9._0x91bf5dc8(new byte[30] { 183, 160, 179, 225, 177, 179, 174, 181, 174, 252, 143, 160, 183, 168, 166, 160, 181, 174, 179, 239, 177, 179, 174, 181, 174, 181, 184, 177, 164, 250 }, 193) + _0x08c919e9._0x91bf5dc8(new byte[121] { 198, 213, 206, 195, 212, 201, 207, 206, 128, 196, 197, 198, 136, 207, 194, 202, 140, 203, 197, 217, 140, 214, 193, 204, 137, 219, 212, 210, 217, 219, 239, 194, 202, 197, 195, 212, 142, 196, 197, 198, 201, 206, 197, 240, 210, 207, 208, 197, 210, 212, 217, 136, 207, 194, 202, 140, 203, 197, 217, 140, 219, 199, 197, 212, 154, 198, 213, 206, 195, 212, 201, 207, 206, 136, 137, 219, 210, 197, 212, 213, 210, 206, 128, 214, 193, 204, 155, 221, 140, 195, 207, 206, 198, 201, 199, 213, 210, 193, 194, 204, 197, 154, 212, 210, 213, 197, 221, 137, 155, 221, 195, 193, 212, 195, 200, 136, 197, 137, 219, 221, 221 }, 160) + _0x08c919e9._0x91bf5dc8(new byte[26] { 96, 97, 98, 44, 116, 118, 107, 112, 107, 40, 35, 113, 119, 97, 118, 69, 99, 97, 106, 112, 35, 40, 113, 101, 45, 63 }, 4) + _0x08c919e9._0x91bf5dc8(new byte[52] { 21, 20, 23, 89, 1, 3, 30, 5, 30, 93, 86, 16, 1, 1, 39, 20, 3, 2, 24, 30, 31, 86, 93, 4, 16, 95, 3, 20, 1, 29, 16, 18, 20, 89, 94, 47, 60, 30, 11, 24, 29, 29, 16, 45, 94, 94, 93, 86, 86, 88, 88, 74 }, 113) + _0x08c919e9._0x91bf5dc8(new byte[37] { 138, 139, 136, 198, 158, 156, 129, 154, 129, 194, 201, 158, 130, 143, 154, 136, 129, 156, 131, 201, 194, 201, 162, 135, 128, 155, 150, 206, 143, 156, 131, 152, 214, 130, 201, 199, 213 }, 238) + _0x08c919e9._0x91bf5dc8(new byte[34] { 82, 83, 80, 30, 70, 68, 89, 66, 89, 26, 17, 64, 83, 88, 82, 89, 68, 17, 26, 17, 113, 89, 89, 81, 90, 83, 22, 127, 88, 85, 24, 17, 31, 13 }, 54) + _0x08c919e9._0x91bf5dc8(new byte[30] { 32, 33, 34, 108, 52, 54, 43, 48, 43, 104, 99, 41, 37, 60, 16, 43, 49, 39, 44, 20, 43, 45, 42, 48, 55, 99, 104, 113, 109, 127 }, 68) + _0x08c919e9._0x91bf5dc8(new byte[48] { 145, 151, 156, 158, 147, 132, 151, 197, 144, 132, 129, 216, 158, 135, 151, 132, 139, 129, 150, 223, 190, 158, 135, 151, 132, 139, 129, 223, 194, 166, 141, 151, 138, 136, 140, 144, 136, 194, 201, 147, 128, 151, 150, 140, 138, 139, 223, 194 }, 229) + _0x1b402214 + _0x08c919e9._0x91bf5dc8(new byte[35] { 84, 14, 95, 8, 17, 1, 18, 29, 23, 73, 84, 52, 28, 28, 20, 31, 22, 83, 48, 27, 1, 28, 30, 22, 84, 95, 5, 22, 1, 0, 26, 28, 29, 73, 84 }, 115) + _0x1b402214 + _0x08c919e9._0x91bf5dc8(new byte[238] { 224, 186, 235, 188, 165, 181, 166, 169, 163, 253, 224, 137, 168, 179, 250, 134, 248, 133, 181, 166, 169, 163, 224, 235, 177, 162, 181, 180, 174, 168, 169, 253, 224, 245, 243, 224, 186, 154, 235, 170, 168, 165, 174, 171, 162, 253, 179, 181, 178, 162, 235, 183, 171, 166, 179, 161, 168, 181, 170, 253, 224, 134, 169, 163, 181, 168, 174, 163, 224, 235, 160, 162, 179, 143, 174, 160, 175, 130, 169, 179, 181, 168, 183, 190, 145, 166, 171, 178, 162, 180, 253, 161, 178, 169, 164, 179, 174, 168, 169, 239, 238, 188, 181, 162, 179, 178, 181, 169, 231, 151, 181, 168, 170, 174, 180, 162, 233, 181, 162, 180, 168, 171, 177, 162, 239, 188, 166, 181, 164, 175, 174, 179, 162, 164, 179, 178, 181, 162, 253, 224, 166, 181, 170, 224, 235, 165, 174, 179, 169, 162, 180, 180, 253, 224, 241, 243, 224, 235, 170, 168, 165, 174, 171, 162, 253, 179, 181, 178, 162, 235, 170, 168, 163, 162, 171, 253, 224, 224, 235, 183, 171, 166, 179, 161, 168, 181, 170, 253, 224, 134, 169, 163, 181, 168, 174, 163, 224, 235, 183, 171, 166, 179, 161, 168, 181, 170, 145, 162, 181, 180, 174, 168, 169, 253, 224, 246, 243, 233, 247, 233, 247, 224, 235, 178, 166, 129, 178, 171, 171, 145, 162, 181, 180, 174, 168, 169, 253, 224 }, 199) + _0x1b402214 + _0x08c919e9._0x91bf5dc8(new byte[117] { 235, 245, 235, 245, 235, 245, 226, 184, 236, 254, 184, 184, 254, 138, 167, 175, 160, 166, 177, 235, 161, 160, 163, 172, 171, 160, 149, 183, 170, 181, 160, 183, 177, 188, 237, 181, 183, 170, 177, 170, 233, 226, 176, 182, 160, 183, 132, 162, 160, 171, 177, 129, 164, 177, 164, 226, 233, 190, 162, 160, 177, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 176, 164, 161, 254, 184, 233, 166, 170, 171, 163, 172, 162, 176, 183, 164, 167, 169, 160, 255, 177, 183, 176, 160, 184, 236, 254, 184, 166, 164, 177, 166, 173, 237, 160, 236, 190, 184 }, 197) + _0x08c919e9._0x91bf5dc8(new byte[5] { 234, 190, 191, 190, 172 }, 151);
    }

    private bool _0x6101aa62 = false;
    private RectTransform _0x3b0bf83a;
    private bool TryOpenExternalLikeChrome(string _0xefbf13fe)
    {
        if (string.IsNullOrEmpty(_0xefbf13fe))
            return false;
        if (_0xefbf13fe.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[9] { 235, 236, 246, 231, 236, 246, 184, 173, 173 }, 130), StringComparison.OrdinalIgnoreCase))
            return _0x4d3e9653(_0xefbf13fe);
        if (_0xe86daa66(_0xefbf13fe))
            return _0xf757c407(_0xefbf13fe, null);
        if (!_0xefbf13fe.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[7] { 115, 111, 111, 107, 33, 52, 52 }, 27), StringComparison.OrdinalIgnoreCase) && !_0xefbf13fe.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[8] { 26, 6, 6, 2, 1, 72, 93, 93 }, 114), StringComparison.OrdinalIgnoreCase) && !_0xefbf13fe.StartsWith(_0x08c919e9._0x91bf5dc8(new byte[11] { 221, 222, 211, 201, 200, 134, 222, 208, 221, 210, 215 }, 188), StringComparison.OrdinalIgnoreCase))
        {
            return _0x860165dd(_0xefbf13fe);
        }

        return false;
    }

    private string _0xbebb3e86 = "";
    public void _0xf5c3f882()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[18] { 81, 94, 111, 121, 126, 87, 42, 70, 107, 127, 100, 105, 98, 42, 77, 107, 103, 111 }, 10));
#endif
        }

        _0x316d6555.Instance?._0x24b8ce55();
        _0x9614a5e3.Instance._0x9b9c483a(_0x0c2ee824._0xeaf43e11.DEFAULT);
    }

    private GameObject _0xd0d290bc;
    private string _0x8d7ec24b = "";
    private async Task<bool> _0xd5b107da()
    {
        {
#if B_LOGS
            Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[29] { 170, 165, 148, 130, 133, 172, 209, 184, 130, 161, 131, 152, 135, 144, 146, 136, 176, 159, 149, 162, 144, 135, 148, 149, 178, 153, 148, 146, 154 }, 241));
#endif
        }

        string _0xd61f1ede = "";
        for (int _0xd03336c2 = 0; _0xd03336c2 < 2; _0xd03336c2++)
        {
            if (await _0xa95d91ef(1, 100))
            {
                await _0x93abf5b2(_0x08c919e9._0x91bf5dc8(new byte[7] { 4, 10, 9, 5, 13, 3, 2 }, 102));
                _0xf5c3f882();
                return true;
            }

            _0xd61f1ede = await _0xfcb5b3d9(1, 100);
            if (!string.IsNullOrEmpty(_0xd61f1ede))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xd61f1ede))
            {
                if (!string.IsNullOrEmpty(_0xa97ec193))
                {
                    _0xd61f1ede = _0x15207161(_0xd61f1ede, _0xa97ec193);
                    {
#if B_LOGS
                        Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[53] { 116, 123, 74, 92, 91, 114, 15, 108, 78, 76, 71, 74, 75, 15, 73, 70, 65, 78, 67, 122, 93, 67, 15, 88, 70, 91, 71, 15, 92, 74, 65, 75, 70, 75, 15, 205, 169, 189, 15, 92, 71, 64, 88, 15, 120, 74, 77, 121, 70, 74, 88, 21, 15 }, 47) + _0xd61f1ede);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[39] { 174, 161, 144, 134, 129, 168, 213, 182, 148, 150, 157, 144, 145, 213, 147, 156, 155, 148, 153, 160, 135, 153, 213, 23, 115, 103, 213, 134, 157, 154, 130, 213, 162, 144, 151, 163, 156, 144, 130 }, 245));
#endif
                    }
                }

                _0x920c8147 = true;
                _0x4d290fa4(_0xd61f1ede);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x08c919e9._0x91bf5dc8(new byte[44] { 64, 79, 126, 104, 111, 70, 59, 94, 99, 120, 126, 107, 111, 114, 116, 117, 59, 108, 115, 114, 119, 126, 59, 120, 115, 126, 120, 112, 114, 117, 124, 59, 104, 122, 109, 126, 127, 59, 119, 114, 117, 112, 33, 59 }, 27) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private readonly List<UniWebViewPopup> _0x604edc9f = new List<UniWebViewPopup>();
    private string _0x0a804854 = "";
    private void _0x0dc15d0a()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xc4362925)
    {
        if (_0xc4362925 == null || _0xc4362925.Extra == null)
            return null;
        object _0x58536700;
        if (!_0xc4362925.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x58536700))
            return null;
        return _0x58536700 as string;
    }
}

internal static class _0x08c919e9
{
    internal static string _0x91bf5dc8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}