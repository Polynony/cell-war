using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class over : Unit {

	// Use this for initialization
	void Start () {
		if(gameObject == null){
			SceneManager.LoadScene ("gameover");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
