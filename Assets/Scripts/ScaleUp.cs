using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    [SerializeField] private float _resizeSpeed;
    private Vector3 _scaleUp;

    private void Update()
    {
        _scaleUp = Vector3.one * _resizeSpeed * Time.deltaTime;
        transform.localScale += _scaleUp;
    }
}
