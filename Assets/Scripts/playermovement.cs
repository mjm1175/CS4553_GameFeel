using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    
    public float forwardForce = 200f;
    // Start is called before the first frame update
      void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(Vector2.right * forwardForce * Time.deltaTime);
        

    }
}
