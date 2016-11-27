using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	private GameObject target;

	void Awake(){

	}
	

	void LateUpdate () {
		target = GameObject.FindGameObjectWithTag ("Player");
		transform.position = target.transform.position;
	
	}
}
