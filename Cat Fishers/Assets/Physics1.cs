using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics1 : MonoBehaviour {
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 10.0f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * -speed * Time.deltaTime;
        }

         if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * +speed * Time.deltaTime;
        }

         
    }


}
