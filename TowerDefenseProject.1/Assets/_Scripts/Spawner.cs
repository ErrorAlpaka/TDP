using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _enemyPrefab;
    [SerializeField] Transform _goal;
    float _spawnTimer = 2f;


    // Update is called once per frame
    void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            _spawnTimer = 2;
            GameObject enemy = Instantiate(
                _enemyPrefab, 
                transform.position, 
                transform.rotation);

            NavMeshAgent navMeshAgent = enemy.GetComponent<NavMeshAgent>();
            navMeshAgent.SetDestination(_goal.position);
            //_enemyPrefab.GetComponent<NavMeshAgent>().SetDestination(_goal.position);
        }
    }
}
