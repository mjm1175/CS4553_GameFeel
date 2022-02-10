using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public PersistentBGM pbgm;
    public NonPersistentBGM bgm;
    public GameObject shadedEnv;
    public GameObject unshadedEnv;
    public GameObject sound;
    public GameObject sound1;
    public GameObject bou;
    public GameObject CamShakeToggle;
    public GameObject DissolveToggle;
    public GameObject DepthToggle;
    public GameObject TrailToggle;
    public GameObject SoundToggle;
    public GameObject BouToggle;
    private void Start() {
        //shadedEnv.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown("m")){
            if (!GlobalVars.persistentSound){
                GlobalVars.persistentSound = true;
                pbgm.TurnItOn();
                if (GlobalVars.soundEffect){
                    bgm.TurnItOff();
                }
            }
        }
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
        if(GlobalVars.lightingEffect){
            GlobalVars.lightingEffect = false;
            shadedEnv.SetActive(false);
            unshadedEnv.SetActive(true);
        } else {
            GlobalVars.lightingEffect = true;
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
            if (!GlobalVars.persistentSound){
                bgm.TurnItOff();
            }
            //bgm.TurnItOff();
        }
        else
        {
            if (!GlobalVars.persistentSound){
                bgm.TurnItOn();
            }
            GlobalVars.soundEffect = true;

           //bgm.TurnItOn();
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

    public void All(){
        CamShakeToggle.GetComponent<Toggle>().isOn = !CamShakeToggle.GetComponent<Toggle>().isOn;
        DissolveToggle.GetComponent<Toggle>().isOn = !DissolveToggle.GetComponent<Toggle>().isOn;
        DepthToggle.GetComponent<Toggle>().isOn = !DepthToggle.GetComponent<Toggle>().isOn;
        TrailToggle.GetComponent<Toggle>().isOn = !TrailToggle.GetComponent<Toggle>().isOn;
        SoundToggle.GetComponent<Toggle>().isOn = !SoundToggle.GetComponent<Toggle>().isOn;
        BouToggle.GetComponent<Toggle>().isOn = !BouToggle.GetComponent<Toggle>().isOn;
        
        // Bou();
        // Sound();
        // Trail();
        // Depth();
        // Dissolve();
        // CameraShake();

    }
}
