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
    EnemyInteractions ei;
    TextMeshProUGUI TMP;

    // Start is called before the first frame update
    void Start()
    {
        ei = slime.GetComponent<EnemyInteractions>();
        TMP = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        slimesKilled = ei.slimesKilled;
        slimeKillCount = slimesKilled.ToString();
        TMP.text = "Slimes Killed: " + slimeKillCount;
    }
}
