using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovingSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public string nameTag;
    public bool destr = false;
    public float time = 1f;
    private bool hasPlayed = false;
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(nameTag))
        {
            if (!hasPlayed)
            {
                source.PlayOneShot(clip);
                hasPlayed = true;
                if (destr == true)
                {
                    StartCoroutine(DestroyObject(time));
                }
            }
        }

    }
    IEnumerator DestroyObject(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
