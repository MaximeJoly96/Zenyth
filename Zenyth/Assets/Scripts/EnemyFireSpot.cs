using UnityEngine;
using System.Collections;

public class EnemyFireSpot : MonoBehaviour
{
    private const float SPEED = 4.0f;
    private GameObject _projInst;
    private float _xAxis;
    private float _yAxis;

    private void Awake()
    {
        _xAxis = Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
        _yAxis = Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
    }

    public void SpawnProjectile(GameObject projectile)
    {
        _projInst = Instantiate(projectile, transform.localPosition, Quaternion.identity);
    }

    private void Update()
    {
        if(_projInst)
            _projInst.transform.Translate(_xAxis * Time.deltaTime * SPEED, _yAxis * Time.deltaTime * SPEED, 0);
    }
}
