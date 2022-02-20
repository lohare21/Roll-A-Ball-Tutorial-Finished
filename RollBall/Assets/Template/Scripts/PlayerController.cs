using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }
    void OnMove(InputValue movementValue)
    {
       Vector2 movementvector = movementValue.Get<Vector2>(); 

       movementX = movementVector.x;
       movementY = movementVector.y;



    void FixUpdate()
    {
        Vector3 movment = new Vector3(movementX, 0.0f, movementY);
        
        rb.AddForce(movement);
    }
}