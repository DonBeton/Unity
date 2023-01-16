using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health;
    [SerializeField] private GameControler _controler;

    private void Start() {
        Health = 100;
        _controler = GameObject.FindObjectOfType<GameControler>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        _controler.UpdateTable();
    }
}
