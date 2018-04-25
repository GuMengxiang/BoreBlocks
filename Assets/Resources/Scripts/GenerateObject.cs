using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using HedgehogTeam.EasyTouch;

public class GenerateObject : MonoBehaviour {
	//子集下的摄像头
	public GameObject mCame_01;

	List<Vector3> _gameScene;
//	Dictionary<string,List<Vector3>> ObjControl=new Dictionary<string, List<Vector3>>();
	int Sub=0;//下标
	int RedSub=0;
	public GameObject CubeObj;//高亮的预设体
	public GameObject mRedBox;//生成的物体
	public GameObject UIInterface_01;//UI界面
	public GameObject UIInterface_02;//UI界面
	private GameObject _Tip;
	//只是箭头
//	private GameObject _Arr;	
	public static int nextlock=0;
	public static int i=0;//测试用。区别目前是否为教程模式。后期变更为json值存入
	public static string SceneName="Model_2A2Cube";//想要查找的相应的名字对应的三维向量
	public static AudioSource mPlay;//点击的音效
	//通关后隐藏的地面
	public GameObject mGround;

//	public ModeType mGameType;
//	int LockOrNot= 1 ;//关卡是锁上还是没锁上  1:解锁  0:未解锁
//	int SceneSub = 0 ;//场景的下标
	//private Color mBoxColor;//生成的物体的颜色//20180117  按需求去掉调色板
//	public GameObject testcubecolor;
	// Use this for initialization
	void Start () {
		_gameScene = new List<Vector3> ();

		AddObjVector();
		ClickGenerate(CubeObj,"Prefabs/001",Sub);
		Debug.Log("SceneName start:"+SceneName);
		if (PlayerPrefs.HasKey("LEVEL_LOCK_OR_NOT")) {
			FromJson();
		}
		//transform.position=new Vector3(0.1f,CubeObj.transform.localPosition.y*10,CubeObj.transform.localPosition.z*10);

		mPlay=GameObject.Find("GameManagement").transform.GetComponent<AudioSource>();//获取声音
		//激活地面
		mGround.SetActive(true);
		GameObject.Find("MyCamera").GetComponent<QuickSwipe>().EnabledQuickComponent("mCamare02");
		GameObject.Find("MyCamera/Main Camera").GetComponent<QuickSwipe>().EnabledQuickComponent("mCamare01");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Mouse0)) {
			CameraRay();
		}
//		mGameType=(ModeType)UIInterface_01.transform.Find("GameMode").GetComponent<Dropdown>().value;
//		switch (mGameType )
//		{
//
//		case ModeType.滑动模型模式:
//			//激活拥有相同名字的QUICHK组件
//			GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().EnabledQuickComponent("SwipeCubeLR");
//			GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().EnabledQuickComponent("SwipeCubeUD");
//			mGround.SetActive(false);
//			break;
//		case ModeType.自动追寻模式:
//			
//			GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().EnabledQuickComponent("SwipeCubeLR");
//			//this.gameObject.transform.LookAt(GameObject.Find("CubeControl").transform);
//			mCame_01.transform.DOLookAt(new Vector3(GameObject.Find("CubeControl").transform.position.x,GameObject.Find("CubeControl").transform.position.y,GameObject.Find("CubeControl").transform.position.z),0.5f);
//			break;
//		default:
//			break;
//		}


