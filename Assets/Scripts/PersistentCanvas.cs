using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentCanvas : MonoBehaviour
{
    private static GameObject instance;

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
}
