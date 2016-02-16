/*
 * 来回移动的障碍，碰撞即死
 * 在自身左右来回移动
 */
using UnityEngine;
using System.Collections;
public class backnforthCollider : MonoBehaviour
{
//	public Transform begin;
//	public Transform end;
	private Vector3 frometh;
	private Vector3 untoeth;
	private static Vector3 HALFDIS = new Vector3(3,0,0);//一半距离
	private static float LOOPTIME = 1f;//来回一次需要的时间

	void Start()
	{
		frometh = transform.position - HALFDIS;
		untoeth = transform.position + HALFDIS;
	}

	void Update()
	{
		transform.position = Vector3.Lerp(frometh, untoeth, //基于smoothstep返回值而返回frometh与untoeth间的值
			Mathf.SmoothStep(0f,1f,
				Mathf.PingPong(Time.time/LOOPTIME, 1f) //在0到1间往返
			) );
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag=="player"){
			//			GetComponent<AudioSource>().Play();//播放音效
			print("dead");
			//			GameManager._intance.GameState = GameManager.GAMESTATE_END;//改变游戏状态
		}	}
}