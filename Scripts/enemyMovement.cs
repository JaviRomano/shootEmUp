using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] Vector2 enemyDirection;
    [SerializeField] float enemyVelocity;
    [SerializeField] float timeToDie;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = enemyDirection * enemyVelocity;

        StartCoroutine(CoroutineDestroyEnemyByTime());
    }

    IEnumerator CoroutineDestroyEnemyByTime()
    {
        yield return new WaitForSeconds(timeToDie);
        Destroy(gameObject);
    }

}
