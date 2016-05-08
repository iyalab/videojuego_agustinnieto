using UnityEngine;
using System.Collections;

public class MoverCometa : MonoBehaviour {
	
	public float velocidad;
	private GameObject control; 

	void Start () {
		control = GameObject.Find("control");
		velocidad = control.GetComponent<ControlJuego>().velocidadCometas;
	}

	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * velocidad, Space.World);
	}
}
