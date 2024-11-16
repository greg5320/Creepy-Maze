using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingManagerGame : MonoBehaviour
{
    public Slider slider;
    public GameObject menuPanel; 

    private bool isMenuOpen = false; 

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (!isMenuOpen)
            {
                OpenMenu();
            }
            
            else
            {
                CloseMenu();
            }
        }
    }

    
    void OpenMenu()
    {
        isMenuOpen = true;
        Cursor.visible = isMenuOpen;
        Cursor.lockState = CursorLockMode.None;
        menuPanel.SetActive(true); 
        
       
    }

    
    void CloseMenu()
    {
        isMenuOpen = false;
        Cursor.visible = isMenuOpen;
        Cursor.lockState = CursorLockMode.Locked;
        menuPanel.SetActive(false); 
        
    }
    public void Sensitivity()
    {
        SUPERCharacterAIO.Sensitivity = slider.value;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
