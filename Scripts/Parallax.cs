using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Renderer parallaxRenderer;
    [SerializeField] float parallaxVelocity;

    
    // Update is called once per frame
    void Update()
    {
        parallaxRenderer.material.mainTextureOffset = new Vector2(Time.time * parallaxVelocity, 0);
    }
}
