using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {

    public GameObject lure;
    

    private Vector3 offset;

	// Use this for initialization
	void Start () {

        offset = transform.position - lure.transform.position;

	}
	
	// Update is called once per frame
	private void LateUpdate () {

        transform.position = lure.transform.position + offset;
	}
}
