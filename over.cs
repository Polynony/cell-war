using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class over : MonoBehaviour {
	private GameObject camer;
	private GameObject camer1;
	private GameObject[] player1;
	
	void Start () {
		camer = GameObject.Find ("Main Camera");
		camer1 = GameObject.Find ("Camera");
		player1 = GameObject.FindGameObjectsWithTag ("Player");
		camer1.SetActive (false);
	}

	void Update () {
		emety ();
	
	}
	void emety(){
		if(player1 == null){
			camer.SetActive (false);
			camer1.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
