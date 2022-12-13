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

    // Start is called before the first frame update
    void Start()
    {
        slimes = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        slimes = GameObject.FindGameObjectsWithTag("Enemy");

        //if there are no slimes then 5 spawn in random positions
        if(slimes.Length == 0)
        {
            for (int i = 0; i < 5; i++)
            {
                float randomx = randx.Next(-14, 14);
                float randomy = randy.Next(-6, 6);
                slime.transform.position = new Vector2(randomx, randomy);
                Instantiate(slime);
            }
        }
        
    }
}
