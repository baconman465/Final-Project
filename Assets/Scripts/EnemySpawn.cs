using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] slimes;
    public GameObject slime;
    System.Random randx = new System.Random();
    System.Random randy = new System.Random();
    int slimeamount;

    // Start is called before the first frame update
    void Start()
    {
        slimes = GameObject.FindGameObjectsWithTag("Enemy");

        slimeamount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        slimes = GameObject.FindGameObjectsWithTag("Enemy");

        //if there are no slimes then some spawn in random positions
        if(slimes.Length == 0)
        {
            for (int i = 0; i < slimeamount; i++)
            {
                float randomx = randx.Next(-20, 20);
                float randomy = randy.Next(-12, 12);
                //sets spawn point of slimes relative to the camera position
                slime.transform.position = new Vector2(randomx + Camera.main.transform.position.x, randomy + Camera.main.transform.position.y);
                Instantiate(slime);
            }
            //the amount of slimes spawned increases by 3 after each wave
            slimeamount = slimeamount + 3;
        }
        
    }
}
