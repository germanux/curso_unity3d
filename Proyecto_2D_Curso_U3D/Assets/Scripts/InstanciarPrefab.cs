using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPrefab : MonoBehaviour {

    public GameObject prefabCilindro;
    public GameObject spawner;
    public Vector3 posicion;
    public bool cambiarColor;
    public Color colorCilindro;

    public void InstanciarCilindro()
    {
        GameObject cilindroCreado;
        cilindroCreado = Instantiate<GameObject>(prefabCilindro);
        if ( spawner) // spawner != null
        {
            cilindroCreado.transform.position = spawner.transform.position;
            cilindroCreado.transform.parent = spawner.transform;
            // int numHermanos = spawner.transform.childCount;
            int numHermanos = cilindroCreado.transform.parent.childCount;
            cilindroCreado.transform.localPosition = new Vector3(0, 0, numHermanos * 3f);
        } else
        {
            cilindroCreado.transform.position = posicion;
        }
        if (cambiarColor)
        {
            cilindroCreado.GetComponent<Renderer>().material.color = colorCilindro;
        }
    }
}
