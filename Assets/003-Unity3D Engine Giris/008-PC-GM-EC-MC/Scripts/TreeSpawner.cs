using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    [Range(1, 5)] [SerializeField] float _minSpawnTime;
    [Range(2, 6)] [SerializeField] float _maxSpawnTime;
    float _randomSpawnTimeTree, _randomSpawnTimeDragon, _currentTimeTree, _currentTimeDragon;
    [SerializeField] GameObject[] _trees;
    [SerializeField] GameObject _redDragon;
    [SerializeField] Transform _treeTra, _draTra;

    private void Update()
    {
        _currentTimeTree += Time.deltaTime;
        _currentTimeDragon += Time.deltaTime;
        if (_currentTimeTree > _randomSpawnTimeTree)
        {
            TreeSpawnStart();
            
        }if (_currentTimeDragon > _randomSpawnTimeDragon)
        {
           
            RedDragonSpawnStart();
        }
    }
    void TreeSpawnStart()
    {
        int _randomIndex = Random.Range(0, _trees.Length);
        Instantiate(_trees[_randomIndex], _treeTra.position, _treeTra.rotation, _treeTra);
        ResetTimeTree();
    }
    void RedDragonSpawnStart()
    {
        Instantiate(_redDragon, _draTra.position, _draTra.rotation, _draTra);
        ResetTimeDragon();
    }
    void ResetTimeTree()
    {
        _currentTimeTree = 0;
        _randomSpawnTimeTree = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    void ResetTimeDragon()
    {
        _currentTimeDragon = 0;
        _randomSpawnTimeDragon = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
}
