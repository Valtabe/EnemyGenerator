using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void DirectionMove(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
