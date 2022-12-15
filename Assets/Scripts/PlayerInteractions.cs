using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    HealthManager hm;
    public int health;
    public GameObject skillIssue, winText;

    // Start is called before the first frame update
    void Start()
    {
        hm = gameObject.GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        health = hm.currentHealth;

        //if 100 slimes have been killed, show win text and stop the game
        if(EnemyInteractions.slimesKilled == 100)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
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
                skillIssue.gameObject.SetActive(true);
            }
            hm.loseHealth();
        } 
    }
}
