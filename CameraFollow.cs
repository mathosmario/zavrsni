using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPositon;
    public Vector3 offset;
  
    void Update()
    {
        transform.position = playerPositon.position + offset;
    }
}
