using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillTextManager : MonoBehaviour
{
    public GameObject slime;
    int slimesKilled;
    string slimeKillCount;
    TextMeshProUGUI TMP;

    // Start is called before the first frame update
    void Start()
    {
        TMP = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //sets the slimes killed textbox to show how many slimes have been killed
        TMP.text = "Slimes Killed: " + EnemyInteractions.slimesKilled.ToString();
    }
}
