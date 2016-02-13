/*
 * 碰撞后一定时间销毁
 */
using UnityEngine;
using System.Collections;

public class timerCollider : MonoBehaviour
{
	public static float TIMER = 5.0f;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Player") {
			print ("start");
			Destroy (gameObject, TIMER);
//			播放动画效果
//			print ("destroy");
		}
	}
}
