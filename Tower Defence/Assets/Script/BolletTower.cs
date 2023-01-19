using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolletTower : MonoBehaviour
{
    [SerializeField] private float _speed = 10; 
    public Transform Target;
 
    void Update()
    {
        if (Target == null)
        {
            Destroy(this.gameObject);
        }
        if (Vector3.Distance(transform.position, Target.position)<0.7f)
        {
            Destroy(this.gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, Target.position, _speed * Time.deltaTime);     
    }
}
