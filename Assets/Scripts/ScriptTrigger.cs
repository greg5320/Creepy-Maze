using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTrigger : MonoBehaviour
{

    public GameObject screamer;
    public bool active = false;
    public string nameTag;
    public float time = 1f;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(nameTag))
        {
            screamer.SetActive(active);
            StartCoroutine(DestroyObject(time));

        }
    }

    IEnumerator DestroyObject(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(screamer);
    }
}
