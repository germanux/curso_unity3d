using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour {

    public string nombreEscena;

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene(nombreEscena);
	}
}
