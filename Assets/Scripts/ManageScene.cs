using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    private float timeElapsed = 0;
    public float timeTilRestart = 15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > timeTilRestart){
            GlobalVars.ResetVars();
            SceneManager.LoadScene("2DPlatformer");
        }
    }
}
