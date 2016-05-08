using UnityEngine;
using System.Collections;

public class MoverBala : MonoBehaviour {

	public float velocidad = 10000.0f;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * velocidad);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(Vector3.up * Time.deltaTime * velocidad, Space.World);
	}
}
