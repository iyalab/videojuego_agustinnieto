using UnityEngine;
using System.Collections;

public class MoverCamara : MonoBehaviour {

	// Use this for initialization
	public float velocidadMax = 1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadMax, GetComponent<Rigidbody2D>().velocity.y);
	}
}
