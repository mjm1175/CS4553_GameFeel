using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    private Material material;

    public static bool isDissolving = false;

    private float fade = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            isDissolvinig = true;
        }*/

        // if (GlobalVars.dissolveEffect){
        //     isDissolving = true;
        // }
        if (isDissolving)
        {
            StartCoroutine(DoDissolve());
        }

    }

    IEnumerator DoDissolve(){
        yield return new WaitForSeconds(2.0f);

            fade -= Time.deltaTime;
            if (fade <= 0f)
            {
                fade = 0f;
                isDissolving = false;
            }
            material.SetFloat("_Fade", fade); 

        yield return null;
    }
}
