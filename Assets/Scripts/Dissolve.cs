using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    private Material material;

    private bool isDissolvinig = false;

    private float fade = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDissolvinig = true;
        }
        
        if (isDissolvinig)
        {
            fade -= Time.deltaTime;
            if (fade <= 0f)
            {
                fade = 0f;
                isDissolvinig = false;
            }
            material.SetFloat("_Fade", fade);
        }
    }
}
