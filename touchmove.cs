using UnityEngine;
using System.Collections;

public class touchmove : Unit {

	Vector3 pos;
	Vector3 mousePos;

	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			pos=Camera.main.WorldToScreenPoint(transform.position);
			//跟随鼠标的移动
			mousePos=new Vector3(Input.mousePosition.x,Input.mousePosition.y,pos.z);
			//新的世界position
			Vector3 newPos=Camera.main.ScreenToWorldPoint(mousePos);
			transform.position = new Vector3(newPos.x, newPos.y, newPos.z);
		}

	}
}
