using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rigidBod;
    float speed = 2;
    bool isJumping = false;
    int jumpCount = 2;



    float distToGround;
 

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.001f);
    }
    // Start is called before the first frame update
    void Start()
    {
        // get the distance to ground
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Forward") != 0)
        {
            rigidBod.AddForce(Vector3.forward * speed * Input.GetAxis("Forward"), ForceMode.Impulse);
        }
        if (Input.GetAxis("Sideways") != 0)
        {
            rigidBod.AddForce(Vector3.right * speed * Input.GetAxis("Sideways"), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            rigidBod.AddForce(Vector3.up * 60,  ForceMode.Impulse);

        }


    }
}
