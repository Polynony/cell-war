using UnityEngine;
using System.Collections;

public class dnaai : cellai {
	private float t = 0;

	void Start () {
	
	}

	void Update () {
		movecell ();
	
	}
	void OnTriggerEnter2D(Collider2D dna){
		if (dna.gameObject.tag == "Player") {
			Destroy (gameObject);
		} else {
			des ();
		}

	}
	void des(){
		t += Time.deltaTime;
		if(t >= 7){
			Destroy (gameObject);
		}
	}
}
