using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void DirectionMove(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void MoveToTarget(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);
    }
}