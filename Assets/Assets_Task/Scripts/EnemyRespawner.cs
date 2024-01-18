using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawner : MonoBehaviour
{
    public GameObject enemy;
    

    private void Start()
    {
        InvokeRepeating("EnemyRespawn", 2, 8);
    }
    public void EnemyRespawn()
    {
      Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);
        
    }
}
