using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listOfPrefabs = new List<GameObject>();
    private int _spawnNumber;
    private float _pointToSpawnX;

    [Space]
    [SerializeField] private Transform _leftSpawnPoint;
    [SerializeField] private Transform _rightSpawnPoint;

    [Space]
    [SerializeField] private float _timeToSpawn = 1;


    private void Update()
    {
        if(_timeToSpawn <= 0)
        {
            SpawnBomb();
        }

        CountdownToSpawn();
    }

    private void CountdownToSpawn()
    {
        _timeToSpawn -= Time.deltaTime;
    }
    
    private void SpawnBomb()
    {
        _timeToSpawn = Random.Range(1, 6);
        _spawnNumber = Random.Range(0, _listOfPrefabs.Count);
        _pointToSpawnX = Random.Range(_leftSpawnPoint.position.x, _rightSpawnPoint.position.x);

        Instantiate(_listOfPrefabs[_spawnNumber], new Vector3(_pointToSpawnX, _leftSpawnPoint.position.y, _leftSpawnPoint.position.z), Quaternion.identity);

    }

}
