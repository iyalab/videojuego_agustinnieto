using UnityEngine;
using System.Collections; 
using UnityEngine.UI;

public class CantidadBalas : MonoBehaviour {

	private GameObject jugador;
	
	void Start () {
		jugador = GameObject.Find("jugador");
	}
	
	void Update () {
		GetComponent<Text>().text = "X " + jugador.GetComponent<Nave>().cantidadBalas;
	}
}
