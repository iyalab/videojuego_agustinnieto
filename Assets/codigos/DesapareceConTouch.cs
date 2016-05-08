using UnityEngine;
using System.Collections;

public class DesapareceConTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touches.Length > 0)
		{
			Destroy(this.gameObject);
		}
	}
}
