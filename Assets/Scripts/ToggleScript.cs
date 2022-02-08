using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
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
}
