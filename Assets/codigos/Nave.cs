using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {
	
	public float velocidadMax = 7.0f;
	public float velocidadCurva = 5.0f;
	public float tamanoDesplazamiento = 0.05f;
	public GameObject borde_izq, borde_der;
	public float smooth = 0.5F;
	public GameObject prefab_bala;
	public int cantidadBalas = 0;
	private GameObject control;

	void Start () {
	}
		
	void Update () {
		control = GameObject.Find("control");
		Quaternion target = Quaternion.Euler(0, 0, 0);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
	}

	public void irDerecha(){
		if(transform.position.x < borde_der.transform.position.x ){
			transform.position = new Vector3(transform.position.x + tamanoDesplazamiento, transform.position.y, transform.position.z);
			Quaternion target = Quaternion.Euler(0, 0, -90);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocidadCurva);
		}
	}

	public void irIzquierda(){
		if(transform.position.x > borde_izq.transform.position.x){
			transform.position = new Vector3(transform.position.x - tamanoDesplazamiento, transform.position.y, transform.position.z);
			Quaternion target = Quaternion.Euler(0, 0, 90);
			transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocidadCurva);
		}
	}

	public void Disparar(){
		if(cantidadBalas > 0){
			Instantiate(prefab_bala, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 1f), Quaternion.identity);
			cantidadBalas --;
			if(PlayerPrefs.GetInt("efectossonido_activados") == 1){
				GetComponent<AudioSource>().Play();
			}
		}
	}
}
