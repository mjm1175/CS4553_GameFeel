using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(trail());
    }

    // void Update()
    // {
    //     GameObject s = Instantiate(prefab);
    //     s.transform.position = this.transform.position;
    //     Destroy(s,0.1f);
    // }
    
    public IEnumerator trail()
    {
        while (true)
        {
            for (int i = 1; i < 5; i++)
            {
                GameObject s = Instantiate(prefab);
                s.transform.position = this.transform.position;
                s.transform.localScale = this.transform.localScale / i;
                Destroy(s,0.1f);
                yield return new WaitForSeconds(0.02f);
            }
            yield return new WaitForSeconds(0.1f);
        }
        
        yield return new WaitForSeconds(0.5f);
        
    }
}
