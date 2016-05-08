using UnityEngine;
using System.Collections;

public class MovVerticalCoin : MonoBehaviour {
	
	private GameObject control;
	private float velocidadObstaculos;
	
	void Start () {
		control = GameObject.Find("control");
		velocidadObstaculos = control.GetComponent<ControlJuego>().velocidadObstaculos;
	}
	
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * velocidadObstaculos, Space.World);
	}
}
