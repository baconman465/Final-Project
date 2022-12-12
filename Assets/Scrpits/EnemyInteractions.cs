using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    HealthManager hm;
    public GameObject[] projectiles;

    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 0.1f;
        hm = gameObject.GetComponent<HealthManager>();
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        projectiles = GameObject.FindGameObjectsWithTag("Projectile");
        foreach (GameObject projectile in projectiles)
        {
            //Debug.Log(projectile.transform.position.x + " " + projectile.transform.position.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("poop");
        if (collision.gameObject.tag == "Projectile")
        {
            Debug.Log("hit");
            hm.loseHealth();
        }
    }

}
