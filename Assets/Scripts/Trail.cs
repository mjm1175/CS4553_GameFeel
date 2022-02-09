using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    public GameObject prefab;

    private IEnumerator TrailCor;
    // Start is called before the first frame update
    void Start()
    {
        TrailCor = trail();
        StartCoroutine(TrailCor);
    }
    
    
    public IEnumerator trail()
    {
        while (true)
        {
            if (GlobalVars.trailEffect){
                for (int i = 1; i < 5; i++)
                {
                    GameObject s = Instantiate(prefab);
                    s.transform.position = this.transform.position;
                    s.transform.localScale = this.transform.localScale / i;
                    Destroy(s,0.1f);
                    yield return new WaitForSeconds(0.02f);
                }                
            }

            yield return new WaitForSeconds(0.1f);
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Finish"))
        {
            StopCoroutine(TrailCor);
        }
    }

    void update()
    {
        if (!GlobalVars.trailEffect)
        {
            StopCoroutine(TrailCor);
        }
    }
}
