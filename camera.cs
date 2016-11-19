using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	public Transform target;



	void Awake(){

	}
	

	void LateUpdate () {
		transform.position = target.position;
	
	}
}
