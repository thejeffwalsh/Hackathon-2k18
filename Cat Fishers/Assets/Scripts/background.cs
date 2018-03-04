using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {

    public Renderer rend;
    Vector3 Startpos;
    float yS;

    void Start()
    {
        rend = GetComponent<Renderer>();
        Startpos = transform.position;
        yS = transform.position.y;


    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= (3 * rend.bounds.size.y) - 40.5)
        {
            //transform.position = transform.position+Vector3.down+Vector3.down;
            //float newPosition = Mathf.Repeat(Time.time * 8.2f, 0);
            transform.position = new Vector3(transform.position.x, -39, transform.position.z);
        }
    }
}
