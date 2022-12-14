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
        if (collision.gameObject.tag == "Enemy")
        {
            hm.loseHealth();
        } 
    }
}
