using UnityEngine;
using System.Collections;

public class nsscripts : cellai {
	public float dam;
	private float time = 0;
	private GameObject[] number;
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;

	void Start () {
	
	}

	void Update () {
	
		movecell ();
		variation ();
	}
	void OnTriggerEnter2D(Collider2D colli){
		Unit u = colli.GetComponent<Unit> ();
		if(u != null){
			u.Applydamage (dam);
		}
	}
	void variation(){
		float a = Random.Range (0, 10);
		float c = 0.8f;
		if(size() >= 5){
			c += Time.deltaTime * 14;
			if(a <= c){
				varion ();
			}
		}
		
	}
	void breed(){
	}
	float size(){
		number = GameObject.FindGameObjectsWithTag ("not");
		float s = number.Length;
		return s;
	}
	void varion(){
		int b = Random.Range (1, 3);
		switch (b) {
		case 1:
			Instantiate (b1, transform.position, Quaternion.identity);
			Destroy (gameObject);
			break;
		case 2:
			Instantiate (b2, transform.position, Quaternion.identity);
			Destroy (gameObject);
			break;
		case 3:
			Instantiate (b3, transform.position, Quaternion.identity);
			Destroy (gameObject);
			break;
		}
	}

}
