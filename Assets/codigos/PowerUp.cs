using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	private GameObject jugador;

	void Start(){
		jugador = GameObject.Find("jugador");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			if(PlayerPrefs.GetInt("efectossonido_activados") == 1){
				GetComponent<AudioSource>().Play();
			}
			if(tag.Equals("powerup_bala")){
				jugador.GetComponent<Nave>().cantidadBalas += 1;
			}

			// Esperar n segundos antes de destruir el gameObject, para asi poder reproducir el sonido
			Destroy (this.gameObject, 0.15f);
		}
	}
}
