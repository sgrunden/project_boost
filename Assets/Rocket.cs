﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidBody;
	
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	

	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up); // always in the direction that the ship is facing
            print("Space Pressed.");
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Rotating Left.");
        }
        if (Input.GetKey(KeyCode.D))
        {
            print("Rotating Right.");
        }
    }
}
