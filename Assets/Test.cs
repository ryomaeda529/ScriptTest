using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

	public void MagicAttack(){
		this.mp -= 5;
		if (mp >= 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		} else {
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}
}
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = { 5, 2, 7, 3, 9 };
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
			Debug.Log (array [4 - i]);
		}


		Boss lastboss = new Boss ();
		lastboss.Attack ();
		lastboss.Defence (3);
		for (int i = 0; i < 10; i++) {
			lastboss.MagicAttack ();
		}
		lastboss.MagicAttack ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
