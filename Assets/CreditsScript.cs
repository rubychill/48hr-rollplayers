﻿using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.JoystickButton1)) {
			Application.LoadLevel(1);
		}
	}
}
