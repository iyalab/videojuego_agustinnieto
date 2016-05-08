using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {
	
	private GameObject control;
	private CircleCollider2D[] listaCircleColliders;
	
	void Start(){
		control = GameObject.Find("control");
		listaCircleColliders = GetComponents<CircleCollider2D>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			PlayerPrefs.SetInt("puntaje", control.GetComponent<ControlJuego>().puntaje);
			if(control.GetComponent<ControlJuego>().puntaje > PlayerPrefs.GetInt("mejor_puntaje")){
				PlayerPrefs.SetInt("mejor_puntaje", control.GetComponent<ControlJuego>().puntaje);
			}
			Application.LoadLevel("escena_gameover");
		}

		if (other.tag == "bala") {
			if(PlayerPrefs.GetInt("efectossonido_activados") == 1){
				GetComponent<AudioSource>().Play();
				Debug.Log("SONIDO");
			}
			GetComponent<SpriteRenderer>().enabled = false;
			for(int i = 0; i < listaCircleColliders.Length; i++){
				listaCircleColliders[i].enabled = false;
			}
			Destroy(gameObject,2f);
			Destroy(other.gameObject);
		}
	}
}