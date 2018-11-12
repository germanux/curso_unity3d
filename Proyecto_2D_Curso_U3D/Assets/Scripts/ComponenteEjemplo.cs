using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteEjemplo : MonoBehaviour {

    public float posicionX = 2.0f;

	// Use this for initialization
	void Start () {
        Debug.Log("Hola mundo!"); 
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(posicionX, 0, 0);
	}
}
