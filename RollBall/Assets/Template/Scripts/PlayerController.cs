errusing System.Collections;  
using System.Collections.Generic;  
using UnityEngine;
using UnityEngine.InputSystem;  
   
public class PlayerController : MonoBehaviour 
{
    private Rigidbody
    private float movementX;
    private float movementY;

    
    void start()
    {
        rb = GetComponent<Rigidbody>();
    }  
    

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementx, 0.0f, movementY);
        
        rb.AddForce(movementVector);
    }
}