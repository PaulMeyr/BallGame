using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Collider gameObjectCollider;
    // Use this for initialization
    void Start () {
        gameObjectCollider = GetComponent<Collider>();
        gameObjectCollider.attachedRigidbody.AddForce(0f, -100f,1f * -30);
    }
	
	
	
}
