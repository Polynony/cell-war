using UnityEngine;
using System.Collections;

public class cellai : Unit {
	public float speed;
	private float tt = 0;
	private Vector2 curll = Vector2.zero;


	void Start () {
	
	}

	void Update () {
			
	}
	void FixedUpdate(){
		
		movecell ();

	}
	void movecell(){
		float x = Random.Range (-21, 21);
		float y = Random.Range (-10, 10);
		Vector2 lastpos = new Vector2 (x, y);
		Vector2 currentpos = new Vector2 (x, y);
		Vector2 wu = Vector2.Lerp (lastpos, currentpos, speed * Time.deltaTime);
		wu = wu.normalized;
		if (tt >= 0.7) {
			transform.Translate (wu * speed * Time.deltaTime, Space.World);
			tt = 0;
		} else {
			tt += Time.deltaTime;
		}
	}

	public void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.tag == "Player"){
			Applydamage (damages);
		}
		if(coll.gameObject.tag == "Finish"){
			health += 5;
		}
	}

}