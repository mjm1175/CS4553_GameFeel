using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    
    public CameraShake cms;
    
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("collide");
        if (collisionInfo.collider.CompareTag("Finish"))
        {
            Debug.Log("aha");
            StartCoroutine(cms.shake());
        }
        
        
    }
}
