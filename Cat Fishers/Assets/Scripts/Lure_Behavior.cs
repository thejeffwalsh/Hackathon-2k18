using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lure_Behavior : MonoBehaviour {

    //rigid body variable to control velocity of lure
    private Rigidbody2D rb;
    public float velocity;
    public float speed;

    private HingeJoint2D j;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //moving lure
        float moveLeftRight = Input.GetAxis("Horizontal");


        Vector2 movement = new Vector2(moveLeftRight, 0);
        rb.AddForce(movement * speed);

        //controlling velocity of falling lure
        rb.velocity = new Vector2(0, velocity);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        j = collision.gameObject.GetComponent<HingeJoint2D>();
        if (collision.gameObject.CompareTag("Attach Big Cat"))
        {
            //j.anchor.Equals(rb.gameObject.transform.position);
            //j.connectedBody = rb;
            //j.connectedAnchor = rb.transform.position;
            collision.gameObject.GetComponent<SideToSide>().enabled = false;
            //collision.gameObject.transform.parent = rb.gameObject.transform;
            j.connectedBody = rb.GetComponentInChildren<Rigidbody2D>();

            //j.connectedBody = rb;
            

            //collision.gameObject.SetActive(false);
        }

    }


}