//		testcubecolor.GetComponent<MeshRenderer >().material.color=thisGameUIManagement.mBoxColor;/*摄像机下挂在的test调色板的cube*/
	}
	/// <summary>
	/// 往list里添加三维向量
	/// </summary>
	public void AddObjVector()
	{
		List<Vector3>thisScene=new List<Vector3>();


		if (SceneName=="Model_2A2Cube"||SceneName=="Model_2A4Cube") 
		{
			if (ThisGameModel.ModelDic.ContainsKey("Model_2A2Cube")||ThisGameModel.ModelDic.ContainsKey("Model_2A4Cube"))
			{
				if (i<2) 
				{
					if (ThisGameModel.ModelDic.TryGetValue("Model_2A2Cube",out thisScene) && i<1 )//&& SceneName=="Model_2A2Cube")
					{
						_gameScene=thisScene;

						Debug.LogError("00000");
					}
					if (ThisGameModel.ModelDic.TryGetValue("Model_2A4Cube",out thisScene) && i==1 )//&& SceneName=="Model_2A4Cube")
					{
						_gameScene=thisScene;
						nextlock=0;
						Debug.LogError("00001");
					}

					i++;
				} 
				else 
				{
					if (ThisGameModel.ModelDic.TryGetValue("Model_2A2Cube",out thisScene) && SceneName=="Model_2A2Cube")
					{
						_gameScene=thisScene;

						Debug.LogError("00002");
					}
					if (ThisGameModel.ModelDic.TryGetValue("Model_2A4Cube",out thisScene) && SceneName!="Model_2A2Cube")
					{
						_gameScene=thisScene;
						SceneName="Scene0";
						nextlock=0;
						Debug.LogError("00003");
					}
					i++;
				}	
			}
		} 
		else if (i>1&&i<=2)
		{
			if (ThisGameModel.ModelDic.TryGetValue("Scene0",out thisScene)) {
				SceneName="Scene0";
				nextlock=0;
				_gameScene=thisScene;
			}
			i++;
		} 
		else 
		{
			if (ThisGameModel.ModelDic.ContainsKey(SceneName)) {
				if (ThisGameModel.ModelDic.TryGetValue(SceneName,out thisScene)) {
					_gameScene=thisScene;
					Debug.Log("_gameScene.Count : "+_gameScene.Count.ToString());

				}
			}
		}	
	}
	/// <summary>
	/// 点击后生成obj
	/// obj 是实例化的物体 name是预设体的名字 listsub是下标
	/// </summary>
	public void ClickGenerate(GameObject mObj,string mName,int ListSub) 
	{ 
		Vector3 offset=new Vector3(0.0f,1.0f,2.0f);//GameObject.Find("CubeControl").transform.position - this.gameObject.transform.position;
		if (_gameScene.Count >= (ListSub+1)) {
			mObj=(GameObject)Instantiate(Resources.Load(mName));
			mObj.AddComponent<BoxCollider>();
			mObj.transform.localPosition=_gameScene[ListSub];
			mObj.transform.parent=GameObject.Find("CubeControl").transform;
			mObj.transform.rotation=new Quaternion(0.0f,0.0f,0.0f,0.0f);

			if (mName=="Prefabs/001") {
				Sub++;
				mObj.transform.localPosition=new Vector3(_gameScene[ListSub].x,_gameScene[ListSub].y-0.1125f,_gameScene[ListSub].z);

//				_Arr.transform.position=new Vector3(mObj.transform.position.x,mObj.transform.position.y+1.0f,mObj.transform.position.z+0.20f);//this.gameObject.GetComponent<Camera>().WorldToScreenPoint(mObj.transform.position);
				#region 摄像机自动旋转跟随

					mGround.SetActive(true);
					//激死拥有相同名字的QUICHK组件
					GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().DisabledQuickComponent("SwipeCubeLR");
					GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().DisabledQuickComponent("SwipeCubeUD");
				//this.gameObject.transform.LookAt(mObj.transform);   
				mCame_01.transform.DOLookAt(new Vector3(mObj.transform.position.x,mObj.transform.position.y,mObj.transform.position.z)/*mObj.transform.position*//*旋转角度*/,0.5f/*时间*/);
				//this.gameObject.transform.position=Vector3.Lerp(this.transform.position,mObj.transform.position+offset,1.0f * Time.deltaTime);
//				this.gameObject.transform.position =mObj.transform.position+offset;
				#endregion
				Debug.Log("001.transfrom:"+mObj.transform.localPosition.ToString());


			}
			else if(mName=="Prefabs/RedBox")
			{
				RedSub++;
				mObj.name="RedBox"+RedSub;
				mObj.transform.localPosition=_gameScene[ListSub];
						mObj.transform.localRotation=new Quaternion(0.0f,0.0f,0.0f,0.0f);
				mObj.GetComponent<MeshRenderer >().material.color=thisGameUIManagement.mBoxColor;
				mObj.tag="GameCube";//设置tag
						mObj.transform.parent=GameObject.Find("CubeControl").transform;

						GenerateObject.mPlay.Play();//点击音效
			}
			Debug.Log("点击生成物体"+ListSub+","+_gameScene.Count );
		}
		if (RedSub >_gameScene.Count-1 && nextlock < ThisGameModel.ModelDic.Count-1/*3*//*正确的代码，前面的4是测试用，当nextlock小于modeldic字典内的元素*/ ) {

						GameObject.Find("CubeControl").transform.GetComponent<AudioSource>().Play();//播放结束的音效
						GameObject.Find("CubeControl").transform.localScale=new Vector3(1.5f,1.5f,1.5f);//结束后放大模型
//      			Invoke("PopupWindon",3.0f);//经过3.0f后实例弹窗 /*20170110 更改需求，“恭喜过关的弹窗”在游戏结束后直接实例化*/
//			_gameScene.Clear();
			Debug.Log("UI界面出现");
						UIInterface_01.gameObject.SetActive(false);
						UIInterface_02.gameObject.SetActive(true);
						//GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().enabled=true;//transform.parent=GameObject.Find("SwipeCube").transformGameObject.Find("CubeControl").transform.position=new Vector3(0,0,0);
						GameObject.Find("MyCamera").	GetComponent<QuickSwipe>().DisabledQuickComponent("mCamare02");
						GameObject.Find("MyCamera/Main Camera").	GetComponent<QuickSwipe>().DisabledQuickComponent("mCamare01");
						this.transform.position=new Vector3(0,2.5f,-2.5f);
						mCame_01.gameObject.transform.LookAt(GameObject.Find("CubeControl").transform);
						mGround.SetActive(false);
						//激活拥有相同名字的QUICHK组件
						GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().EnabledQuickComponent("SwipeCubeLR");
						GameObject.Find("CubeControl").	GetComponent<QuickSwipe>().EnabledQuickComponent("SwipeCubeUD");


			Onlock();

		}

	}
	/// <summary>
	/// 实例化出弹窗
	/// </summary>
	public void PopupWindon()
	{
							mCame_01.SetActive(false);

							UIInterface_01.gameObject.SetActive(false);
							UIInterface_02.gameObject.SetActive(true);
							GameObject _Popupswin=UIInterface_02.transform.Find("PopupWindon").gameObject;
		_Popupswin.transform.localPosition=Vector3.zero;
		_Popupswin.transform.localScale=Vector3.one;
				/*修改通关提示框没事的提示框内部的方块上的Text实时更新*/
/*		switch (SceneName)
		{
		case "Model_2A2Cube":
			_Popupswin.transform.Find("Window/LevelNumber/Text").GetComponent<Text>().text="0";
			break ;
		case "Model_2A4Cube":
			_Popupswin.transform.Find("Window/LevelNumber/Text").GetComponent<Text>().text="1";
			break ;
		case "Scene0":
			_Popupswin.transform.Find("Window/LevelNumber/Text").GetComponent<Text>().text="2";
			break ;
			//		case "Scene1":
			//			_Popupswin.transform.Find("Window/LevelNumber/Text").GetComponent<Text>().text="3";
			//			break ;
		default:
			for (int i = 0; i < ThisGameModel.ModelDic.Count; i++)
			{
				if ("Scene"+i.ToString()==SceneName)
				{
					_Popupswin.transform.Find("Window/LevelNumber/Text").GetComponent<Text>().text=(i+2).ToString();
				}	
			}
			break;
		}*/

	}

	public void Onlock()
	{

				if (SceneName=="Model_2A2Cube"||SceneName=="Model_2A4Cube")
				{
					if (SceneName=="Model_2A2Cube") {
						SceneName="Model_2A4Cube";	
					}
					else if (SceneName=="Model_2A4Cube")
					{
						SceneName="Scene0";
					}
					GameLevel.LevelJson["Scene0"]=1;	
				}
		else 
				{
					if (GameLevel.LevelJson.ContainsKey("Scene"+(nextlock+1).ToString()))
					{
						GameLevel.LevelJson["Scene"+(nextlock+1).ToString()]=1;

						//存储状态
						ToJson();
						SceneName="Scene"+(nextlock+1);
						nextlock+=1;		
						Debug.Log("SceneName Chang:"+GenerateObject.SceneName);
					}
				}
	}
	/// <summary>
	/// 摄像头发出去的射线
	/// </summary>
	public void CameraRay()
	{
		if (mCame_01.activeSelf)
		{
			Ray ray = mCame_01.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
			RaycastHit hitinfo;//定义一个射线检测信息
			if (Physics.Raycast(ray,out hitinfo))//发射射线
			{
				Debug.Log(hitinfo.collider.name);
				//如果发射的射线检测到物体，hitinfo里的collider就是碰撞的物体的碰撞器
				if (hitinfo.collider.tag == "Prompt")
				{
					//Destroy(hitinfo.collider.gameObject);
					hitinfo.collider.gameObject.SetActive(false);
					ClickGenerate(CubeObj,"Prefabs/001",Sub);
					ClickGenerate(mRedBox,"Prefabs/RedBox",RedSub);
					Debug.Log("22333");
				}

			}
			Debug.DrawLine(ray.origin,ray.origin+transform.forward*100.0f,Color.red);
		}
		
	}

	public static GameLevel mlevel;
	/// <summary>
	/// 序列化
	/// </summary>
	void ToJson()
	{
		string tojson=JsonUtility.ToJson(mlevel);
		PlayerPrefs.SetString("LEVEL_LOCK_OR_NOT",tojson);
	}
	/// <summary>
	/// 反序列化
	/// </summary>
	void FromJson()
	{
		string fromjson=PlayerPrefs.GetString("LEVEL_LOCK_OR_NOT");

	}
			/// <summary>
			/// 播放点击的音效
			/// </summary>
			public void OpenAudio()
			{
				mPlay.Play();
			}
}
/// <summary>
/// 游戏模式
/// </summary>
//public enum ModeType
//{
//	十字键滑杆模式 = 0,
//	自动追寻模式 = 1,
//	滑动模型模式 = 2
//
//}