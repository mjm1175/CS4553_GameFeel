using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public GameObject sound;
    public CameraShake cms;
    public LightFade lf;


    private bool firstCollision;

    public AudioSource dropSound;

    void Start()
    {
        firstCollision = true;
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //Debug.Log("collide");
        if (collisionInfo.collider.CompareTag("Finish"))
        {
            //Debug.Log("aha");
            if (GlobalVars.cameraShake){
                StartCoroutine(cms.shake());
                // StopCoroutine(GetComponent<Trail>().TrailCor);
            }

            if (GlobalVars.soundEffect){
                dropSound.Play();
            }
            if (GlobalVars.dissolveEffect)
            {
                Dissolve.isDissolving = true;
            }             
            if (firstCollision){

                if (GlobalVars.lightingEffect){
                    StartCoroutine(lf.fadeOut());
                }                
            }
            firstCollision = false;


            


        }
    

    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ds"))
        {
            sa.SetActive(false);
            sc.SetActive(true);
        }
      
    }*/
}
