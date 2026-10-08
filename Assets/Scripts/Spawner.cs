using UnityEngine;

public class Spawner<T> : MonoBehaviour where T: MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private T _prefab;
    
    virtual protected T CreateInSpawnPoint()
    {
        T @object = Instantiate(_prefab, _spawnPoint.position, Quaternion.identity);
        return @object;
    }
}