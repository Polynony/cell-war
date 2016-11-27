using UnityEngine;
using System.Collections;

public class blood : Unit {

	public Transform bloodBar;
	public Texture2D bloodBarRed;

	void Start () {
		bloodBar = transform.FindChild ("BloodBars");


		bloodBarRed = new Texture2D (512, 32);
		bloodBarRed.wrapMode = TextureWrapMode.Clamp;
	
	}

	void Update () {
	
	}
	public void UpDateBloodBar()
	{
		float cunrrentRed = health * bloodBarRed.width / maxhp;
		for (var x = 0; x < bloodBarRed.width; x++)
		{
			for (var y = 0; y < bloodBarRed.height; y++)
			{
				if (x < cunrrentRed)
					bloodBarRed.SetPixel (x, y, Color.red);
				else
					bloodBarRed.SetPixel (x, y, Color.gray);
			}
		}
		bloodBarRed.Apply ();
		bloodBar.gameObject.GetComponent<Renderer>().material.mainTexture = bloodBarRed;

	}
}
