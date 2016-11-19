using UnityEngine;
using System.Collections;

public class Left : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D colls){
		Destroy (gameObject);

	}

}
