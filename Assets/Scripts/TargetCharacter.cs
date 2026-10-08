using UnityEngine;

public class TargetCharacter : MonoBehaviour
{
    [SerializeField] private Transform[] _route;
    [SerializeField] private Mover _mover;

    private int _currentWaypoint = 0;

    private void Start()
    {
        TryGetComponent<Mover>(out _mover);
    }

    private void Update()
    {
        if (transform.position == _route[_currentWaypoint].position)
        {
            _currentWaypoint = (_currentWaypoint +1) % _route.Length;
        }

        _mover.MoveToTarget(_route[_currentWaypoint].position);
    }
}
