using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xf726d0d1 : MonoBehaviour
{
    private Vector3 _0xc8f2caf3 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xd54e792f;
        Matrix4x4 _0xbfddcd66 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x4a7cadcc.orthographic)
        {
            float _0x717a3d6a = this._0x4a7cadcc.farClipPlane - this._0x4a7cadcc.nearClipPlane;
            float _0x58c1fdc6 = (this._0x4a7cadcc.farClipPlane + this._0x4a7cadcc.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x58c1fdc6), new Vector3(this._0x4a7cadcc.orthographicSize * 2 * this._0x4a7cadcc.aspect, this._0x4a7cadcc.orthographicSize * 2, _0x717a3d6a));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x4a7cadcc.fieldOfView, this._0x4a7cadcc.farClipPlane, this._0x4a7cadcc.nearClipPlane, this._0x4a7cadcc.aspect);
        }

        Gizmos.matrix = _0xbfddcd66;
    }

    private Vector3 _0xec79cb65 { get; set; }

    private float _0x00a3e6fb = 1;
    private static _0xf726d0d1 _0x124b7eb2;
    private Vector3 _0x5ff59889 { get; set; }
    private Vector3 _0x78140ae1 { get; set; }
    private Vector3 _0x2c8ee717 { get; set; }

    private void _0x8b7e5f45()
    {
        float _0xf46e440a, _0xb5862d7d, _0x9866c826, _0xc10b12b2;
        if (this._0x11d217b0 == _0x26915d07.Landscape)
            this._0x4a7cadcc.orthographicSize = 1f / this._0x4a7cadcc.aspect * this._0x00a3e6fb / 2f;
        else
            this._0x4a7cadcc.orthographicSize = this._0x00a3e6fb / 2f;
        this._0x25c5736e = 2f * this._0x4a7cadcc.orthographicSize;
        this._0xe7684e7a = this._0x25c5736e * this._0x4a7cadcc.aspect;
        float _0x6b49230b = this._0x4a7cadcc.transform.position.x;
        float _0x2b04f0e3 = this._0x4a7cadcc.transform.position.y;
        _0xf46e440a = _0x6b49230b - this._0xe7684e7a / 2;
        _0xb5862d7d = _0x6b49230b + this._0xe7684e7a / 2;
        _0x9866c826 = _0x2b04f0e3 + this._0x25c5736e / 2;
        _0xc10b12b2 = _0x2b04f0e3 - this._0x25c5736e / 2;
        this._0x5ff59889 = new Vector3(_0xf46e440a, _0xc10b12b2, 0);
        this._0x15481519 = new Vector3(_0x6b49230b, _0xc10b12b2, 0);
        this._0x78140ae1 = new Vector3(_0xb5862d7d, _0xc10b12b2, 0);
        this._0xf06838c2 = new Vector3(_0xf46e440a, _0x2b04f0e3, 0);
        this._0x9e232aef = new Vector3(_0x6b49230b, _0x2b04f0e3, 0);
        this._0x97092937 = new Vector3(_0xb5862d7d, _0x2b04f0e3, 0);
        this._0xec79cb65 = new Vector3(_0xf46e440a, _0x9866c826, 0);
        this._0xc8f2caf3 = new Vector3(_0x6b49230b, _0x9866c826, 0);
        this._0x2c8ee717 = new Vector3(_0xb5862d7d, _0x9866c826, 0);
    }

    private void Awake()
    {
        this._0x4a7cadcc = this.GetComponent<Camera>();
        _0x124b7eb2 = this;
        this._0x8b7e5f45();
    }

    private Vector3 _0x97092937 { get; set; }
    private Vector3 _0xf06838c2 { get; set; }

    private new Camera _0x4a7cadcc;
    public enum _0x26915d07
    {
        Landscape,
        Portrait
    }

    private Color _0xd54e792f = Color.white;
    private Vector3 _0x15481519 { get; set; }
    //public bool executeInUpdate;
    private float _0xe7684e7a { get; set; }
    private Vector3 _0x9e232aef { get; set; }

    private _0x26915d07 _0x11d217b0 = _0x26915d07.Portrait;
    private float _0x25c5736e { get; set; }
}