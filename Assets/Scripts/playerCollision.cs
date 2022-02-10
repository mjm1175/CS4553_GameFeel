using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public GameObject sound;
    public CameraShake cms;
    public LightFade lf;

    private Rigidbody2D rb;
    public GameObject sa;
    public GameObject sc;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            if (GlobalVars.dissolveEffect)
            {
                Dissolve.isDissolving = true;
            }
            StartCoroutine(lf.fadeOut());


        }
        if (collisionInfo.gameObject.CompareTag("sound"))
        {
            sound.SetActive(true);
            sc.SetActive(false);


        }
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ds"))
        {
            sa.SetActive(false);
            sc.SetActive(true);
        }
      
    }
}
