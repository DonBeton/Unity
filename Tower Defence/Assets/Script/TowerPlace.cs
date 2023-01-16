using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    [SerializeField] GameObject _tower;
    private Vector3 _ofset;
    private bool _empty;

    private void Start() {
        _empty = true;
        _ofset += new Vector3(0,1.3f,0); 
    }
    private void OnMouseDown() 
    {
        if (_empty)
        {
            GameObject curTower = GameObject.Instantiate(_tower, transform.position + _ofset, Quaternion.Euler (new Vector3(0,90, 0)));
            _empty = false;
        }
    }
}
