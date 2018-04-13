using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * 代码替换为 ThisGameModel 
 * 
 * public class GameManagement : MonoBehaviour{

	public static List<Vector3> ObjVec3;
	public static Dictionary<string,List<Vector3>> SceneDic=new Dictionary<string, List<Vector3>>();
//	GameLevel mlevel;
	//要生成的预设体的Scala
	protected static float Scale_x=0.25f;
	protected static float Scale_y=0.025f;
	protected static float Scale_z=0.25f;

	void Awake()
	{
		
		if (SceneDic.Count==0) {
			Scene0_Vector3 ();
			Scene1_Vector3 ();
			Scene2_Vector3 ();
			Scene3_Vector3 ();
			Scene4_Vector3 ();
		}

	}
//	// Use this for initialization
	void Start () {
		if (GameLevel.LevelJson.Count==0) {
			MapLock();
		}
			
	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
	#region 管理模型的世界坐标
	/// <summary>
	/// 1X4的正方体
	/// </summary>
	public static void Scene0_Vector3()
	{
		ObjVec3=new List<Vector3>();// 开辟新的存储空间来保存场景内cube的坐标

		ObjVec3.Add(new Vector3(0.0f,Scale_y*5.0f,0.0f));//001//(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*5.0f,0.0f));//002//(0.25,0.125,0)
		ObjVec3.Add(new Vector3(0.0f,Scale_y*5.0f,-Scale_z));//003//(0,0.125,-0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*5.0f,-Scale_z));//004//(0.25,0.125,-0.25)

		SceneDic.Add("Scene0",ObjVec3);
		Debug.Log("GameManagement Scen0 :"+GameManagement.SceneDic.Count);
	}
	/// <summary>
	/// 2X2的正方体
	/// </summary>
	public static void Scene1_Vector3()
	{
		ObjVec3=new List<Vector3>();

		ObjVec3.Add(new Vector3(0.0f,Scale_y*5.0f,0.0f));//001          //(0.0, 0.125, 0.0)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*5.0f,0.0f));//002       //(0.25, 0.125, 0.0)
		ObjVec3.Add(new Vector3(0.0f,Scale_y*5.0f,-Scale_z));//003      //(0.0, 0.125, -0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*5.0f,-Scale_z));//004   //(0.25, 0.125, -0.25)
		ObjVec3.Add(new Vector3(0.0f,Scale_y*15.0f,0.0f));//005         //(0.0, 0.375, 0.0)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*15.0f,0.0f));//006      //(0.25, 0.375, 0.0)
		ObjVec3.Add(new Vector3(0.0f,Scale_y*15.0f,-Scale_z));//007     //(0.0, 0.375, -0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*15.0f,-Scale_z));//008  //(0.25, 0.375, -0.25)

		SceneDic.Add("Scene1",ObjVec3);
		Debug.Log("GameManagement Scenn1 :"+GameManagement.SceneDic.Count);
	}
	/// <summary>
	/// 爱心图形
	/// </summary>
	public static void Scene2_Vector3()
	{
		ObjVec3=new List<Vector3>();

		ObjVec3.Add(new Vector3(0.0f , Scale_y*5.0f , 0.0f));//032    //(0, 0.125, 0)
		ObjVec3.Add(new Vector3(0.0f , Scale_y*5.0f , -Scale_z));//016    //(0, 0.125, -0.25)
		ObjVec3.Add(new Vector3(0.0f , Scale_y*5.0f , -Scale_z*2));//013    //(0, 0.125, -0.5)
		ObjVec3.Add(new Vector3(0.0f , Scale_y*5.0f , -Scale_z*3));//012    //(0, 0.125, -0.75)
		ObjVec3.Add(new Vector3(0.0f , Scale_y*5.0f , -Scale_z*4));//010    //(0, 0.125, -1)
		ObjVec3.Add(new Vector3(0.0f , Scale_y*5.0f, -Scale_z*5));//001    //(0, 0.125, -1.25)
		ObjVec3.Add(new Vector3(Scale_x , Scale_y*5.0f , -Scale_z*4));//002    //(1, 0.125, -1)
		ObjVec3.Add(new Vector3(Scale_x*2 , Scale_y*5.0f , -Scale_z*3));//003    //(0, 0.125, 0)
		ObjVec3.Add(new Vector3(Scale_x*3 , Scale_y*5.0f , -Scale_z*2));//004    //(0,0.125, 0)
		ObjVec3.Add(new Vector3(Scale_x*4 , Scale_y*5.0f , -Scale_z));//005    //(0,0.125, 0)
		ObjVec3.Add(new Vector3(Scale_x*4 , Scale_y*5.0f , -0.0f));//006    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*3 , Scale_y*5.0f , Scale_z));//007    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*2 , Scale_y*5.0f , Scale_z*2));//008    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x , Scale_y*5.0f , Scale_z));//009    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x , Scale_y*5.0f , -Scale_z*3));//011    //(0,0.125,0)

		ObjVec3.Add(new Vector3(Scale_x , Scale_y*5.0f , -Scale_z*2));//014    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*2 , Scale_y*5.0f , -Scale_z*2));//015    //(0,0.125,0)

		ObjVec3.Add(new Vector3(Scale_x , Scale_y*5.0f, -Scale_z));//017    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*2 , Scale_y*5.0f , -Scale_z));//018    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*3 , Scale_y*5.0f, -Scale_z));//019    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x , Scale_y*5.0f, 0.0f));//020    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*2 , Scale_y*5.0f , 0.0f));//021    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*3 , Scale_y*5.0f , 0.0f));//022    //(0,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*2 , Scale_y*5.0f , Scale_z));//023    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x , Scale_y*5.0f, -Scale_z*4));//024    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*2 , Scale_y*5.0f, -Scale_z*3));//025    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*3 , Scale_y*5.0f , -Scale_z*2));//026    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*4 , Scale_y*5.0f, -Scale_z));//027    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*4 , Scale_y*5.0f , 0.0f));//028    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*3 , Scale_y*5.0f , Scale_z));//029    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*2 , Scale_y*5.0f , Scale_z*2));//030    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x , Scale_y*5.0f , Scale_z));//031    //(0,0.125,0)

		ObjVec3.Add(new Vector3(-Scale_x , Scale_y*5.0f , -Scale_z*3));//033    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x , Scale_y*5.0f , -Scale_z*2));//034    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*2 , Scale_y*5.0f , -Scale_z*2));//035    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x , Scale_y*5.0f , -Scale_z));//036    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*2 , Scale_y*5.0f , -Scale_z));//037    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*3 , Scale_y*5.0f , -Scale_z));//038    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x , Scale_y*5.0f , 0.0f));//039    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*2 , Scale_y*5.0f , 0.0f));//040    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*3 , Scale_y*5.0f , 0.0f));//041    //(0,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*2 , Scale_y*5.0f , Scale_z));//042    //(0,0.125,0)

		SceneDic.Add("Scene2",ObjVec3);
		Debug.Log("GameManagement Scenn2 :"+GameManagement.SceneDic.Count);
	}
	/// <summary>
	/// 钟表图形
	/// </summary>
	public static void Scene3_Vector3()
	{
		ObjVec3=new List<Vector3>();

		ObjVec3.Add(new Vector3(0,Scale_y*5f,0));//(0,0.125,0)
		ObjVec3.Add(new Vector3(0,Scale_y*5f,Scale_z*7.0f));//(0,0.125,1.75)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*5f,Scale_z*7.0f));//(0.25,0.125,1.75)
		ObjVec3.Add(new Vector3(Scale_x*2f,Scale_y*5f,Scale_z*7.0f));//(0.5,0.125,1.75)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*5f,Scale_z*7.0f));//(-0.25,0.125,1.75)
		ObjVec3.Add(new Vector3(-Scale_x*2.0f,Scale_y*5f,Scale_z*7.0f));//(-0.5,0.125,1.75)
		ObjVec3.Add(new Vector3(Scale_x*4.0f,Scale_y*5f,Scale_z*6.0f));//(-1,0.125,1.5)
		ObjVec3.Add(new Vector3(Scale_x*3.0f,Scale_y*5f,Scale_z*6.0f));//(0.75,0.125,1.5)
		ObjVec3.Add(new Vector3(Scale_x*5.0f,Scale_y*5f,Scale_z*5.0f));//(1.25,0.125,1.25)
		ObjVec3.Add(new Vector3(Scale_x*6.0f,Scale_y*5f,Scale_z *4.0f ));//(1.5,0.125,1)
		ObjVec3.Add(new Vector3(Scale_x*6.0f,Scale_y*5f,Scale_z*3.0f));//(1.5,0.125,0.75)
		ObjVec3.Add(new Vector3(Scale_x*7.0f,Scale_y*5f,Scale_z*2.0f));//(1.75,0.125,0.5);
		ObjVec3.Add(new Vector3(Scale_x *7.0f,Scale_y*5f,Scale_z ));//(1.75,0.125,0.25)
		ObjVec3.Add(new Vector3(Scale_x*7.0f,Scale_y*5f,0));//(1.75,0.125,0.25)
		ObjVec3.Add(new Vector3(Scale_x*7.0f,Scale_y*5f,-Scale_z));//(1.75,0.125,-0.25)
		ObjVec3.Add(new Vector3(Scale_x*7.0f,Scale_y*5f,-Scale_z*2.0f));//(1.75,0.125,-0.5)
		ObjVec3.Add(new Vector3(Scale_x*6.0f,Scale_y*5f,-Scale_z*3.0f));//(1.5,0.125,-0.75)
		ObjVec3.Add(new Vector3(Scale_x*6.0f,Scale_y*5f,-Scale_z*4.0f));//（1.5,0.125,-1）
		ObjVec3.Add(new Vector3(Scale_x*5.0f,Scale_y*5f,-Scale_z*5.0f));//(1.25,0.125,-1.25)
		ObjVec3.Add(new Vector3(Scale_x*4.0f,Scale_y*5f,-Scale_z*6.0f));//(1,0.125,-1.5)
		ObjVec3.Add(new Vector3(Scale_x*3.0f,Scale_y*5f,-Scale_z*6.0f));//(0.75,0.125,-1.5)
		ObjVec3.Add(new Vector3(Scale_x*2.0f,Scale_y*5f,-Scale_z*7.0f));//(0.5,0.125,-1.75)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*5f,-Scale_z*7.0f));//(0.25,0.125,-1.75)
		ObjVec3.Add(new Vector3(0,Scale_y*5f,-Scale_z*7.0f));//(0,0.125,-1.75)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*5f,-Scale_z*7.0f));//(-0.25,0.125,-1.75)
		ObjVec3.Add(new Vector3(-Scale_x*2.0f,Scale_y*5f,-Scale_z*7.0f));//(-0.5,0.125,-1.75)
		ObjVec3.Add(new Vector3(-Scale_x*3.0f,Scale_y*5f,-Scale_z*6.0f));//(-0.75,0.125,-1.5)
		ObjVec3.Add(new Vector3(-Scale_x*4.0f,Scale_y*5f,-Scale_z*6.0f));//(-1,0.125,-1.5)
		ObjVec3.Add(new Vector3(-Scale_x*5.0f,Scale_y*5f,-Scale_z*5.0f));//(-1.25,0.125,-1.25)
		ObjVec3.Add(new Vector3(-Scale_x*6.0f,Scale_y*5f,-Scale_z*4.0f));//(-1.5,0.125,-1)
		ObjVec3.Add(new Vector3(-Scale_x*6.0f,Scale_y*5f,-Scale_z*3.0f));//(-1.5,0.125,-0.75)
		ObjVec3.Add(new Vector3(-Scale_x*7.0f,Scale_y*5f,-Scale_z*2.0f));//(-1.75,0.125,-0.5)
		ObjVec3.Add(new Vector3(-Scale_x*7.0f,Scale_y*5f,-Scale_z));//(-1.75,0.125,-0.25)
		ObjVec3.Add(new Vector3(-Scale_x*7.0f,Scale_y*5f,0));//(-1.75,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*7.0f,Scale_y*5f,Scale_z));//(-1.75,0.125,0.25)
		ObjVec3.Add(new Vector3(-Scale_x*7.0f,Scale_y*5f,Scale_z*2.0f));//(-1.75,0.125,0.5)
		ObjVec3.Add(new Vector3(-Scale_x*6.0f,Scale_y*5f,Scale_z*3.0f));//(-1.5,0.125,0.75)
		ObjVec3.Add(new Vector3(-Scale_x*6.0f,Scale_y*5f,Scale_z*4.0f));//(-1.5,0.125,1)
		ObjVec3.Add(new Vector3(-Scale_x*5.0f,Scale_y*5f,Scale_z*5.0f));//(-1.25,0.125,1.25)
		ObjVec3.Add(new Vector3(-Scale_x*4.0f,Scale_y*5f,Scale_z*6.0f));//(-1,0.125,1.5)
		ObjVec3.Add(new Vector3(-Scale_x*3.0f,Scale_y*5f,Scale_z*6.0f));//(-0.75,0.125,1.5)
		ObjVec3.Add(new Vector3(0,Scale_y*5f,Scale_z));//(0,0.125,0.25)
		ObjVec3.Add(new Vector3(0,Scale_y*5f,Scale_z*2.0f));//(0,0.125,0.5)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*5f,0));//(0.25,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*2.0f,Scale_y*5f,0));//(0.5,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*3.0f,Scale_y*5f,0));//(0.75,0.125,0)
		ObjVec3.Add(new Vector3(0,Scale_y*5f,-Scale_z*6.0f));//(0,0.125,-1.5)
		ObjVec3.Add(new Vector3(0,Scale_y*5f,-Scale_z*5.0f));//(0,0.125,-1,25)
		ObjVec3.Add(new Vector3(Scale_x*6.0f,Scale_y*5f,0));//(1.5,0.125,0)
		ObjVec3.Add(new Vector3(Scale_x*5.0f,Scale_y*5f,0));//(1.25,0.125,0)
		ObjVec3.Add(new Vector3(0,Scale_y*5f,Scale_z*6.0f));//(0,0.125,1.5)
		ObjVec3.Add(new Vector3(0,Scale_y*5.0f,Scale_z*5.0f));//(0,0.125,1.25)
		ObjVec3.Add(new Vector3(-Scale_x*6.0f,Scale_y*5.0f,0));//(-1.5,0.125,0)
		ObjVec3.Add(new Vector3(-Scale_x*5.0f,Scale_y*5.0f,0));//(-1.25,0.125,0)
	
		SceneDic.Add("Scene3",ObjVec3);
		Debug.Log("GameManagement Scenn3 :"+GameManagement.SceneDic.Count);
	}
	/// <summary>
	/// 树的图形
	/// Scale_x=0.25f; Scale_y=0.025f; Scale_z=0.25f;
	/// </summary>
	public static void Scene4_Vector3()
	{
		ObjVec3=new List<Vector3>();

		ObjVec3.Add(new Vector3(0,Scale_y*5.0f,0));//(0,0.125,0)
		ObjVec3.Add(new Vector3(0,Scale_y*15.0f,0));//(0,0.375,0)
		ObjVec3.Add(new Vector3(0,Scale_y*25.0f,0));//(0,0.625,0)
		ObjVec3.Add(new Vector3(0,Scale_y*35.0f,0));//(0,0.875,0)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*45.0f,0));//(0.25,1.125,0)
		ObjVec3.Add(new Vector3(0,Scale_y*45.0f,Scale_z));//(0,1.125,0.25)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*45.0f,0));//(-0.25,1.125,0)
		ObjVec3.Add(new Vector3(0,Scale_y*45.0f,-Scale_z));//(0,1.125,-0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*55.0f,-Scale_z));//(0.25,1.375,-0.25)
	//	ObjVec3.Add(new Vector3(0,Scale_y*55.0f,-Scale_z));//(0,1.375,-0.25)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*55.0f,-Scale_z));//(-0.25,1.375,-0.25)
	//	ObjVec3.Add(new Vector3(-Scale_x,Scale_y*55.0f,0));//(-0.25,1.375,0)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*55.0f,Scale_z));//(-0.25,1.375,0.25)
	//	ObjVec3.Add(new Vector3(0,Scale_y*55.0f,Scale_z));//(0,1.375,0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*55.0f,Scale_z));//(0.25,1.375,0.25)
	//	ObjVec3.Add(new Vector3(Scale_x,Scale_y*55.0f,0));//(0.25,1.375,0)
		ObjVec3.Add(new Vector3(0,Scale_y*55.0f,-Scale_z*2));//(0,1.375,-0.5)
		ObjVec3.Add(new Vector3(Scale_x*2,Scale_y*55.0f,0));//(0.5,1.375,0)
		ObjVec3.Add(new Vector3(-Scale_x*2,Scale_y*55.0f,0));//(-0.5,1.375,0)
		ObjVec3.Add(new Vector3(0,Scale_y*55.0f,Scale_z*2));//(0,1.375,0.5)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*65.0f,Scale_z*2));//(-0.25,1.625,0.5)
		ObjVec3.Add(new Vector3(-Scale_x*2,Scale_y*65.0f,-Scale_z));//(-0.5,1.625,-0.25)
		ObjVec3.Add(new Vector3(Scale_x*2,Scale_y*65.0f,Scale_z));//(0.5,1.625,0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*65.0f,-Scale_z*2));//(0.25,1.625,-0.5)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*65.0f,0));//(0.25,1.625,0)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*65.0f,Scale_z));//(0.25,1.625,0.25)
		ObjVec3.Add(new Vector3(0,Scale_y*65.0f,Scale_z));//(0,1.625,0.25)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*65.0f,Scale_z));//(-0.25,1.625,0.25)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*65.0f,0));//(-0.25,1.625,0)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*65.0f,-Scale_z));//(-0.25,1.625,-0.25)
		ObjVec3.Add(new Vector3(0,Scale_y*65.0f,-Scale_z));//(0,1.625,-0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*65.0f,-Scale_z));//(0.25,1.625,-0.25)
		ObjVec3.Add(new Vector3(0,Scale_y*75.0f,-Scale_z));//(0,1.875,-0.25)
		ObjVec3.Add(new Vector3(0,Scale_y*75.0f,Scale_z));//(0,1.875,0.25)
		ObjVec3.Add(new Vector3(Scale_x,Scale_y*75.0f,0));//(0.25,1.875,0)
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*75.0f,0));//(-0.25,1.875,0)
		ObjVec3.Add(new Vector3(0,Scale_y*85.0f,0));//(0,2.125,0)

		SceneDic.Add("Scene4",ObjVec3);
		Debug.Log("GameManagement Scenn4 :"+GameManagement.SceneDic.Count);
	}
	/// <summary>
	/// 卡车的图形
	/// Scale_x=0.25f; Scale_y=0.025f; Scale_z=0.25f;
	/// </summary>
	public static void Scene5_Vector3()
	{
		ObjVec3=new List<Vector3>();
		//车轮01
		ObjVec3.Add(new Vector3(-Scale_x,Scale_y*5.0f,-Scale_z));//(-0.25, 0.125, -0.25)  // 1
		ObjVec3.Add(new Vector3(0,Scale_y*5.0f,-Scale_z));//(0, 0.125, -0.25)  // 2
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 0.375, -0.25)  // 3
		ObjVec3.Add(new Vector3(0,0,0));//(0, 0.375, -0.25)  // 4
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 0.375, -0.25)  // 5
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 0.375, -0.25)  // 6
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 0.625, -0.25)  // 7
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 0.625, -0.25)  // 8
		ObjVec3.Add(new Vector3(0,0,0));//(0, 0.625, -0.25)  // 9
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 0.625, -0.25)  // 10
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 0.625, -0.25)  // 11
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 0.625, -0.25)  // 12
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 0.875, -0.25)  // 13
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 0.875, -0.25)  // 14
		ObjVec3.Add(new Vector3(0,0,0));//(0, 0.875, -0.25)  // 15
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 0.875, -0.25)  // 16
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 0.875, -0.25)  // 17
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 0.875, -0.25)  // 18
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 1.125, -0.25)  // 19
		ObjVec3.Add(new Vector3(0,0,0));//(0, 1.125, -0.25)  // 20
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.125, -0.25)  // 21
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.125, -0.25)  // 22
		ObjVec3.Add(new Vector3(0,0,0));//(0, 1.375, -0.25)  // 23
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.375, -0.25)  // 24
		//车头
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 0.625, 0)  // 25
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 0.625, 0)  // 26
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 0.875, 0)  // 27
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 0.875, 0)  // 28
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.125, 0)  // 29
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.125, 0)  // 30
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.125, 0)  // 31
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.375, 0)  // 32
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.375, 0)  // 33
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.375, 0)  // 34
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.375, 0)  // 35
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.625, 0)  // 36
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.625, 0)  // 37
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.625, 0)  // 38
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.625, 0)  // 39
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.875, 0)  // 40
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.875, 0)  // 41
		ObjVec3.Add(new Vector3(0,0,0));//(0, 1.875, 0)  // 42
		ObjVec3.Add(new Vector3(0,0,0));//((0.25, 1.625, 0)  // 43
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 1.375, 0)  // 44
		ObjVec3.Add(new Vector3(0,0,0));//(0.75, 1.125, 0)  // 45
		ObjVec3.Add(new Vector3(0,0,0));//(0.75, 1.125, 1.5)  // 46
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 1.375, 1.5)  // 47
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 1.625, 1.5)  // 48
		ObjVec3.Add(new Vector3(0,0,0));//(0, 1.875, 1.5)  // 49
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.875, 1.5)  // 50
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.875, 1.5)  // 51
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.625, 1.5)  // 52
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.625, 1.5)  // 53
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.625, 1.5)  // 54
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.625, 1.5)  // 55
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.375, 1.5)  // 56
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.375, 1.5)  // 57
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.375, 1.5)  // 58
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.375, 1.5)  // 59
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.125, 1.5)  // 60
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.125, 1.5)  // 61
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.125, 1.5)  // 62
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.875, 1.5)  // 63
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 0.875, 1.5)  // 64
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 0.625, 1.5)  // 65
		ObjVec3.Add(new Vector3(0,0,0));//(-1.0, 0.625, 1.5)  // 66
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 0.625, 1.25)  // 67
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 0.625, 1.0)  // 68
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 0.625, 0.75)  // 69
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 0.625, 0.5)  // 70
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 0.625, 0.25)  // 71
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 0.875, 1.25)  // 72
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 0.875, 1.0)  // 73
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 0.875, 0.75)  // 74
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 0.875, 0.5)  // 75
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 0.875, 0.25)  // 76
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.125, 1.25)  // 77
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.125, 1)  // 78
		ObjVec3.Add(new Vector3(0,0,0));//(-1.5, 1.125, 0.75)  // 79
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.125, 0.5)  // 80
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.125, 0.25)  // 81
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.375, 0.25)  // 82
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.375, 0.5)  // 82
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.375, 0.75)  // 83
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.375, 1)  // 84
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.375, 1.25)  // 85
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.625, 1.25)  // 86
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.625, 1)  // 87
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.625, 0.75)  // 88
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.625, 0.5)  // 89
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.625, 0.25)  // 90
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.875, 0.25)  // 91
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.875, 0.5)  // 92
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.875, 0.75)  // 93
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.875, 1)  // 94
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 1.875, 1.25)  // 95
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.125, 1.25)  // 96
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.125, 1.25)  // 97
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.125, 1)  // 98
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.125, 0.75)  // 99
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.125, 0.5)  // 100
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.125, 0.25)  // 101
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.375, 0.25)  // 102
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.375, 0.5)  // 103
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.375, 0.75)  // 104
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.375, 1)  // 105
		ObjVec3.Add(new Vector3(0,0,0));//(-1.25, 2.375, 1.25)  // 106
		ObjVec3.Add(new Vector3(0,0,0));//(-1.0, 2.625, 1.25)  // 107
		ObjVec3.Add(new Vector3(0,0,0));//(-1.0, 2.625, 1)  // 108
		ObjVec3.Add(new Vector3(0,0,0));//(-1.0, 2.625, 0.75)  // 109
		ObjVec3.Add(new Vector3(0,0,0));//(-1.0, 2.625, 0.5)  // 110
		ObjVec3.Add(new Vector3(0,0,0));//(-1.0, 2.625, 0.25)  // 111
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.625, 0.25)  // 112
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.625, 0.5)  // 113
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.625, 0.75)  // 114
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.625, 1)  // 115
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.625, 1.25)  // 116
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.625, 1.25)  // 117
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.625, 1)  // 118
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.625, 0.75)  // 119
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.625, 0.5)  // 120
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.625, 0.25)  // 121
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.625, 0.25)  // 122
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.625, 0.5)  // 123
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.625, 0.75)  // 124
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.625, 1)  // 125
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.625, 1.25)  // 126
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 2.625, 1.25)  // 127
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 2.625, 1)  // 128
		ObjVec3.Add(new Vector3(0,0,0));//(0, 2.625, 0.75)  // 129
		ObjVec3.Add(new Vector3(0,0,0));//(0, 2.625, 0.5)  // 130
		ObjVec3.Add(new Vector3(0,0,0));//(0, 2.625, 0.25)  // 131
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.625, 0.25)  // 132
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.625, 0.5)  // 133
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.625, 0.75)  // 134
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.625, 1)  // 135
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.625, 1.25)  // 136
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.375, 1.25)  // 137
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.375, 1)  // 138
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.375, 0.75)  // 139
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.375, 0.5)  // 140
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.375, 0.25)  // 141
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.125, 0.25)  // 142
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.125, 0.5)  // 143
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.125, 0.75)  // 144
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.125, 1)  // 145
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.125, 1.25)  // 146
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.875, 0.25)  // 147
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.875, 0.25)  // 148
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 2.125, 0.25)  // 149
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.125, 0.25)  // 150
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.125, 0.25)  // 151
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.125, 0.25)  // 152
		ObjVec3.Add(new Vector3(0,0,0));//(0, 2.125, 0.25)  // 153
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 2.375, 0.25)  // 154
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.375, 0.25)  // 155
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.375, 0.25)  // 156
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.375, 0.25)  // 157
		ObjVec3.Add(new Vector3(0,0,0));//(-0.0, 2.375, 0.25)  // 158
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 2.375, 1.25)  // 159
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.375, 1.25)  // 160
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.375, 1.25)  // 161
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.375, 1.25)  // 162
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 2.375, 1.25)  // 163
		ObjVec3.Add(new Vector3(0,0,0));//(0, 2.125, 1.25)  // 164
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 2.125, 1.25)  // 165
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 2.125, 1.25)  // 166
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 2.125, 1.25)  // 167
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 2.125, 1.25)  // 168
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 1.875, 1.25)  // 169
		ObjVec3.Add(new Vector3(0,0,0));//(-1, 1.875, 1.25)  // 170
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 1.875, 1.25)  // 171
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 1.875, 1)  // 172
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 2.375, 0.75)  // 173
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 1.875, 0.5)  // 174
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 1.875, 0.25)  // 175
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 1.625, 0.5)  // 176
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 1.625, 0.75)  // 177
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 1.625, 1)  // 178
		ObjVec3.Add(new Vector3(0,0,0));//(0.75, 1.625, 0.75)  // 179

		//车轮02
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 0.125, 1.75)  // 180
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 0.125, 1.75)  // 181
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 0.375, 1.75)  // 182
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 0.375, 1.75)  // 183
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 0.375, 1.75)  // 184
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 0.375, 1.75)  // 185
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 0.625, 1.75)  // 186
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 0.625, 1.75)  // 187
		ObjVec3.Add(new Vector3(0,0,0));//(0, 0.625, 1.75)  // 188
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 0.625, 1.75)  // 189
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 0.625, 1.75)  // 190
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 0.625, 1.75)  // 191
		ObjVec3.Add(new Vector3(0,0,0));//(0.5, 0.875, 1.75)  // 192
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 0.875, 1.75)  // 193
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 0.875, 1.75)  // 194
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 0.875, 1.75)  // 195
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 0.875, 1.75)  // 196
		ObjVec3.Add(new Vector3(0,0,0));//(-0.75, 0.875, 1.75)  // 197
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 1.125, 1.75)  // 198
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.125, 1.75)  // 199
		ObjVec3.Add(new Vector3(0,0,0));//(-0.5, 1.125, 1.75)  // 200
		ObjVec3.Add(new Vector3(0,0,0));//(0.25, 1.125, 1.75)  // 201
		ObjVec3.Add(new Vector3(0,0,0));//(0.0, 1.375, 1.75)  // 202
		ObjVec3.Add(new Vector3(0,0,0));//(-0.25, 1.375, 1.75)  // 203

		//车轮03
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.125, -0.25)  // 204
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.125, -0.25)  // 205
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 0.375, -0.25)  // 206
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.375, -0.25)  // 207
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.375, -0.25)  // 208
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 0.375, -0.25)  // 209
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 0.625, -0.25)  // 210
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 0.625, -0.25)  // 211
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.625, -0.25)  // 212
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.625, -0.25)  // 213
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 0.625, -0.25)  // 214
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 0.625, -0.25)  // 215
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 0.875, -0.25)  // 216
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 0.875, -0.25)  // 217
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.875, -0.25)  // 218
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.875, -0.25)  // 219
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 0.875, -0.25)  // 220
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 0.875, -0.25)  // 221
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.125, -0.25)  // 222
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.125, -0.25)  // 223
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.125, -0.25)  // 224
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.125, -0.25)  // 225
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.375, -0.25)  // 226
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.375, -0.25)  // 227

		//车身
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.625, 1.5)  // 228
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.625, 1.25)  // 229
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.625, 1.0)  // 230
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.625, 0.75)  // 231
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.625, 0.5)  // 232
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.625, 0.25)  // 233
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.625, 0.0)  // 234
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.875, 0.0)  // 235
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.875, 0.25)  // 236
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.875, 0.5)  // 237
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.875, 0.75)  // 238
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.875, 1.0)  // 239
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.875, 1.25)  // 240
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.875, 1.5)  // 241
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.125, 1.5)  // 242
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.125, 1.25)  // 243
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.125, 1.0)  // 244
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.125, 0.75)  // 245
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.125, 0.5)  // 246
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.125, 0.25)  // 247
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.125, 0.0)  // 248
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.375, 0.0)  // 249
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.375, 0.25)  // 250
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.375, 0.5)  // 251
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.375, 0.75)  // 252
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.375, 1.0)  // 253
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.375, 1.25)  // 254
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.375, 1.5)  // 255
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.625, 1.5)  // 256
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.625, 1.25)  // 257
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.625, 1.0)  // 258
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.625, 0.75)  // 259
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.625, 0.5)  // 260
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.625, 0.25)  // 261
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 2.625, 0.0)  // 262
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 2.375, 1.5)  // 263
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 2.125, 1.5)  // 264
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.875, 1.5)  // 265
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.625, 1.5)  // 266
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.625, 1.5)  // 267
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.875, 1.5)  // 268
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 2.125, 1.5)  // 269
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 2.375, 1.5)  // 270
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 2.375, 1.5)  // 271
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 2.125, 1.5)  // 272
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.875, 1.5)  // 273
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.625, 1.5)  // 274
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.875, 1.5)  // 275
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 2.125, 1.5)  // 276
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 2.375, 1.5)  // 277
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 2.375, 1.5)  // 278
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 2.125, 1.5)  // 279
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.875, 1.5)  // 280
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.875, 1.5)  // 281
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 2.375, 1.5)  // 282
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 2.125, 1.5)  // 283
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.875, 1.5)  // 283
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 2.125, 1.5)  // 284
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 2.375, 1.5)  // 285
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 2.375, 1.5)  // 286
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 2.125, 1.5)  // 287
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.875, 1.5)  // 288
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.625, 1.5)  // 289
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.625, 0.0)  // 290
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.875, 0.0)  // 291
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 2.125, 0.0)  // 292
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 2.375, 0.0)  // 293
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 2.375, 0.0)  // 294
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 2.125, 0.0)  // 295
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.875, 0.0)  // 296
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 2.125, 0.0)  // 297
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 2.375, 0.0)  // 298
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.875, 0.0)  // 299
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.875, 0.0)  // 300
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 2.375, 0.0)  // 302
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 2.375, 0.0)  // 301
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 2.125, 0.0)  // 302
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.875, 0.0)  // 303
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.625, 0.0)  // 304
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.875, 0.0)  // 305
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 2.125, 0.0)  // 306
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 2.375, 0.0)  // 307
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 2.375, 0.0)  // 308
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 2.125, 0.0)  // 309
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.875, 0.0)  // 310
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.625, 0.0)  // 311
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.625, 0.0)  // 312
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.875, 0.0)  // 313
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 2.125, 0.0)  // 314
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 2.375, 0.0)  // 315
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.625, 0.25)  // 316
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.625, 0.5)  // 317
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.625, 0.75)  // 318
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.625, 1.0)  // 319
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 1.625, 1.25)  // 320
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.625, 1.25)  // 321
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.625, 1.0)  // 322
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.625, 0.75)  // 323
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.625, 0.5)  // 324
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.625, 0.25)  // 325
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.625, 0.25)  // 326
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.625, 0.5)  // 327
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.625, 0.75)  // 328
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.625, 1.0)  // 329
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.625, 1.25)  // 330
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.625, 1.25)  // 331
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.625, 1.0)  // 332
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.625, 0.75)  // 333
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.625, 0.5)  // 334
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.625, 0.25)  // 335
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.625, 0.25)  // 336
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.625, 0.5)  // 337
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.625, 0.75)  // 338
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.625, 1.0)  // 339
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.625, 1.25)  // 340
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.625, 1.25)  // 341
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.625, 1.0)  // 342
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.625, 0.75)  // 343
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.625, 0.5)  // 344
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 1.625, 0.25)  // 345
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.625, 0.25)  // 346
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.625, 0.5)  // 347
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.625, 0.75)  // 348
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.625, 1.0)  // 349
		ObjVec3.Add(new Vector3(0,0,0));//(3.0, 1.625, 1.25)  // 350
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.375, 1.5)  // 351
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.375, 1.5)  // 352
		ObjVec3.Add(new Vector3(0,0,0));//(1.25, 1.375, 0.0)  // 353
		ObjVec3.Add(new Vector3(0,0,0));//(1.0, 1.375, 0.0)  // 354
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.625, 1.25)  // 355
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.625, 1.0)  // 356
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.625, 0.75)  // 357
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.625, 0.5)  // 358
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.625, 0.25)  // 359
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 2.375, 0.0)  // 360
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 2.125, 0.0)  // 361
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.875, 0.0)  // 362
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.625, 0.0)  // 363
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.625, 1.5)  // 364
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 1.875, 1.5)  // 365
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 2.125, 1.5)  // 366
		ObjVec3.Add(new Vector3(0,0,0));//(3.25, 2.375, 1.5)  // 367

		//车轮04
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.125, 1.75)  // 368
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.125, 1.75)  // 369
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 0.375, 1.75)  // 370
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 0.375, 1.75)  // 371
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.375, 1.75)  // 372
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.375, 1.75)  // 373
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 0.625, 1.75)  // 374
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 0.625, 1.75)  // 375
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.625, 1.75)  // 376
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.625, 1.75)  // 377
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 0.625, 1.75)  // 378
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 0.625, 1.75)  // 379
		ObjVec3.Add(new Vector3(0,0,0));//(2.75, 0.875, 1.75)  // 380
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 0.875, 1.75)  // 381
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 0.875, 1.75)  // 382
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 0.875, 1.75)  // 383
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 0.875, 1.75)  // 384
		ObjVec3.Add(new Vector3(0,0,0));//(1.5, 0.875, 1.75)  // 385
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.125, 1.75)  // 386
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.125, 1.75)  // 387
		ObjVec3.Add(new Vector3(0,0,0));//(1.75, 1.125, 1.75)  // 388
		ObjVec3.Add(new Vector3(0,0,0));//(2.5, 1.125, 1.75)  // 389
		ObjVec3.Add(new Vector3(0,0,0));//(2.25, 1.375, 1.75)  // 390
		ObjVec3.Add(new Vector3(0,0,0));//(2.0, 1.375, 1.75)  // 391


		SceneDic.Add("Scene5",ObjVec3);
		Debug.Log("GameManagement Scenn5 :"+GameManagement.SceneDic.Count);
	}
	#endregion 

	/// <summary>
	///加载所有关卡，默认出来第一个场景外其余上锁
	/// </summary>
	public void MapLock()
	{
		
		for (int i = 0; i <SceneDic.Count; i++) {
			if (i==0) {
				GameLevel.LevelJson.Add("Scene"+i.ToString(),1);
				Debug.Log("场景的数量 : "+SceneDic.Count);
			}
			if (i>0) {
				GameLevel.LevelJson.Add("Scene"+i.ToString(),0);
				Debug.Log(i+":"+GameLevel.LevelJson.Count.ToString());
			}
		}
	}
}
*/