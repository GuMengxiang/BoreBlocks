using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;//DOTween命名空间

public class ThisGame_EventManager : MonoBehaviour {
	
	 Transform mCanvas;
	bool isOpen=true;
	Transform LevelManagTrans;
	Transform DoLevelManagTrans;
	private bool CanClick = false;

	Sprite level_lock_sprite;
	Sprite level_unlock_sprite;

	float myPanelWidth = 0.0f;	
	// Use this for initialization
	void Start () {
		DOTween.Init(true,true,LogBehaviour.Verbose).SetCapacity(200,10);//用指定参数初始化，并同时指定同时执行Tweeners和Sequence的容量

		mCanvas=GameObject.Find("Canvas_01").transform;

		LevelManagTrans=mCanvas.transform.Find("LevelPopus/Levelmanaget");

		DoLevelManagTrans=LevelManagTrans.Find("Panel/levelmanaget");

		level_lock_sprite = Resources.Load("Sprite/iOS/img_level_lock",typeof(Sprite))as Sprite;
		level_unlock_sprite = Resources.Load("Sprite/iOS/img_level",typeof(Sprite))as Sprite;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick()
	{
		PlayerPrefs.DeleteKey("NovicOver");
	}
	/// <summary>
	/// 点击关卡界面上的左右箭头完成左右滑动
	/// </summary>
	public void DoScroll_To()//level_right_Button的点击事件
	{
		float a=-((float)ThisGameModel.ModelDic.Count)/2.0f/3.0f*DoLevelManagTrans.parent.GetComponent<RectTransform>().sizeDelta.x;
		if (myPanelWidth>a) {
			DoLevelManagTrans.DOLocalMoveX(myPanelWidth-DoLevelManagTrans.parent.GetComponent<RectTransform>().sizeDelta.x,0.5f,false);
			myPanelWidth=myPanelWidth-DoLevelManagTrans.parent.GetComponent<RectTransform>().sizeDelta.x;
		}
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	public void DoScroll_From()//levelwin_left_Button的点击事件
	{
		if (myPanelWidth<0.0f) {
			DoLevelManagTrans.DOLocalMoveX(myPanelWidth + DoLevelManagTrans.parent.GetComponent<RectTransform>().sizeDelta.x,0.5f,false);
			myPanelWidth=myPanelWidth + DoLevelManagTrans.parent.GetComponent<RectTransform>().sizeDelta.x;
		}
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	/// <summary>
	/// 打开关卡选择界面
	/// </summary>
	public void OpenLock()
	{
		int a=0;//上锁的状态
		if(isOpen){
			mCanvas.Find("ExitGame").gameObject.SetActive(false);//关闭退出按钮
			mCanvas.Find("Level_Button").gameObject.SetActive(false);//关闭关卡按钮
			LevelManagTrans.gameObject.SetActive(true);//打开关卡锁的界面
/*		for(int i=0; i <ThisGameModel.ModelDic.Count; i++)//for (int i = 0; i < GameManagement.SceneDic.Count; i++)
			{
				GameObject leve =(GameObject)Instantiate(Resources.Load("Prefabs/level"),LevelManagTrans.Find("levelmanaget"));//实例关卡的图标
				leve.transform.localPosition=Vector3.zero;
				leve.transform.localScale=Vector3.one;

//			if (GameLevel.LevelJson["Scene"+i.ToString()]==1||GameLevel.LevelJson["Model_2A2Cube"]==1||GameLevel.LevelJson["Model_2A4Cube"]==1)//查询关卡字典内相应关卡ID，得到关卡状态
//				{	// 1:解锁  0:未解锁
//					leve.transform.Find("lock").gameObject.SetActive(false);
//
//				}
*/
				foreach (var item in GameLevel.LevelJson) {
					GameObject leve =(GameObject)Instantiate(Resources.Load("Prefabs/level"),LevelManagTrans.Find("Panel/levelmanaget"));//实例关卡的图标
				    leve.name=item.Key;
				leve.GetComponent<Image>().sprite=level_lock_sprite;
					leve.transform.localPosition=Vector3.zero;
					leve.transform.localScale=Vector3.one;
					if (item.Value==1) {
						// 1:解锁  0:未解锁
//						leve.transform.Find("lock").gameObject.SetActive(false);
					leve.GetComponent<Image>().sprite=level_unlock_sprite;
					leve.transform.Find("Text").gameObject.SetActive(true);
					leve.transform.Find("Text").gameObject.GetComponent<Text>().text=a.ToString();
					a++;
					}
				}
				isOpen=!isOpen;
			}
		//排序
		DoLevelManagTrans.GetComponent<GridLayoutGroup>().constraintCount = ThisGameModel.ModelDic.Count/2+1;

		GenerateObject.mPlay.Play();//点击按钮音效
		}
//	}
	/// <summary>
	/// 关闭关卡界面 
	/// </summary>
	public void UnOpenLock()
	{
		if (!isOpen) 
		{
			LevelManagTrans.gameObject.SetActive(false);//关闭关卡锁的界面
			mCanvas.Find("ExitGame").gameObject.SetActive(true);//打开退出按钮
			mCanvas.Find("Level_Button").gameObject.SetActive(true);//打开关卡按钮
			for (int i = 0; i < LevelManagTrans.Find("Panel/levelmanaget").childCount; i++)
			{
				Destroy (LevelManagTrans.Find("Panel/levelmanaget").GetChild (i).gameObject);  	///删除掉生成的 关卡管理器 的子类
			}

			isOpen=!isOpen;
		}
		GenerateObject.mPlay.Play();//点击按钮音效
	}

	/// <summary>
	/// 点击关卡的图标来选择关卡
	/// </summary>
	public void ChooseLevel()
	{
		if (LevelManagTrans.Find("Panel/levelmanaget/"+ this.gameObject.name).gameObject.GetComponent<Image>().sprite!=level_lock_sprite) { ///只有不上锁（即上锁的图标关闭）的关卡才能点击
			GenerateObject.SceneName=this.gameObject.name;
			GameObject loading=(GameObject)Instantiate(Resources.Load("Prefabs/LoadingCavas"),mCanvas);
			loading.transform.localScale=Vector3.one;
			loading.transform.localPosition=new Vector3(14f,-396f,0f);
			loading.AddComponent<ThisGameLoading>();
			LevelManagTrans.gameObject.SetActive(false);//关闭关卡锁的界面
		}
		GenerateObject.mPlay.Play();//点击按钮音效
	}
}
