using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rigidBod;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Forward") != 0)
        {
            rigidBod.AddForce(transform.forward * speed * Input.GetAxis("Forward"), ForceMode.Impulse);
        }
        if (Input.GetAxis("Sideways") != 0)
        {
            rigidBod.AddForce(transform.right * speed * Input.GetAxis("Sideways"), ForceMode.Impulse);
        }
    }
}
