using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisGameModel : MonoBehaviour {
	public static List<Vector3> ModVec3;//model's vector3
	public static Dictionary<string,List<Vector3>> ModelDic=new Dictionary<string, List<Vector3>>(); //model's dictionary

	void Awake()
	{
		if (ModelDic.Count==0) {
			Model_2A2Cube();
			Model_2A4Cube();
			Model_01();
			Model_02();
			Model_03();
			Model_04();
			Model_05();
//			Model_06();
			Debug.Log("ModelDic.Count: "+ModelDic.Count.ToString());
		}
	}
	// Use this for initialization
	void Start () {
		if (GameLevel.LevelJson.Count==0) {
			MapLock();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// 2A2Cube
	/// </summary>
	public static void Model_2A2Cube()
	{
		GameObject mModel=(GameObject)Instantiate(Resources.Load("Prefabs/Model/2A2Cube"));//加载资源中需要的模型
		ModVec3=new List<Vector3>();

		for (int i = 0; i < mModel.transform.childCount; i++) {//将模型内每个子物体的位置保存为list
			ModVec3.Add(mModel.transform.GetChild(i).position);
//			Debug.Log("Scene0" +"坐标" + ModVec3.Count.ToString());

		}
//		Debug.Log(mModel.transform.GetChild(0).position.x.ToString()+","+ mModel.transform.GetChild(0).position.y.ToString()+","+mModel.transform.GetChild(0).position.z.ToString());
		ModelDic.Add("Model_2A2Cube",ModVec3);//将此模型子物体的位置的集合保存

		Debug.Log("ThisGameModel 00 :"+ ModelDic.Count);

		Destroy(mModel);//删除生成出来模型
	}

	/// <summary>
	/// 2A4Cube
	/// </summary>
	public static void Model_2A4Cube()
	{
		GameObject mModel=(GameObject)Instantiate(Resources.Load("Prefabs/Model/2A4Cube"));//加载资源中需要的模型
		ModVec3=new List<Vector3>();

		for (int i = 0; i < mModel.transform.childCount; i++) {//将模型内每个子物体的位置保存为list
			ModVec3.Add(mModel.transform.GetChild(i).position);
//			Debug.Log("Scene1" +"坐标" + ModVec3.Count.ToString());

		}
		//		Debug.Log(mModel.transform.GetChild(0).position.x.ToString()+","+ mModel.transform.GetChild(0).position.y.ToString()+","+mModel.transform.GetChild(0).position.z.ToString());
		ModelDic.Add("Model_2A4Cube",ModVec3);//将此模型子物体的位置的集合保存

		Debug.Log("ThisGameModel 01 :"+ ModelDic.Count);

		Destroy(mModel);//删除生成出来模型
	}

	/// <summary>
	/// Heart
	/// </summary>
	public static void Model_01()
	{
		GameObject mModel=(GameObject)Instantiate(Resources.Load("Prefabs/Model/Heart"));//加载资源中需要的模型
		ModVec3=new List<Vector3>();

		for (int i = 0; i < mModel.transform.childCount; i++) {//将模型内每个子物体的位置保存为list
			ModVec3.Add(mModel.transform.GetChild(i).position);
//			Debug.Log("Scene2" +"坐标" + ModVec3.Count.ToString());

		}
		//		Debug.Log(mModel.transform.GetChild(0).position.x.ToString()+","+ mModel.transform.GetChild(0).position.y.ToString()+","+mModel.transform.GetChild(0).position.z.ToString());
		ModelDic.Add("Scene0",ModVec3);//将此模型子物体的位置的集合保存

		Debug.Log("ThisGameModel Scen0 :"+ ModelDic.Count);

		Destroy(mModel);//删除生成出来模型
	}

	/// <summary>
	/// Clock
	/// </summary>
	public static void Model_02()
	{
		GameObject mModel=(GameObject)Instantiate(Resources.Load("Prefabs/Model/Clock"));//加载资源中需要的模型
		ModVec3=new List<Vector3>();

		for (int i = 0; i < mModel.transform.childCount; i++) {//将模型内每个子物体的位置保存为list
			ModVec3.Add(mModel.transform.GetChild(i).position);
//			Debug.Log("Scene3" +"坐标" + ModVec3.Count.ToString());

		}
		//		Debug.Log(mModel.transform.GetChild(0).position.x.ToString()+","+ mModel.transform.GetChild(0).position.y.ToString()+","+mModel.transform.GetChild(0).position.z.ToString());
		ModelDic.Add("Scene1",ModVec3);//将此模型子物体的位置的集合保存

		Debug.Log("ThisGameModel Scen1 :"+ ModelDic.Count);

		Destroy(mModel);//删除生成出来模型
	}

	/// <summary>
	/// Tree
	/// </summary>
	public static void Model_03()
	{
		GameObject mModel=(GameObject)Instantiate(Resources.Load("Prefabs/Model/Tree"));//加载资源中需要的模型
		ModVec3=new List<Vector3>();

		for (int i = 0; i < mModel.transform.childCount; i++) {//将模型内每个子物体的位置保存为list
			ModVec3.Add(mModel.transform.GetChild(i).position);
//			Debug.Log("Scene4" +"坐标" + ModVec3.Count.ToString());

		}
		//		Debug.Log(mModel.transform.GetChild(0).position.x.ToString()+","+ mModel.transform.GetChild(0).position.y.ToString()+","+mModel.transform.GetChild(0).position.z.ToString());
		ModelDic.Add("Scene2",ModVec3);//将此模型子物体的位置的集合保存

		Debug.Log("ThisGameModel Scen2 :"+ ModelDic.Count);

		Destroy(mModel);//删除生成出来模型
	}

	/// <summary>
	/// Truck
	/// </summary>
	public static void Model_04()
	{
		GameObject mModel=(GameObject)Instantiate(Resources.Load("Prefabs/Model/Truck"));//加载资源中需要的模型
		ModVec3=new List<Vector3>();

		for (int i = 0; i < mModel.transform.childCount; i++) {//将模型内每个子物体的位置保存为list
			ModVec3.Add(mModel.transform.GetChild(i).position);
//			Debug.Log("Scene5" +"坐标"+ ModVec3.Count.ToString());

		}
		//		Debug.Log(mModel.transform.GetChild(0).position.x.ToString()+","+ mModel.transform.GetChild(0).position.y.ToString()+","+mModel.transform.GetChild(0).position.z.ToString());
		ModelDic.Add("Scene3",ModVec3);//将此模型子物体的位置的集合保存

		Debug.Log("ThisGameModel Scen3 :"+ ModelDic.Count);

		Destroy(mModel);//删除生成出来模型
	}

	/// <summary>
	/// Windmill
	/// </summary>
	public static void Model_05()
	{
		GameObject mModel=(GameObject)Instantiate(Resources.Load("Prefabs/Model/Windmill"));//加载资源中需要的模型
		ModVec3=new List<Vector3>();

		for (int i = 0; i < mModel.transform.childCount; i++) {//将模型内每个子物体的位置保存为list
			ModVec3.Add(mModel.transform.GetChild(i).position);
			//			Debug.Log("Scene5" +"坐标"+ ModVec3.Count.ToString());

		}
		//		Debug.Log(mModel.transform.GetChild(0).position.x.ToString()+","+ mModel.transform.GetChild(0).position.y.ToString()+","+mModel.transform.GetChild(0).position.z.ToString());
		ModelDic.Add("Scene4",ModVec3);//将此模型子物体的位置的集合保存

		Debug.Log("ThisGameModel Scen4 :"+ ModelDic.Count);

		Destroy(mModel);//删除生成出来模型
	}

	/// <summary>
	///加载所有关卡，默认出来第一个场景外其余上锁
	/// </summary>
	public void MapLock()
	{


/*		for (int i = 0; i <ModelDic.Count; i++) {

			if (i==0) {
				GameLevel.LevelJson.Add("Scene"+i.ToString(),1);
				Debug.Log("场景的数量 : "+ModelDic.Count);
			}
			else if (i>0) {
				GameLevel.LevelJson.Add("Scene"+i.ToString(),0);
				Debug.Log(i+":"+GameLevel.LevelJson.Count.ToString());
			}
			else {
				GameLevel.LevelJson.Add("Model_2A2Cube",1);
				GameLevel.LevelJson.Add("Model_2A4Cube",1);
			}
		}  */
		foreach (var item in ModelDic) {
			switch (item.Key) {
			case"Model_2A2Cube":
				GameLevel.LevelJson.Add("Model_2A2Cube",1);
				break;
			case"Model_2A4Cube":
				GameLevel.LevelJson.Add("Model_2A4Cube",1);
				break;
			case "Scene0":
				GameLevel.LevelJson.Add("Scene0",1);
				break;
			default:
				GameLevel.LevelJson.Add(item.Key,0);
				break;
			}
		}
		Debug.LogError("MapLock : "+GameLevel.LevelJson.Count.ToString());
	}
}


/// <summary>
/// 游戏关卡单例
/// </summary>
public class GameLevel
{
	/// <summary>
	/// 关卡
	/// </summary>
	public int LevelID{get;set;}
	/// <summary>
	/// 关卡名称
	/// </summary>
	public string LevelName{get;set;}
	/// <summary>
	/// 关卡解锁
	/// 1:解锁  0:未解锁
	/// </summary>
	public int UnLock{get;set;}

	public static Dictionary<string,int>LevelJson=new Dictionary<string, int>(); 

	private static GameLevel _inatance = null;

	private GameLevel()
	{

	}

	public static GameLevel Getinstance()
	{
		if (_inatance == null) {
			_inatance=new GameLevel();

		}
		return _inatance;

	}
}