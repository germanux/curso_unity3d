using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPrefab : MonoBehaviour {

    public GameObject cilindro;
    public Vector3 posicion;

    public void InstanciarCilindro()
    {
        GameObject cilindroCreado;
        cilindroCreado = Instantiate<GameObject>(cilindro);
        cilindroCreado.transform.position = posicion;
    }
}
