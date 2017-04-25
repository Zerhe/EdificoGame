using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caer : MonoBehaviour {
    Rigidbody rgb;
	void Start () {
        rgb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            rgb.useGravity = true;
        }
	}
}
