using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproductorSonido : MonoBehaviour {

    public AudioSource audio;
    public float volumen;

	// Use this for initialization
	public void Play()
    {
        audio.volume = volumen;
        audio.Play(500);
    }
}
