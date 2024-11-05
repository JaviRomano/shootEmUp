using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float bulletVelocity;


    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = Vector2.right * bulletVelocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            collision.gameObject.GetComponent<EnemyHealth>().EnemyHurt();
            Destroy(gameObject);
        }
    }


}
