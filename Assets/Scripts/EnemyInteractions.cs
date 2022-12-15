using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    HealthManager hm;
    Animator animator;
    public GameObject[] projectiles;
    static public int slimesKilled = 0;
    //public GameObject winText;

    // Start is called before the first frame update
    private void Awake()
    {
        hm = gameObject.GetComponent<HealthManager>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //jack k did some stuff when trying to fix my collision i dunno what 
        projectiles = GameObject.FindGameObjectsWithTag("Projectile");
        foreach (GameObject projectile in projectiles)
        {
            //Debug.Log(projectile.transform.position.x + " " + projectile.transform.position.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if an enemy touches a slime, play hit animation and call losehealth funtion from HealthManager
        if (collision.gameObject.tag == "Projectile")
        {
            hm.loseHealth();
            animator.SetBool("Hit", true);
            if (hm.currentHealth == 0)
            {
                //adds to the slime kill count
                ++slimesKilled;
            }
        }
    }

}
