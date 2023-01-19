using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField] private Transform _tartgetTransform;
    [SerializeField] private Vector3 _offcet;
    public float Speed; 

    private void Start() 
    {
        _tartgetTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate() 
    {
        if (_tartgetTransform != null)
        {
            Move();        
        }
    }

    private void Move()
    {
        var nextPosition = Vector3.Lerp(transform.position, _tartgetTransform.position + _offcet, Time.fixedDeltaTime * Speed);
        nextPosition.y = 0;
        transform.position = nextPosition;
    }
}
