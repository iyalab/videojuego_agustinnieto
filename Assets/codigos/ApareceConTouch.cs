using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ApareceConTouch : MonoBehaviour {

	// Use this for initialization
	public bool esUnTexto = false;
	public bool esUnSprite = false;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touches.Length > 0)
		{
			if(esUnTexto){
				gameObject.GetComponent<Text>().enabled = true;
			}
			if(esUnSprite){
				gameObject.GetComponent<SpriteRenderer>().enabled = true;
			}
		}
	}
}
