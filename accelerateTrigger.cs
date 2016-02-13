/*
 * 碰撞加速
 */
using UnityEngine;
using System.Collections;

public class accelerateTrigger : MonoBehaviour {
	void Awake(){

	}
	void Start(){

	}
	void Update(){


	}

	void onTriggerEnter(Collider other){
//		Destroy(other.gameObject);
		if(other.gameObject.tag == "Player")
			print("Trigger");
//		if (col.tag == "Player") {
//			col.gameObject.GetComponent<Rigidbody> ().velocity += new Vector3 (10, 0, 0);
//			col.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 200f, 0));
//		}
	}
	void OnCollisionEnter(Collision col){//OnTriggerEnter OnTriggerStay OnTiggerExit
		if(col.gameObject.tag=="Player"){
			//			GetComponent<AudioSource>().Play();//播放音效
			print("dead");
			//			GameManager._intance.GameState = GameManager.GAMESTATE_END;//改变游戏状态
		}
	}
}
