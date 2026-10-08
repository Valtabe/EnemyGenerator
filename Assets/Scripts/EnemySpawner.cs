using System.Collections;
using UnityEngine;

public class EnemySpawner : Spawner<Enemy>
{
    [SerializeField] private TargetCharacter _target;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private int _maxEnemyCount;
    [SerializeField] private int _currentEnemyCount;

    private WaitForSeconds _wait;

    private void Start()
    {
        _wait = new WaitForSeconds(_spawnDelay);
        _currentEnemyCount = 0;
        StartCoroutine(SpawnEnemyAfterDelay());
    }

    override protected Enemy CreateInSpawnPoint()
    {
        Enemy createdEnemy = base.CreateInSpawnPoint();
        createdEnemy.Initialize(_target);
        _currentEnemyCount++;

        return createdEnemy;
    }

    private Vector3 ChooseDirection()
    {
        Vector3[] availableDirection = new Vector3[] {Vector3.forward, Vector3.back, Vector3.right, Vector3.left};

        return availableDirection[UnityEngine.Random.Range(0, availableDirection.Length)];
    }

    private IEnumerator SpawnEnemyAfterDelay()
    {
        while (_currentEnemyCount < _maxEnemyCount)
        {
            CreateInSpawnPoint();

            yield return _wait;
        }
    }
}
