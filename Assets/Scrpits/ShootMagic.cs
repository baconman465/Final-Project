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
        //instantiate a magic bolt prefab when left mouse button is clicked
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //flip the bolt if the player is moving left
             if (Input.GetAxisRaw("Horizontal") < 0)
            {
                magicBolt.transform.rotation = new Quaternion(0, 0, 180, 0);
            }
            else
            {
                magicBolt.transform.rotation = new Quaternion(0, 0, 0, 0);
            }
            //instantiate a magic bolt prefab at the firepoint
            Instantiate<GameObject>(magicBolt, firePoint);
            //remove the magic bolt from its parent
            magicBolt.transform.SetParent(null);
           
        }
            
    }

   
}
