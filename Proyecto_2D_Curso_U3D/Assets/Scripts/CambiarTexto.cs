using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarTexto : MonoBehaviour {

    int i;

	// Use this for initialization
	void Start ()
    {
        GetComponent<UnityEngine.UI.Text>().text = "<b>Cambiando</b> texto";
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Numero: " + i;
        transform.position = new Vector3(i, 0, 0);
        i++;
	}
    public void BotonPulsado()
    {
        i = 0;
    }
}
