using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Behavior : MonoBehaviour {

    private bool rightDir;
    public float speed;
    public float velocity;

    private Rigidbody2D rb;
    private HingeJoint2D joint;

    // Use this for initialization
    void Start()
    {
        rightDir = true;
        joint = GetComponent<HingeJoint2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (rightDir == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.Translate(Vector2.up * velocity * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            transform.Translate(Vector2.up * velocity * Time.deltaTime);
        }
        if (transform.position.x >= 7.0f)
        {
            rightDir = false;
        }
        if (transform.position.x <= -7.0f)
        {
            rightDir = true;
        }

        //rb.velocity = new Vector2(0, velocity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Cucumber"))
        {
            collision.gameObject.SetActive(false);
            joint.enabled = false;

        }


    }
}
