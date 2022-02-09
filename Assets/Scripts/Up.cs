using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("sound"))
        {
            
            rb.AddForce(Vector2.up * 150);

            Destroy(a, 1f);
        }
        if (collisionInfo.gameObject.CompareTag("sound1"))
        {

            rb.AddForce(Vector2.up * 300);

            Destroy(b, 1f);
        }
    }
}
