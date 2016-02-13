using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public float Xspeed = 0;
	public float Yspeed = 0;
	public int a = 0;
	void OnCollisionEnter(Collision col){
		if (col.collider.tag == "Ground")
			a = 0;
	}
	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3 (0, -10, 0);
	}

	// Update is called once per frame
	void Update () {
		//左右方向键控制
		if (Input.GetKey (KeyCode.RightArrow)) {
//			print ("right");
			Vector3 vel = this.GetComponent<Rigidbody> ().velocity;
			this.GetComponent<Rigidbody> ().velocity = new Vector3 (8, vel.y, vel.z);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
//			print ("left");
			Vector3 vel = this.GetComponent<Rigidbody> ().velocity;
			this.GetComponent<Rigidbody> ().velocity = new Vector3 (-8, vel.y, vel.z);
		}
		//跳跃
		if (Input.GetKeyDown (KeyCode.Space) && a < 2 ) {	
//			print ("jump");	
			this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Xspeed,5,0);
			a++;
		}

	}
}