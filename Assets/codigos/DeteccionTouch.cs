using UnityEngine;
using System.Collections;

public class DeteccionTouch : MonoBehaviour {

	void Start () {
	}
	
	void Update () {
		Swipe();
	}
	
	public void Swipe(){
		if(Input.touches.Length > 0)
		{
			Touch t = Input.GetTouch(0);

			if(t.position.x >= Screen.width/2 && t.position.y < Screen.height - Screen.height/5 && t.position.y > Screen.height/5){
				gameObject.GetComponent<Nave>().irDerecha();
			}
			if(t.position.x < Screen.width/2 && t.position.y < Screen.height - Screen.height/5 && t.position.y > Screen.height/5){
				gameObject.GetComponent<Nave>().irIzquierda();
			}
		}
	}
}
