using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour {

    public float velocidad;
    Vector3 vectorMov;
	// Use this for initialization
	void Start () {
        vectorMov = new Vector3(-velocidad, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += vectorMov * Time.deltaTime;
	}
}
