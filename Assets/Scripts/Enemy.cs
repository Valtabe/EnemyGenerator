using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private Vector3 _direction;

    private void Update()
    {
        _mover.DirectionMove(_direction);
    }

    public void SetDirection(Vector3 direction) => _direction = direction;
}
