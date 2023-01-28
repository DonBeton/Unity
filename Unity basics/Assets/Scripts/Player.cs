using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _groundedCheckTransform;
    [SerializeField] private LayerMask _playerMask;

    private Rigidbody _rigidbody;
    private float _forceJump = 6;
    private float _speed = 3;
    private bool _jumpKeyPressed;
    private float _horizontalInput;

    private void Start() 
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpKeyPressed = true;
        }
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate() 
    {
        _rigidbody.velocity = new Vector3(_horizontalInput*_speed, _rigidbody.velocity.y, 0);

        if (Physics.OverlapSphere(_groundedCheckTransform.position, 0.3f, _playerMask).Length == 0)
        {
            return;
        }
        if (_jumpKeyPressed)
        {
            _rigidbody.AddForce(Vector3.up * _forceJump, ForceMode.VelocityChange);
            _jumpKeyPressed = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            Destroy(other.gameObject);
        }
    }
}
