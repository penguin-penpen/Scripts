﻿using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	private int a = 0; 
	private float jump_timeMax = 0.3f; //最大可持续跳跃时间
	private float jump_time; //跳跃时间
	public 	float Yspeed = 10f;       // 向上跳跃速度
	public float move_speed = 0.3f; //移动速度
	public static player instance;     //gengxin

	void Awake(){                    //gengxin
		instance = this;
	}

	public void SpeedUpdate(float temp){
		move_speed = temp;
	}

	void OnCollisionEnter(){
		jump_time = jump_timeMax; //重置跳跃时间
		a = 0; //重置跳跃次数
	}


	void jump(){
		this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,Yspeed,0);
	}

	void Start () {
		Physics.gravity = new Vector3 (0, -30f, 0); //重力大小，影响下落速度
		move_speed = 0.3f;
	}

	void Update () {
		/*		if (Input.GetKeyDown (KeyCode.UpArrow) && a < 2 ) {		
		    Yspeed = 30;
			this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,Yspeed,0);
			a++;
     	}
*/
		//跳跃

		if (Input.GetKey (KeyCode.UpArrow) && a<2 && jump_time > 0) {
			jump();
			jump_time -=Time.deltaTime;
		}


		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			jump_time = jump_timeMax;
			a++;
		}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate( -move_speed,0,0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate( move_speed,0,0);
		}

	}
}










