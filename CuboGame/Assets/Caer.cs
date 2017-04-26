using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caer : MonoBehaviour {
    Rigidbody rgb;
    Mover mov;

    void Start () {
        rgb = GetComponent<Rigidbody>();
        mov = GetComponent<Mover>();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            rgb.useGravity = true;
            mov.enabled = false;
        }
	}
}
