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
        if (Input.GetAxis("Vertical") != 0)
        {
            rigidBod.AddForce(Vector3.forward * speed * Input.GetAxis("Vertical"), ForceMode.Impulse);
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            rigidBod.AddForce(Vector3.right * speed * Input.GetAxis("Horizontal"), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            rigidBod.AddForce(Vector3.up * 80,  ForceMode.Impulse);

        }

        rigidBod.AddForce(-Vector3.up * 100, ForceMode.Acceleration);
    }
}
