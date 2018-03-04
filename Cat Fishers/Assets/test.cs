using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
    public Renderer rend;
    Vector3 Startpos;

    void Start()
    {
        rend = GetComponent<Renderer>();
        Startpos = transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= (3*rend.bounds.size.y)-40.5)
        {              //value of - 10.5 makes it -10 as y
            transform.position = new Vector3(transform.position.x, -30, transform.position.z);
            //float newPosition = Mathf.Repeat(Time.time * 8.2f, 0);
            // transform.position = Startpos;
        }
    }
}
