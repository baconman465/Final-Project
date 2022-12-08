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
        List<GameObject> bolts = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            projectileClass bolt = new projectileClass();
            Instantiate<GameObject>(magicBolt, firePoint);
            magicBolt.transform.SetParent(null);
            magicBolt.transform.rotation = new Quaternion(0, 0, 0, 0);
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                
                magicBolt.transform.rotation = new Quaternion(0, 0, 180, 0);
            }
        }
            
    }

   
}
