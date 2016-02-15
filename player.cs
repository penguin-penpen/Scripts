using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float Xspeed = 0;
	public float Yspeed = 0;
	public int a = 0; 
	public float jump_timeMax = 0.3f; //最大可持续跳跃时间
	public float jump_time; //跳跃时间
	public float move_speed = 0.5f; //移动速度


	void OnCollisionEnter(){
		jump_time = jump_timeMax; //重置跳跃时间
		a = 0; //重置跳跃次数
	}


	void jump(){
		Yspeed = 10f;              // 向上跳跃速度
		this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,Yspeed,0);
	}

	void Start () {
		Physics.gravity = new Vector3 (0, -30f, 0); //重力大小，影响下落速度
	}

	void Update () {

		//跳跃

		if (Input.GetKey (KeyCode.Space) && a<2 && jump_time > 0) {
			jump();
			jump_time -=Time.deltaTime;
		}


		if (Input.GetKeyUp (KeyCode.Space)) {
			jump_time = jump_timeMax;
			a++;
		}

		//左右
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate( -move_speed,0,0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate( move_speed,0,0);
		}

	}
}