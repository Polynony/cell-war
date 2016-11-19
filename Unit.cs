using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	public float health;
	public GameObject ya;
	public float damages;
	void Start () {
	
	}

	void Update () {
	}
	public void Applydamage(float damage){
		if (health > damage) {
			health -= damage;
		}  else {
			Instantiate (ya, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}

}
