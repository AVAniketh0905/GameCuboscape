using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float forwardForce = 10;
    public float sideForce = 1;

    private void FixedUpdate()
    {
        rigidBody.AddForce(0,0,forwardForce*Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sideForce/10*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("d"))
        {
            rigidBody.AddForce(sideForce/10*Time.deltaTime,0,0,ForceMode.VelocityChange);
        } 

        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
