using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RotateArm : MonoBehaviour
{
    float defaultx, defaulty;
    float playerx, playery;
    float armx, army;
    float rotation;
    float targetx, targety;
    Vector2 cursorpos;

    // Start is called before the first frame update
    void Start()
    {
        //arm position is relative to player position

        playerx = transform.parent.position.x;
        playery = transform.parent.position.y;

        defaultx = playerx + 0.496f;
        defaulty = playery + 0.144f;

        rotation = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        playerx = transform.parent.position.x;
        playery = transform.parent.position.y;
        defaultx = playerx + 0.239f;
        defaulty = playery + 0.104f;

        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.position = new Vector3(defaultx, defaulty);

        //rotate the arm 180 degrees if the player is moving left
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.rotation = Quaternion.AngleAxis((angle+180), Vector3.forward);
            transform.position = new Vector3((playerx-0.239f) - 0.02f, defaulty - 0.04f);
        }
    }
}
