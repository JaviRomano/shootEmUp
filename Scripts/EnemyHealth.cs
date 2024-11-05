using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int enemyLife;

    public void EnemyHurt()
    {
        enemyLife--;
        
        if(enemyLife <= 0)
        {
            ScoreManager.ScoreManagerInstance.AddScore();
            Destroy(gameObject);
        }
    }
}
