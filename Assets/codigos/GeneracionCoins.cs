using UnityEngine;
using System.Collections;

public class GeneracionCoins : MonoBehaviour {
	
	public GameObject[] obj;
	public float generacionMin = 1f;
	public float generacionMax = 2f;
	private int numeroRandom = 0;
	private int powerupSeleccionado = 0;

	void Start () {
		Generar();
	}
	
	void Generar()
	{
		Instantiate(obj[Random.Range(0,obj.Length)], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		Invoke ("Generar", Random.Range (generacionMin, generacionMax));
	}
}