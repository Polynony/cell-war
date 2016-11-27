using UnityEngine;
using System.Collections;

public class cellai : Unit {
	public float speed;
	private float tt = 0;
	private int a = 0;


	void Start () {
	
	}

	void Update () {
			
	}
	void FixedUpdate(){
		
		 movecell ();

	}
	public Vector2 movecell(){
		if (tt >= 0.3) {
			float x = Random.Range (-21, 21);
			float y = Random.Range (-10, 10);
			Vector2 lastpos = new Vector2 (x, y);
			Vector2 curren = new Vector2 (x, y);
			transform.position = Vector2.SmoothDamp (transform.position, curren, ref lastpos, speed, Mathf.Infinity, Time.deltaTime);
			tt = 0;
		}  else {
			tt += Time.deltaTime;
		}
		float x1 = Random.Range (-21, 21);
		float y1 = Random.Range (-10, 10);
		Vector2 wu = new Vector2 (x1, y1);
		return wu;
	}

	void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.tag == "Player"){
			Unit u = coll.GetComponent<Unit> ();
			if(u != null){
			u.Applydamage (damages);
			}
		}
		if(coll.gameObject.tag == "Finish"){
			a += 1;
			health += 5;
		}
	}
	void OnCollisionEnter2D(Collider2D cols){
		Rigidbody2D r = cols.GetComponent<Rigidbody2D> ();
		r.AddForceAtPosition (movecell (), transform.position);
	}

}