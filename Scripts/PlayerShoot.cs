using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] int counter;
        

    // Update is called once per frame
    void Update()
    {
        Shoot(); 
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            counter++;
            if(counter%10==0)
                Instantiate(bullet, transform.position, Quaternion.identity);

            if(counter >=1000)
                counter = 0;
        }
    }
}
