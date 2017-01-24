using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickParaAndar : MonoBehaviour {

	// Use this for initialization
	public Vector3 posicionInicial;
	bool inicio = true;

	void Start () {
		this.transform.position = posicionInicial;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray, out hit)){
				if(hit.rigidbody != null){
					MovimientoContinuo.posicionALaQueSeMovera = hit.point;

				}

			}
		}
	}
}
