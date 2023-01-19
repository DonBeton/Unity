using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public float Speed;
    public float VerticalSpeed;
    private Transform _transform;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
        _transform = gameObject.GetComponent<Transform>();
    }

    private void Update() 
    {
        if(Input.GetKey(KeyCode.Space))
            _rigidbody.velocity = new Vector2(Speed, VerticalSpeed);
        else
            _rigidbody.velocity = new Vector2(Speed, -VerticalSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Destroy(this.gameObject);    
    }

    private void OnDestroy() 
    {
        var menu = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<PauseMenu>();    
        if (menu != null)
        {
            menu.Pause();
        }
    }
}
