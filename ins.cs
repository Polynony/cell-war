using UnityEngine;
using System.Collections;

public class ins : cellai {
	public GameObject preobgect;
	public GameObject notharmful;
	public float bb;
	public float cc;

	void create1(){
		float x2 = Random.Range (-15, 15);
		float y2 = Random.Range (-4, 4);
		Vector3 ins = new Vector3 (x2, y2, 0);
		Instantiate (preobgect,ins,Quaternion.identity);
	}
	void create(){
		float x3 = Random.Range (-15, 15);
		float y3 = Random.Range (-4, 4);
		Vector3 trans = new Vector3 (x3, y3, 0);
		Instantiate (notharmful,trans,Quaternion.identity);
	}

	void Awake(){
		InvokeRepeating ("create1", 0.5f, bb);
		InvokeRepeating ("create", 0.5f, cc);
		
	}


}
