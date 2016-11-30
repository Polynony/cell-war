using UnityEngine;
using System.Collections;

public class breeds : Unit {
	private float tt = 0;
	public GameObject nns;

	void Start () {
	
	}

	void Update () {
		tt += Time.deltaTime;
		if (tt >= 5f) {
			Instantiate (nns, transform.position, Quaternion.identity);
			Instantiate (nns, transform.position, Quaternion.identity);

			Destroy (gameObject);
		}
	
	}
}
