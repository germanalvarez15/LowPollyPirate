using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoContinuo : MonoBehaviour {

	// Use this for initialization
	public static Vector3 posicionALaQueSeMovera;
	public float velocidad = 3f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float pasos = velocidad * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, posicionALaQueSeMovera, pasos);
		
	}
}
