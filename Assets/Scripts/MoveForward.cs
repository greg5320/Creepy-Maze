using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float time = 0.0f;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = transform.position+Vector3.forward*20;
    }

    
    void Update()
    {
        transform.position = Vector3.Lerp(startPosition, targetPosition, time);
        time += Time.deltaTime;
    }
}
