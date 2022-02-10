using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightFade : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    private Light2D lightOne;
    private Light2D lightTwo;
    private Light2D lightThree;

    public float fadeTime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        lightOne = light1.GetComponent<Light2D>();
        lightTwo = light2.GetComponent<Light2D>();
        lightThree = light3.GetComponent<Light2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator fadeOut(){
        // 2 secs before fade
        yield return new WaitForSeconds(2.0f);

        float thisTime = 0.0f;
        while (thisTime < fadeTime){
            thisTime += Time.deltaTime;

            lightOne.intensity = Mathf.Lerp(1, 0, thisTime / fadeTime);
            lightTwo.intensity = Mathf.Lerp(1, 0, thisTime / fadeTime);
            lightThree.intensity = Mathf.Lerp(1, 0, thisTime / fadeTime);

            yield return null;
        }
    }
}
