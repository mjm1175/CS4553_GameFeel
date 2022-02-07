using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shaketime = 0.5f;

    public Transform player;
    // Start is called before the first frame update
    public IEnumerator shake()
    {
        Debug.Log("hwllo");
        Vector2 originalPos = transform.localPosition;
        float elapse = 0.0f;
        while (elapse < shaketime)
        {
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-1f, 1f);
            transform.localPosition = new Vector3(x+ player.position.x, y + player.position.y, -1) ;
            elapse += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = originalPos;
    }

    
}
