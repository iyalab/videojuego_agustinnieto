using UnityEngine;
using System.Collections;

public class GeneracionObstaculo : MonoBehaviour
{
	public GameObject[] obstaculos;
	public float generacionMin;
	public float generacionMax;
	private bool primeraVez = true;

	void Start (){
		Generar ();
	}
	
	void Generar (){
		if(!primeraVez){
			Instantiate (obstaculos [Random.Range(0,obstaculos.Length)], new Vector3 (transform.position.x, 20, transform.position.z), Quaternion.identity);
		}else{
			primeraVez = false;
		}
		Invoke ("Generar", Random.Range (generacionMin, generacionMax));
	}

	void Update(){

	}
}
