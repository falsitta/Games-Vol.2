using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    [SerializeField]
    Transform bulletSocket;

    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    float attackRate;

    public List<GameObject> visibleEnemies;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (visibleEnemies.Count > 0)
        {
            //create bullet here, pass in enemy transform to give bullet direction
            

        }
    }

    void Attack()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSocket.position, Quaternion.identity, gameObject.transform);
        bullet.GetComponent<Bullet>().SetTarget(visibleEnemies[0].transform);
        print("bullet should be spawning");
        //add this to the bullet, pass enemy transform there
        //bullet.transform.position = Vector3.MoveTowards(enemy[0]);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
            visibleEnemies.Add(other.gameObject);
            InvokeRepeating("Attack", 0.3f, attackRate);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            visibleEnemies.Remove(other.gameObject);
            CancelInvoke("Attack");
        }

    }
}
