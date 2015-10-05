using UnityEngine;
using System.Collections;

public class orbpickup : MonoBehaviour {
	public Color color1 = Color.red;


	void OnTriggerEnter2D (Collider2D other){

		if (other.gameObject.CompareTag ("Player"))
			Destroy (gameObject);
		Camera.main.backgroundColor = color1;
	}


}
