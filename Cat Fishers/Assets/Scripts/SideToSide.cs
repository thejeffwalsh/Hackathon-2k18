using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour {

    private bool rightDir;
    public float speed;

	// Use this for initialization
	void Start () {
        rightDir = true;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (rightDir == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }
        if (transform.position.x >= 6.0f)
        {
            rightDir = false;
        }
        if (transform.position.x <= -6.0f)
        {
            rightDir = true;
        }
	}

    
}
