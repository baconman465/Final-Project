using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthTextManager : MonoBehaviour
{
    public GameObject player;
    HealthManager playerHealth;
    int playerHealthAmount;
    string healthText;
    TextMeshProUGUI TMP;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = player.GetComponent<HealthManager>();
        TMP = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthAmount = playerHealth.currentHealth;
        healthText = playerHealthAmount.ToString();

        TMP.text = "Health: " + healthText;
    }
}
