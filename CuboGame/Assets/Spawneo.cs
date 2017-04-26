using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawneo : MonoBehaviour {
    public GameObject objToSpawn;
    public Transform transObj;
    public int vel;

	void Start () {
        Instanciar();
	}

	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * vel);
            Instanciar();
        }
    }
    void Instanciar()
    {
        GameObject instanciado = (GameObject)Instantiate(objToSpawn, transform.position, transform.rotation);
    }
}
