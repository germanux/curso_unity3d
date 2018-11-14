using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour {

    public const int NUMERO_DE_FILAS = 6;
    public bool terminado;
    [Range(1, 10)]
    public float timeInterval = 3;
    public Texture2D imagenNivel;
    [HideInInspector]
    public int numeroEnemigos;
    public float timer;
    public Enemigo[] enemigos;

    private int columna = 0;

	// Use this for initialization
	void Start () {
        terminado = false;
        numeroEnemigos = 0;
	}	
	// Update is called once per frame
	void Update () {
		if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timer = timeInterval;
            LeerImagenNivel(columna);
            columna++;
        }
	}
    void LeerImagenNivel(int columna)
    {
        for (int fila = 0; fila < NUMERO_DE_FILAS; fila++)
        {
            int filaEnTextura = fila; // NUMERO_DE_FILAS - fila - 1;
            Color colorPixel = imagenNivel.GetPixel(columna, filaEnTextura);
            // Si no es un pixel blanco buscamos el enemigo
            if ( ! colorPixel.Equals(new Color(1f, 1f, 1f)))
            {
                Enemigo enemigo = EnemigoConColor(colorPixel);
                CrearEnemigo(enemigo, fila);
            }
        }
    }

    Enemigo EnemigoConColor(Color color)
    {
        foreach (Enemigo enem in enemigos)
        {
            if (enem.color.r == color.r &&
                enem.color.g == color.g &&
                enem.color.b == color.b)
            {
                return enem;
            }
        }
        Debug.LogError("No se ha encontrado este color " + color.ToString());
        return null;
    }
    void CrearEnemigo(Enemigo enemigo, int fila)
    {
        if (enemigo == null)
            return;

        numeroEnemigos++;
        Vector3 posicion = new Vector3(10, fila * 4 - 4, 0);
        GameObject nuevoEnem = Instantiate<GameObject>(enemigo.prefab, posicion, Quaternion.identity);
        nuevoEnem.name = enemigo.prefab.name + " " + numeroEnemigos.ToString();
        nuevoEnem.AddComponent<MovimientoEnemigo>();
        nuevoEnem.GetComponent<MovimientoEnemigo>().velocidad = enemigo.velocidad; //TODO: Modif
        nuevoEnem.transform.Rotate(0, -90, 0);
    }
}
