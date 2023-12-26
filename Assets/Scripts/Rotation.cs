using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private Vector3 _rotationDirection;

    private void Update()
    {
        _rotationDirection = Vector3.up * _rotationSpeed * Time.deltaTime;
        transform.Rotate(_rotationDirection);
    }
}
