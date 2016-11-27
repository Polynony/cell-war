using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	public float health;
	public float maxhp;
	public GameObject ya;
	public GameObject dna;
	public float damages;
	public void Applydamage(float damage){
		if (health > damage) {
			health -= damage;
		}  else {
			Instantiate (ya, transform.position, Quaternion.identity);
			Instantiate (dna, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}

}
