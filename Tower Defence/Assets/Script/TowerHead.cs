using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHead : MonoBehaviour
{
    [SerializeField] private Transform _shooteElement;
    [SerializeField] private Transform _lookAtObject;
    [SerializeField] private float _damage;
    [SerializeField] private GameObject _bollet;
    [SerializeField] private float _shootDelay = 1;
    public Transform Target;
    private bool _isShoot;

    private void Update() {
        if(Target != null)
        {
            PursueAGoal();
        }
        if(!_isShoot)
        {
            StartCoroutine(Shoot());
        }
    }

    private void PursueAGoal()
    {
        _lookAtObject.transform.LookAt(Target);
    }

    IEnumerator Shoot()
    {
        _isShoot = true;
        yield return new WaitForSeconds(_shootDelay);
        GameObject bollet = GameObject.Instantiate(_bollet, _shooteElement.position, Quaternion.identity);
        bollet.GetComponent<BolletTower>().Target = Target;
        _isShoot = false;    
    }
}
