using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpawnConfig
{
    [SerializeField]
    private List<int> _spots;
    [SerializeField]
    private float _speed;

    public List<int> Spots { get { return _spots; } }
    public float Speed { get { return _speed; } }
}
