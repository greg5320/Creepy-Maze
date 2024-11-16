using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

using Unity.VisualScripting;
public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения вверх
    public SUPERCharacterAIO player;
    public bool inside = false;
    public AudioSource sound;
    void Start()
    {
        player = GetComponent<SUPERCharacterAIO>();
        inside = false;
        sound = GetComponent<AudioSource>();

    }



    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Ladder")
        {
            Debug.Log("TouchingLadderTrue");
            sound.enabled = true;
            sound.Play();
            sound.loop = true;
            player.enabled = true;
            GetComponent<Rigidbody>().useGravity = false;
            inside = !inside;
        }


    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Ladder")
        {
            Debug.Log("TouchingLadderFalse");
            player.enabled = true;
            sound.enabled = false;
            sound.Stop();
            sound.loop = false;
            GetComponent<Rigidbody>().useGravity = true;
            inside = !inside;
        }


    }


    // Метод Update вызывается один раз за кадр
    void Update()
    {
        if (inside == true)
        {
            


            if (Input.GetKey("w"))
            {

                Vector3 targetPosition = transform.position + Vector3.up * moveSpeed * Time.deltaTime;

                // Перемещаем персонаж к новой позиции постепенно
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
                sound.enabled = true;
                
                sound.loop = true;
            }
            else
            {
                player.enabled = true;
                sound.enabled = false;
                
            }
            if (Input.GetKey("a"))
            {
                Vector3 targetPosition = transform.position - transform.right * moveSpeed / 4 * Time.deltaTime;

                // Перемещаем персонаж к новой позиции постепенно
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey("s"))
            {
                Vector3 targetPosition = transform.position - Vector3.up * moveSpeed * Time.deltaTime;

                // Перемещаем персонаж к новой позиции постепенно
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }


            // Если персонаж находится внутри и нажата клавиша "D" для движения вправо
            if (Input.GetKey("d"))
            {
                Vector3 targetPosition = transform.position + transform.right * moveSpeed / 4 * Time.deltaTime;

                // Перемещаем персонаж к новой позиции постепенно
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            }

        }
       
    }
}
