using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMagic : MonoBehaviour
{
    public GameObject magicBolt;
    float playerposx, playerposy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerposx = transform.position.x;
        playerposy = transform.position.y;
    }

    private void shootMagic()
    {
        Instantiate<GameObject>(magicBolt, new Vector3(0, 0, 0));
    }

    private void OnMouseDown()
    {
        
    }
}
