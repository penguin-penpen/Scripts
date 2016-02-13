/*
 * 碰撞即死障碍
 */
using UnityEngine;
using System.Collections;

public class deathCollider : MonoBehaviour {

	void Awake(){

	}
	void Start(){

	}
	void Update(){
		

	}


	void OnCollisionEnter(Collision col){//OnTriggerEnter OnTriggerStay OnTiggerExit
		if(col.gameObject.tag=="Player"){
			//			GetComponent<AudioSource>().Play();//播放音效
			print("dead");
			//			GameManager._intance.GameState = GameManager.GAMESTATE_END;//改变游戏状态
		}
	}
}
