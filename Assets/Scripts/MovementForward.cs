using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForward : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private Vector3 _movementDirection;

    private void Update()
    {
        _movementDirection = Vector3.forward * _movementSpeed * Time.deltaTime;
        transform.Translate(_movementDirection);
    }
}
