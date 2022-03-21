using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour {

    [SerializeField] float upwardBounce = 10f;

    private void OnTriggerEnter(Collider other)
    {
       //if other collider is the player, then do something
       if(other.gameObject.CompareTag("Player"))
       {
           // Get the player's rigidbody
           Rigidbody playerRigidbody = other.gameObject.GetComponent<Rigidbody>();
           // if we found a rigidbody, apply the force
           if (playerRigidbody != null)
           {
               // apply a vertical velocity to the player
               playerRigidbody.velocity = new Vector3(0, upwardBounce, 0);

           }
       }
    }
}