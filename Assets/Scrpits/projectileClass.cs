using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileClass : MonoBehaviour
{
    public float speed;
    public float rotation;
    public Vector3 velocity;
    float timer;
    public float lifetime;

    // Start is called before the first frame update
    void Start()
    {
        transform.SetParent(null);
        timer = lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Mathf.Cos(rotation * Mathf.Deg2Rad), Mathf.Sin(rotation * Mathf.Deg2Rad)) * Time.deltaTime * speed + velocity * Time.deltaTime);

        timer -= Time.deltaTime;
        if(timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
