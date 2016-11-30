using UnityEngine;
using System.Collections;

public class cellai : Unit {
	public float speed;
	private float tt = 0; //这个是breed（）函数里计时的
	private float t = 0; //movecell里计时的
	private int score = 0; //分数
	private Vector2 curren; //随机向量
	private Vector2 last; //同上
	public GameObject nn; //增殖后还未分裂的那个细菌

	void Start () {

	}
	void Update () {
		movecell ();

	}
	//这个是移动的函数
	public void movecell(){
			if (t >= 0.5) {
				curren = rand ();
			transform.Translate (curren * Time.deltaTime * speed, Space.Self);
				t = 0;
			} else {
				t += 1 * Time.deltaTime;
			}
		}
		
	//碰撞产生伤害的
	void OnTriggerEnter2D(Collider2D coll){
			Unit u = coll.GetComponent<Unit> ();
			if(u != null){
			u.Applydamage (damages);
			}
		if(coll.gameObject.tag == "Finish"){
			score += 1;
			health += 5;
		}
	}
	//这个本来是要写碰撞后加力弹开的，没效果，暂时删了
	void OnCollisionEnter2D(Collider2D cols){
	}
	//这个函数返回一个随机的vector2D
	Vector2 rand(){
		float x = Random.Range (-21, 21);
		float y = Random.Range (-10, 10);
		Vector2 wu = new Vector2 (x, y);
		return wu;
	}
	//这是增殖的功能
	public void breed(){
		tt += Time.deltaTime;
		if (tt >= 30) {
			Instantiate (nn, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}

}