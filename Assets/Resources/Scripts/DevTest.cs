using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Test01();
	}
	/// <summary>
	/// 点击鼠标左键生成cube，点击鼠标右键销毁Cube
	/// </summary>
	public void Test01()
	{
		//按下鼠标左键时响应该方法  
		if(Input.GetMouseButtonDown(0))  
		{  
			//创建一条射线一摄像机为原点  
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
			RaycastHit hit;  
			//射线碰撞到游戏地形时  
			if(Physics.Raycast(ray,out hit))  
			{  
				//立方体     
				GameObject obj =(GameObject)Instantiate(Resources.Load("Prefabs/RedBox"));
				obj.transform.position = hit.point;  

			}  
		}
		 
		if (Input.GetMouseButtonDown(1)) {
			//创建一条射线一摄像机为原点  
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
			RaycastHit hit;  
			//射线碰撞到游戏地形时  
			if(Physics.Raycast(ray,out hit))  
			{  
				Destroy(hit.collider.gameObject);
			}  
		}
	}
}
