/*
 * 游戏控制器
 * 控制游戏状态
 */
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	// define the state of the game
	public static int GAMESTATE_MENU 		=0;//游戏菜单状态
	public static int GAMESTATE_PLAYING		=1;//游戏中状态 ... 
	public static int GAMESTATE_END			=2;//游戏结束状态


	public Transform firstBg;//position, rotation and scale of an object
	public int score = 0;
	public int GameState  = GAMESTATE_MENU;

	public static GameManager _intance;//???

	private GameObject bird;//GameObject: base class for all entities in unity

	//当一个脚本实例被载入时Awake被调用
	void Awake(){
		_intance = this;
		bird = GameObject.FindGameObjectWithTag("Player");
	}
	//当MonoBehaviour启用时，其Update在每一帧被调用。
	void Update(){
		if(GameState==GameManager.GAMESTATE_MENU){
			if(Input.GetMouseButtonDown(0)){ //GtMouseButtonDown: return True during the frame the user press the given mouse button
				// transform state
				GameState = GAMESTATE_PLAYING;
				// set bird is playing
				// 1.set gravity 2.add velocity of x
				bird.SendMessage("getLife");//call method
			}
		}

		if (GameState == GameManager.GAMESTATE_END) {
		}
	}
}
