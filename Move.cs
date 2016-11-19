using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : Unit {
	public float m_speed;
	public float m_anglespeed;


	void Start () {

			
	}

	void Update () {
		
		move ();
	}

	void move(){
		if (Input.GetKey(KeyCode.W))  
		{    
			transform.Translate(Vector2.up * Time.deltaTime * m_speed);  

		}   
		if (Input.GetKey(KeyCode.S))  
		{  
			
			transform.Translate(-Vector2.up * Time.deltaTime * m_speed);  

		}    
		if (Input.GetKey(KeyCode.A))  
		{  
			
			transform.Rotate (Vector3.forward * m_anglespeed * Time.deltaTime,Space.World);
		}  
		if (Input.GetKey(KeyCode.D))  
		{  
			
			transform.Rotate (Vector3.forward * -m_anglespeed * Time.deltaTime,Space.World);
		}  
	}

	public void OnTriggerEnter2D(Collider2D coll){
		if(coll.gameObject.tag  == "harmful"){
			Applydamage (damages);
		}
		if(coll.gameObject.tag == "Finish"){
			health += 5;
		}
	}



}
