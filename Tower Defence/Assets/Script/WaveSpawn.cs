using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    [SerializeField] private int _waveSize;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _enemyInterval;
    [SerializeField] private float _startTime;
    private Transform _spavnPoint;
    private int _enemyCoint = 0;

    private void Start() {
        _spavnPoint = GetComponent<Transform>(); 
        InvokeRepeating("SpavnEnemy", _startTime, _enemyInterval);
    }

    private void Update() {
        if (_enemyCoint == _waveSize)
            CancelInvoke("SpavnEnemy");
    }

    void SpavnEnemy()
    {
        _enemyCoint++;
        GameObject enemy = GameObject.Instantiate(_enemyPrefab, _spavnPoint.position, _spavnPoint.rotation);
    }
}
