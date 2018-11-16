using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovment : MonoBehaviour {

    public GameObject VRhand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = VRhand.transform.position;         //Code without locked axis
       // transform.position.x = VRhand.position.x;       //Code with locked axis
        //transform.position.y = VRhand.position.y;       //Code with locked axis

	}
}
