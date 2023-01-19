using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrigger : MonoBehaviour
{
    [SerializeField] private TowerHead _mainTower;
    private Transform _enemyPosition;
    private bool _lockEnemy;
    private GameObject _curTarget;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("EnemyBag") && !_lockEnemy)
        {
            _mainTower.Target = other.gameObject.transform;
            _curTarget = other.gameObject;
            _lockEnemy = true;
        }
    }
    private void Update()
    {
        if(!_curTarget)
        {
            _lockEnemy = false;
        }    
    }
    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("EnemyBag") && _lockEnemy)
            _lockEnemy = false;    
    }
}

