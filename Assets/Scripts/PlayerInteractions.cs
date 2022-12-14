using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    HealthManager hm;

    // Start is called before the first frame update
    void Start()
    {
        hm = gameObject.GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the player collides with an enemy they lose health
        if (collision.gameObject.tag == "Enemy")
        {
            //gets rid of the camera's parent when the player dies
            if(hm.currentHealth == 1)
            {
                Camera.main.transform.SetParent(null);
            }
            hm.loseHealth();
        } 
    }
}
