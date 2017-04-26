using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public int vel;
	void Start () {
        transform.Translate(Vector3.right * Time.deltaTime * vel);
    }
	
	void Update () {
        if (transform.position.x < -4)
            transform.Translate(Vector3.right * Time.deltaTime * vel);
        if (transform.position.x > 4)
            transform.Translate(-Vector3.right * Time.deltaTime * vel);
    }
}
