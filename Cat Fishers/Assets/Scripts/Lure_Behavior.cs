using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lure_Behavior : MonoBehaviour {

    //rigid body variable to control velocity of lure
    private Rigidbody2D rb;
    //to keep velocity constant
    public float velocity;
    //deals with lure side to side movement
    public float speed;
    //to access hingejoin
    private HingeJoint2D j;
    //for replacing cats
    public Sprite BigCatChange;
    public Sprite MedCatChange;
    public Sprite SmaCatChange;

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
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = BigCatChange;
            collision.gameObject.GetComponent<Cat_Behavior>().enabled = false;
            j.connectedBody = rb.GetComponentInChildren<Rigidbody2D>();
            //to-do: account for weight of cat subtract mass by .0075
        }
        if (collision.gameObject.CompareTag("Attach Med Cat"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = MedCatChange;
            collision.gameObject.GetComponent<Cat_Behavior>().enabled = false;
            j.connectedBody = rb.GetComponentInChildren<Rigidbody2D>();
            //to-do: account for weight of cat subtract mass by .0075
        }
        if (collision.gameObject.CompareTag("Attach Sma Cat"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = SmaCatChange;
            collision.gameObject.GetComponent<Cat_Behavior>().enabled = false;
            j.connectedBody = rb.GetComponentInChildren<Rigidbody2D>();
            //to-do: account for weight of cat subtract mass by .0075
        }

    }


}
