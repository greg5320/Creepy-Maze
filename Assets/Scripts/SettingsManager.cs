using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class SettingsManager : MonoBehaviour
{
    public Slider slider;
    //public SUPERCharacterAIO t;
    //public GameObject setting;
    //public bool issettingactive;
    
    public void Start()
    {

        //SUPERCharacterAIO.Sensitivity = slider.value;
        //t.Sensitivity = EditorGUILayout.Slider(new GUIContent("Mouse Sensitivity", "Sensitivity of the mouse"), t.Sensitivity, 1, 100);
    }

    public void Update()
    {

    }
    public void Sensitivity()
    {
        SUPERCharacterAIO.Sensitivity = slider.value;
    }

}


