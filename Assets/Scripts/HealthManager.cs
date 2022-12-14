using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth, currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loseHealth()
    {
        --currentHealth;
        if(currentHealth == 0) { Destroy(gameObject); }
    }

    public void gainHealth()
    {
        if (currentHealth == maxHealth) { }
        else { ++currentHealth; }
    }
}
