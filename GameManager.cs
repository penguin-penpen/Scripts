/*
 * 游戏控制器
 * 控制游戏状态
 */
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	// define the state of the game
	public const int GAMESTATE_MENU 					=0;//游戏菜单状态
	public const int GAMESTATE_PLAYING_MODE_SINGLE		=1;//游戏中状态 ... 
	public const int GAMESTATE_PLAYING_MODE_MULTIPLE	=2;//游戏中状态 ... 
	public const int GAMESTATE_PLAYING_MODE_CUSTOMIZE	=3;//游戏中状态 ... 
	public const int GAMESTATE_END						=4;//游戏结束状态

	//GUI皮肤  
	public GUISkin mySkin;  

	//游戏背景贴图  
	public Texture textureBG;   
	//开始菜单截图  
//	public Texture tex_startInfo;  
	//帮助菜单贴图  
	public Texture tex_helpInfo;  

	//游戏音乐资源  
	public AudioSource music;    
	//当前游戏状态  
	private int gameState;  

	public int score = 0;

	public static GameManager _intance;//???
	private GameObject player;//GameObject: base class for all entities in unity

	//当一个脚本实例被载入时Awake被调用
	void Awake(){
		_intance = this;
		player = GameObject.FindGameObjectWithTag("player");
	}

	//	在第一次update之前调用，一个生命周期中只调用一次
	void Start(){
	}
	//当MonoBehaviour启用时，其Update在每一帧被调用。
	void Update(){
	}
	//		视图
		void OnGUI()  
		{  
			if (gameState == GAMESTATE_MENU) {
//				绘制主菜单界面  
				RenderMainMenu ();  
			} 
//			else if (gameState == GAMESTATE_PLAYING_MODE_SINGLE) {
//				//绘制单人界面  
//				RenderStart();  
//			} else if (gameState == GAMESTATE_PLAYING_MODE_MULTIPLE) {
//				//绘制多人界面  
//				RenderOption();  
//			} else if (gameState == GAMESTATE_PLAYING_MODE_CUSTOMIZE) {
//				//绘制自定义界面  
//				RenderHelp();  
//			} else if (gameState == GAMESTATE_END) {
//				//绘制游戏结束界面  
//				RenderEnd();  
//			}
				}
//	
//		//绘制主菜单界面  
		void RenderMainMenu()  
		{  
//			//设置界面皮肤  
			GUI.skin = mySkin;  
			//绘制游戏背景图  
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),textureBG);  
			//开始游戏按钮  
			if(GUI.Button(new Rect (0,30,623,153),"","start"))  
			{  
				//进入开始游戏状态  
				//目前由于是测试阶段  
				//后期会在这里重新载入新的游戏场景  
				gameState = GAMESTATE_MENU;  
			}  
//			//游戏设置按钮  
//	//		if(GUI.Button(new Rect (0,180,623,153),"","option"))  
//	//		{  
//	//			进入开始游戏状态  
//	//			gameState = STATE_OPTION;  
//	//		}  
//	//		游戏帮助按钮  
//	//		if(GUI.Button(new Rect (0,320,623,153),"","help"))  
//	//		{  
//	//			进入游戏帮助状态  
//	//			gameState = STATE_HELP;  
//	//		}  
//	//		游戏结束按钮
//			if(GUI.Button(new Rect (0,470,623,153),"","end"))  
//			{  
//				//退出游戏  
//				gameState = GAMESTATE_END;
//			} 
//			//游戏退出按钮 
//			if(GUI.Button(new Rect (0,470,623,153),"","exit"))  
//			{  
//				//退出游戏  
//				Application.Quit();  
//			}  
//		}  
//		//绘制游戏开始界面  
//		void RenderStart()  
//		{  
//			GUI.skin = mySkin;  
//	
////			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),tex_startInfo);  
//			//绘制返回按钮  
//			if(GUI.Button(new Rect (0,500,403,78),"","back"))  
//			{  
//				//返回游戏主菜单  
//				gameState = GAMESTATE_MENU;  
//			}  
//		}  
//		//绘制游戏帮助界面  
//		void RenderHelp()  
//		{  
//			GUI.skin = mySkin;  
//			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),tex_helpInfo);  
//			if(GUI.Button(new Rect (0,500,403,78),"","back"))  
//			{  
//				gameState = GAMESTATE_MENU;  
//			}  
//		}  
//		//绘制游戏设置界面  
//		void RenderOption()  
//		{  
//			GUI.skin = mySkin;  
//			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),textureBG);  
//	
//			//开启音乐按钮  
//			if(GUI.Button(new Rect (0,0,403,75),"","music_on"))  
//			{  
//				if (!music.isPlaying)  
//				{    
//					//播放音乐  
//					music.Play();    
//				}    
//	
//			}  
//			//关闭音乐按钮  
//			if(GUI.Button(new Rect (0,200,403,75),"","music_off"))  
//			{  
//				//关闭音乐  
//				music.Stop();  
//			}  
//			//返回按钮  
//			if(GUI.Button(new Rect (0,500,403,78),"","back"))  
//			{  
//				//返回游戏主菜单  
//				gameState = GAMESTATE_MENU;  
//			}  
		}  
//	
//	//	绘制游戏结束界面
//		void RenderEnd(){
//			GUI.skin = mySkin;
//		}
//	
}
