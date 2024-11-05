using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLimits : MonoBehaviour
{
    [SerializeField] float leftLimit, rightLimit, upLimit, bottomLimit;

        
    // Update is called once per frame
    void Update()
    {
        CheckLimit();
    }

    void CheckLimit()
    {
        if(transform.position.x < leftLimit)
        {
            transform.position = new Vector3(leftLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rightLimit)
        {
            transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.y < bottomLimit)
        {
            transform.position = new Vector3(transform.position.x, bottomLimit, transform.position.z);
        }
        if (transform.position.y > upLimit)
        {
            transform.position = new Vector3(transform.position.x, upLimit, transform.position.z);
        }
    }
}
