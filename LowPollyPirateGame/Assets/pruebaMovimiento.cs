﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaMovimiento : MonoBehaviour {

	public GameObject cube;
	Vector3 posicionObjetivo;
	// Use this for initialization
	void Start () {
		posicionObjetivo = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				posicionObjetivo = hit.point;
				cube.transform.Translate (posicionObjetivo * Time.deltaTime, Space.World);
			
			}
		}
	}
}
