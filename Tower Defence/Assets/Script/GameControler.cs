using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControler : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _tableObject;
    TMP_Text _textTable;

    void Start()
    {
        _textTable = _tableObject.GetComponent<TMP_Text>();
        _textTable.text = "Health: 100";        
    }

    public void UpdateTable()
    {
        _textTable.text = "Health:" + _player.Health;
    }

}
