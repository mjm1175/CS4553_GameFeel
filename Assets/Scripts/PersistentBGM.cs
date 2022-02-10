using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentBGM : MonoBehaviour
{
    private static GameObject instance;

    //private bool currentlyOn = false;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null){
            instance = gameObject;
        } else {
            Destroy(gameObject);
        }            
    }

    /*private void Update() {
        if (GlobalVars.soundEffect && !currentlyOn){
            gameObject.SetActive(true);
            currentlyOn = true;
        }
        else if (!GlobalVars.soundEffect && currentlyOn){
            gameObject.SetActive(false);
            currentlyOn = false;
        }
    }*/

    public void TurnItOn(){
        gameObject.SetActive(true);
    }

    public void TurnItOff(){
        gameObject.SetActive(false);
    }
}
