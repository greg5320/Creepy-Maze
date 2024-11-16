using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalEscape : MonoBehaviour
{
    public GameObject FinalPanel;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.None;
    }

    
    void Update()
    {
        
    }
    public void Menu()
    {
        //Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Menu");
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            FinalPanel.SetActive(true);
            StartCoroutine(DisplayPlane(5));
        }
    }
    IEnumerator DisplayPlane(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Menu");
    }
}
