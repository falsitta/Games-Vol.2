using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        //target = transform;
        //FindTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
           transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime* 10);

        }
    }

    public Transform FindTarget()
    {
        //set target to travel towards here
        if (target == null)
        {
            SetTarget(target);
        }
        else
        {
        }

            return target;
    }


    public void SetTarget(Transform _target)
    {
        //set target to travel towards here
        target = _target;
    }
}
