using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// 脚本功能 ：
/// 搭载组件 ： 调色板 Palette /  PopupWindon / 
/// </summary>
public class thisGameUIManagement : MonoBehaviour {
//	List<string>LevelJson=new List<string>();
	public static Color mBoxColor;//生成的物体的颜色 
	public Transform ParenCanvas;
	public Transform ParenCanvas_02;
	private Transform mMask;
	private Transform mConfirPop;
	PopupsType mtype;
//	private GameObject mGround;
	// Use this for initialization
	void Start () {

		mMask=ParenCanvas.Find("Mask");
		mConfirPop=ParenCanvas.Find("ConfirmPopup");
		mBoxColor.r = 161.0f/255.0f;
		mBoxColor.g = 255.0f/255.0f;
		mBoxColor.b = 230.0f/255.0f;
		mBoxColor.a = 255.0f/255.0f;

//		mGround=GameObject.Find("Ground/GroundPlane").transform.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// 点击退出游戏
	/// </summary>
	public void UGUIClickExit()
	{
		UGUIClickConfirm(PopupsType.Exit);
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	/// <summary>
	/// 点击当前场景
	/// </summary>
	public void UGUIClickExitLevel()
	{
		UGUIClickConfirm(PopupsType.Level);
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	/// <summary>
	/// 重新开始游戏
	/// </summary>
	public void UGUIClickAgain()
	{

		Destroy(this.gameObject);
		SceneManager.LoadScene("01");
		Debug.Log("重新开始游戏");
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	/// <summary>
	/// 下一个场景
	/// </summary>
	public void UGUIClickNext()
	{

		GameObject loading=(GameObject)Instantiate(Resources.Load("Prefabs/LoadingCavas"),ParenCanvas_02);
		loading.transform.localScale=Vector3.one;
		loading.transform.localPosition=new Vector3(14f,-396f,0f);
		loading.AddComponent<ThisGameLoading>();

//		ParenCanvas_02.gameObject.SetActive(false);
//		GameObject.Find("Camera").SetActive(false);

		Debug.Log("下一个场景");
		GenerateObject.mPlay.Play();//点击按钮音效
	}

	#region 调色板
	/// <summary>
	/// 改变将要生成的物体的颜色
	/// </summary>
	public void ChangeCubColor()
	{
		string ColorName =this.gameObject.name;
		switch (ColorName)
		{
		case "Red" :
			mBoxColor.r = 243.0f/255.0f;
			mBoxColor.g = 136.0f/255.0f;
			mBoxColor.b = 139.0f/255.0f;
			mBoxColor.a = 255.0f/255.0f;//获取点击的图片的颜色
			break;
		case "Orange" :
			mBoxColor.r = 251.0f/255.0f;
			mBoxColor.g = 210.0f/255.0f;
			mBoxColor.b = 73.0f/255.0f;
			mBoxColor.a = 255.0f/255.0f;//获取点击的图片的颜色
			break;
		case "Yellow" :
			mBoxColor.r = 252.0f/255.0f;
			mBoxColor.g = 245.0f/255.0f;
			mBoxColor.b = 66.0f/255.0f;
			mBoxColor.a = 255.0f/255.0f;//获取点击的图片的颜色
			break;
		case "Green" :
			mBoxColor.r = 221.0f/255.0f;
			mBoxColor.g = 246.0f/255.0f;
			mBoxColor.b = 188.0f/255.0f;
			mBoxColor.a = 255.0f/255.0f;//获取点击的图片的颜色
			break;
		case "Green_2" :
			mBoxColor.r = 136.0f/255.0f;
			mBoxColor.g = 243.0f/255.0f;
			mBoxColor.b = 226.0f/255.0f;
			mBoxColor.a = 255.0f/255.0f;//获取点击的图片的颜色
			break;
		case "Blue" :
			mBoxColor.r = 194.0f/255.0f;
			mBoxColor.g = 240.0f/255.0f;
			mBoxColor.b = 247.0f/255.0f;
			mBoxColor.a = 255.0f/255.0f;//获取点击的图片的颜色
			break;
		case "Purple" :
			mBoxColor.r = 158.0f/255.0f;
			mBoxColor.g = 187.0f/255.0f;
			mBoxColor.b = 230.0f/255.0f;
			mBoxColor.a = 255.0f/255.0f;//获取点击的图片的颜色
			break;
		default:
			break;
		}
		Debug.Log("This.GameObject.Name : "+this.gameObject.name );
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	#endregion

	#region  提示窗口
	/// <summary>
	/// 关闭窗口
	/// </summary>
	public void UGUIClickDestroy()
	{
		ParenCanvas.gameObject.SetActive(true);
		ParenCanvas_02.gameObject.SetActive(false);
		GameObject.Find("CubeControl").transform.rotation=new Quaternion(0.0f,0.0f,0.0f,0.0f);
//		mGround.SetActive(true);
	
		//Destroy(this.gameObject);
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	/// <summary>
	/// 确认的窗口_出现
	/// </summary>
	private void UGUIClickConfirm(PopupsType mType)
	{
		mMask.gameObject.SetActive(true);
		mConfirPop.gameObject.SetActive(true);
		switch (mType)
		{
		case PopupsType.Exit:
			mConfirPop.Find("Text").GetComponent<Text>().text="您确定要退出游戏吗？";
			break;
		case PopupsType.Level:
			mConfirPop.Find("Text").GetComponent<Text>().text="您确定要退出此关卡吗？";
			break;
		default:
			break;
		}
		mtype=mType;
	}
	/// <summary>
	/// 执行方法
	/// </summary>
	/// <param name="mtype">Mtype = Exit 点击退出按钮后出现的提示窗口. Or  Mtype = level  点击关卡后出现的提示窗口</param>
	public void UGUIPopups()
	{
		switch (mtype)
		{
		case PopupsType.Exit:
			Application.Quit();
			Debug.Log("点击退出游戏");
			break;
		case PopupsType.Level:
			
			break;
		default:
			break;
		}
		GenerateObject.mPlay.Play();//点击按钮音效
	}
		/// <summary>
		/// 关闭提示窗口
		/// </summary>
	public void UGUIUnPop()
	{
		mMask.gameObject.SetActive(false);
		mConfirPop.gameObject.SetActive(false);
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	#endregion
}

public enum PopupsType
{
	Exit,
	Level
}



