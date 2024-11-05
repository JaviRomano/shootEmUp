using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float spawnerFirstTime, spawnerTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemy", spawnerFirstTime, spawnerTime);
    }

    // Update is called once per frame
    void CreateEnemy()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
