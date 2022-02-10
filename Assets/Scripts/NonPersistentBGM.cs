using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPersistentBGM : MonoBehaviour
{
    public void TurnItOn(){
        gameObject.SetActive(true);
    }

    public void TurnItOff(){
        gameObject.SetActive(false);
    }
}
