using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

	private Rigidbody2D myRigidbody;

	void Awake () {
		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	void Start () {
		myRigidbody.AddRelativeForce (Vector2.right * 1000);
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.name == "destroy") {
			Destroy (gameObject);
		}
	}
}
