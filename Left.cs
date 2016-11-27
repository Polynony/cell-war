using UnityEngine;
using System.Collections;

public class Left : MonoBehaviour {
	private float t = 0;

	void Start () {
	
	}

	void Update () {
	
		des ();
	}

	void OnTriggerEnter2D(Collider2D colls){
		Destroy (gameObject);
	}
	void des(){
		t += Time.deltaTime;
		if(t >= 10){
			Destroy (gameObject);
		}
	}

}
