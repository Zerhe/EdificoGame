using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawneo : MonoBehaviour {
    public GameObject objToSpawn;
    public int vel;
	void Start () {
        Instanciar();
	}

	void Update () {

	}
    void Instanciar()
    {
        Instantiate(objToSpawn, transform.position, transform.rotation);   
    }
    void OnTriggerExit()
    {
        transform.Translate(Vector3.up * Time.deltaTime * vel);
        Instanciar();
    }
}
