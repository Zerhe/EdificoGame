using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public int vel;
	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * vel);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * vel);
        }
    }
}
