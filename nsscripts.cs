using UnityEngine;
using System.Collections;

public class nsscripts : cellai {
	private float time = 0;
	private GameObject[] number;
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	private float c = 0.8f;

	void Start () {
	
	}

	void Update () {
	
		movecell ();
		variation ();
		breed ();
	}
	void OnTriggerEnter2D(Collider2D colli){
		Unit u = colli.GetComponent<Unit> ();
	}
	void variation(){
		float a = Random.Range (0, 10);
		if(size() >= 5){
			c += (size () - 5) * 0.1f;//c is the current mutation probability
			if(a <= c){
				varion ();
			}
			if(c > 8){
				c = 8;
			}
		}
		
	}
	float size(){
		number = GameObject.FindGameObjectsWithTag ("not");
		int s = number.Length;
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
