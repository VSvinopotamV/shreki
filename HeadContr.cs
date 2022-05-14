using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadContr : MonoBehaviour
{
     //повороты головой и телом по мышке
    float xRotation = 0f; 
    public Transform playerBody;
    
    void Start()
    {
        
    }


    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*2f;
        
        
        playerBody.Rotate(0,mouseX,0);
        
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation,0,0);

    }
}
