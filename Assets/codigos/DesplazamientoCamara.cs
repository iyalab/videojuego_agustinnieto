using UnityEngine;
using System.Collections;

public class DesplazamientoCamara : MonoBehaviour {

	public Transform jugador;

	void Update()
	{
		transform.position = new Vector3 (transform.position.x, jugador.position.y, -10);
	}
}
