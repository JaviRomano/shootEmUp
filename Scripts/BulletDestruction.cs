using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestruction : MonoBehaviour
{
    [SerializeField] float destructionX;

  
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= destructionX)
            Destroy(gameObject);
    }
}
