﻿using UnityEngine;
using System.Collections;

public class Grabbable : MonoBehaviour {
	Collider2D myCollider;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		myCollider = GetComponent<Collider2D> ();
		rb = GetComponent<Rigidbody2D> ();
		rb.gravityScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void grabObject(){
		myCollider.enabled = false;
	}

	public void dropObject(){
		myCollider.enabled = true;
		rb.gravityScale = 3;
	}
}
