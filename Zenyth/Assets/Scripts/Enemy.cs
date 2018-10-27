using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    private int _phase = 0;
    private float _bpm = 60.0f / 222.22f;

    [SerializeField]
    private GameObject _projectile;

    private void Awake()
    {
        StartCoroutine(ReadyFire());
        
    }

    IEnumerator ReadyFire()
    {
        while(true)
        {
            Fire();
            yield return new WaitForSeconds(_bpm);
        }
    }

    private void Fire()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        for (int i = 0; i < 360; i++)
        {
            if (i % 3 == _phase)
            {
                GameObject point = new GameObject();
                point.transform.parent = this.transform;
                point.name = "Spot" + i;

                point.transform.position = new Vector3(Mathf.Cos(Mathf.Deg2Rad * i) * sr.bounds.extents.x,
                                                       Mathf.Sin(Mathf.Deg2Rad * i) * sr.bounds.extents.y,
                                                       0);
                point.transform.rotation = Quaternion.Euler(0, 0, i);

                EnemyFireSpot efs = point.AddComponent<EnemyFireSpot>();
                efs.SpawnProjectile(_projectile);
            }
        }

        if (_phase < 3) _phase++;
        else _phase = 0;
    }
}
