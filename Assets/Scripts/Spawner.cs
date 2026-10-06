using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner<T> : MonoBehaviour where T: MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private T _prefab;

    public event Action<T> Spawned;
    
    virtual protected T CreateInSpawnPoint()
    {
        int spawnPointNumber = UnityEngine.Random.Range(0, _spawnPoints.Length);
        T @object = Instantiate(_prefab, _spawnPoints[spawnPointNumber].position, Quaternion.identity);
        Spawned?.Invoke(@object);
        return @object;
    }
}