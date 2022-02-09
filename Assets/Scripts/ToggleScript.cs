using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    
    public GameObject shadedEnv;
    public GameObject unshadedEnv;
    public GameObject sound;
    public GameObject sound1;
    public GameObject bou;
    private void Start() {
        shadedEnv.SetActive(false);
    }

    public void CameraShake(){
        if (GlobalVars.cameraShake){
            GlobalVars.cameraShake = false;
        } else {
            GlobalVars.cameraShake = true;
        }
    }

    public void Dissolve(){
        if(GlobalVars.dissolveEffect){
            GlobalVars.dissolveEffect = false;
        } else {
            GlobalVars.dissolveEffect = true;
        }
    }

    public void Depth(){
        if(GlobalVars.depthEffect){
            GlobalVars.depthEffect = false;
            shadedEnv.SetActive(false);
            unshadedEnv.SetActive(true);
        } else {
            GlobalVars.depthEffect = true;
            shadedEnv.SetActive(true);
            unshadedEnv.SetActive(false);
        }
    }

    public void Trail(){
        if (GlobalVars.trailEffect){
            GlobalVars.trailEffect = false;
        } else {
            GlobalVars.trailEffect = true;
        }
    }
    public void Sound()
    {
        if (GlobalVars.soundEffect)
        {
            GlobalVars.soundEffect = false;
            sound.SetActive(false);
            
        }
        else
        {
            GlobalVars.soundEffect = true;
            sound.SetActive(true);
           
        }
    }
    public void Bou()
    {
        if (GlobalVars.bouEffect)
        {
            GlobalVars.bouEffect = false;
            sound1.SetActive(false);


        }
        else
        {
            GlobalVars.bouEffect = true;
            sound1.SetActive(true);
            bou.GetComponent<Up>().enabled = true;
        }
    }
}
