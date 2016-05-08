using UnityEngine;
using System.Collections;

public class MoverObstaculo : MonoBehaviour {

	public GameObject borde_izq, borde_der;
	private float direccion = 1;
	public float velocidad = 1;
	
	private bool dirRight = true;
	public float speed = 0.05f;

	void Start () {
		borde_der = GameObject.Find("borde_der");
		borde_izq = GameObject.Find("borde_izq");
	}

	void Update () {

		//transform.Translate(direccion * Vector3.right * Time.deltaTime * velocidad, Space.World);

		//if(Mathf.Round(transform.position.x) == Mathf.Round(borde_der.transform.position.x) || Mathf.Round(transform.position.x) == Mathf.Round(borde_izq.transform.position.x)){
		//	direccion *= -1;
		//}
		
		//transform.position = Vector3.Lerp (borde_izq.transform.position.x, borde_der.transform.position.x, Mathf.PingPong(Time.time*speed, 0.05f));
		
		transform.position = Vector3.Lerp (borde_izq.transform.position.x, borde_der.transform.position.x, Mathf.Round((Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f));
		
		/*
		if (dirRight)
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		else
			transform.Translate (-Vector2.right * speed * Time.deltaTime);
		
		if(transform.position.x > borde_der.transform.position.x) {
			dirRight = false;
		}
		
		if(transform.position.x < borde_izq.transform.position.x) {
			dirRight = true;
		}
		*/ 
	}
}