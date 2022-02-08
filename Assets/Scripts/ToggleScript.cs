using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    
    public GameObject shadedEnv;
    public GameObject unshadedEnv;

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
}
