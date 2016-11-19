using UnityEngine;
using System.Collections;

public class ins : cellai {
	public GameObject preobgect;
	public float bb;

	void inss(){
		float x2 = Random.Range (-15, 15);
		float y2 = Random.Range (-4, 4);
		Vector3 ins = new Vector3 (x2, y2, 0);
		Instantiate (preobgect,ins,Quaternion.identity);
	}

	void Awake(){
		InvokeRepeating ("inss", 1, bb);
		
	}


}
