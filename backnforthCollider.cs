/*
 * 来回移动的障碍，碰撞即死
 * 在farEnd和自身transform之间来回移动
 */
using UnityEngine;
using System.Collections;
public class backnforthCollider : MonoBehaviour
{
	public Transform farEnd;
	private Vector3 frometh;
	private Vector3 untoeth;
	private float secondsForOneLength = 1f;

	void Start()
	{
		farEnd = GameObject.Find ("Player").transform;
		frometh = transform.position;
		untoeth = farEnd.position;
	}

	void Update()
	{
		transform.position = Vector3.Lerp(frometh, untoeth, //基于smoothstep返回值而返回frometh与untoeth间的值
			Mathf.SmoothStep(0f,1f,
				Mathf.PingPong(Time.time/secondsForOneLength, 1f) //在0到1间往返
			) );
	}
}