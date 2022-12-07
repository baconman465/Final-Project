using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMagic : MonoBehaviour
{
    public GameObject magicBolt;
    public GameObject player;
    public Transform firePoint;
    Transform playerpos;
    Vector2 boltSpawnPoint;
    Rigidbody2D boltRb;

    // Start is called before the first frame update
    void Start()
    {
        /*playerpos.x = transform.position.x;
        playerpos.y = transform.position.y;*/
    }

    // Update is called once per frame
    void Update()
    {
        /*playerpos.x = transform.position.x;
        playerpos.y = transform.position.y;*/

        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            projectileClass bolt = new projectileClass();
            Instantiate<GameObject>(magicBolt, firePoint);
            magicBolt.transform.SetParent(null);

            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                bolt.speed = bolt.speed * -1;
            }
        }
    }

   
}
