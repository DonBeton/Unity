using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _startPositionWalls;
    [SerializeField] private bool _thisBoll;
    [SerializeField] private bool _spawneBlock;
    [SerializeField] private int _spawneBlockFrequency;
    private Transform _zero;
    private Vector3 _curentPosition;
    private int _wallWidth = 11;
    public float Speed = 1;
    private float _lookHeight;

    void Awake() {
        _zero = GetComponent<Transform>();
        _lookHeight = _zero.transform.position.y;
        StartGenerate();
        StartCoroutine(AutoGenerate());
    }

    IEnumerator AutoGenerate()
    {
        if (_thisBoll)
        {
            yield break;
        }
        int countX = 0;
        while(true)
        {
            yield return new WaitForSeconds(Speed*Time.deltaTime);
            GameObject wall = Instantiate(_prefab, _zero);
            wall.transform.position = new Vector3(_curentPosition.x + countX, _lookHeight, 0);
            if (_spawneBlock)
            {
                if (countX % _spawneBlockFrequency == 0)
                {
                    SpawneBlock(wall.transform.position);
                }
            }
            countX++;
        }
       
    }
    
    private void SpawneBlock(Vector3 position)
    {
        int blockHeight = Random.Range(0, 10);
        position.y += blockHeight;
        var block = Instantiate(_prefab, position, Quaternion.identity);
    }

    private void StartGenerate()
    {
        if (_thisBoll)
        {
            var wall = Instantiate(_prefab, _zero);
        }
        else 
        {
            GameObject wall = null;
            for(int x = -10; x <= _wallWidth; x++)
            {
                wall = Instantiate(_prefab, _zero);
                wall.transform.position = new Vector3(x, _lookHeight, 0);
            }
            _curentPosition = wall.transform.position;
        }
    }
}
