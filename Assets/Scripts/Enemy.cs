using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private TargetCharacter _target;

    private void Update()
    {
        _mover.MoveToTarget(_target.transform.position);
    }

    public void Initialize(TargetCharacter target)
    {
        _target = target;
    }
}
