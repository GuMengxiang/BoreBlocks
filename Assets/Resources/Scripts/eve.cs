using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eve : MonoBehaviour {

	// 延迟时间  
	private float delay = 0.2f;  

	// 按钮是否是按下状态  
	private bool isDown = false;//上下键
	private bool isROLDown = false;//左右键
	private bool isRiseDecline=false;//上升下降键

	// 按钮最后一次是被按住状态时候的时间  
	private float lastIsDownTime;  

	private GameObject obj;//摄像机
	public float speed = 2.0f;// 速度

	// Use this for initialization
	void Start () {
		obj=GameObject.Find("MyCamera");
	}
	// Update is called once per frame
	#region 十字键
	void Update () 
	{
		// 如果上键或者下键按钮是被按下状态  (摄像机会前进或后退)
		if (isDown) {  
			// 当前时间 -  按钮最后一次被按下的时间 > 延迟时间0.2秒  
			if (Time.time - lastIsDownTime > delay) 
			{  
//				float y = Input.GetAxis("Vertical")*Time.deltaTime * 10.0f;  //上下
				obj.GetComponent<Rigidbody>().AddForce(Vector3.forward*speed*1000*Time.deltaTime);
//				obj.transform.Translate(new Vector3(0.0f,y*speed,0.0f));
				//obj.transform.localPosition += Vector3.forward * speed*Time.deltaTime;
//				obj.transform.Translate (new Vector3(0.0f,0.0f,speed),Space.World);
				// 记录按钮最后一次被按下的时间  
				lastIsDownTime = Time.time;
			} 
		}  
		// 如果左键或右键按钮是被按下状态  
		if (isROLDown) {  
			// 当前时间 -  按钮最后一次被按下的时间 > 延迟时间0.2秒  
			if (Time.time - lastIsDownTime > delay  ) 
			{  
				// 触发长按方法  
				Debug.Log("长按");  
//				float x = Input.GetAxis("Horizontal");  //左右
				if (obj.transform.rotation.y!=0.0f) {
					//obj.transform.localPosition += new Vector3(speed*Time.deltaTime ,0.0f,speed*Time.deltaTime );
					obj.GetComponent<Rigidbody>().AddForce(speed*1000*Time.deltaTime ,0.1f*Time.deltaTime,speed*1000*Time.deltaTime );
				} 
				else
				{
					obj.GetComponent<Rigidbody>().AddForce(Vector3.right*speed*1000*Time.deltaTime );
				}

				// 记录按钮最后一次被按下的时间  
				lastIsDownTime = Time.time;  
			}  
		}

		//如果是上升键或者下降键是被按下的状态
		if (isRiseDecline) {
			// 当前时间 -  按钮最后一次被按下的时间 > 延迟时间0.2秒  
			if (Time.time - lastIsDownTime > delay  ) 
			{ 
				obj.GetComponent<Rigidbody>().AddForce(Vector3.up*speed*1000*Time.deltaTime );
				// 记录按钮最后一次被按下的时间  
				lastIsDownTime = Time.time;
			}
		}
	}
	#region 上下键
	/// <summary>
	/// 按钮抬起时出发
	/// </summary>
	public void ButtonUp ()
	{
		isDown = false;
	}
	/// <summary>
	/// 离开按钮时触发
	/// </summary>
	public void  ButtonExit ()
	{
		isDown = false;
	}
	/// <summary>
	/// 按钮被按下时触发
	/// </summary>
	public void  ButtonDown ()
	{
		isDown = true;
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	#endregion
	#region 左右键
	public void ROLButtonDown()
	{
		isROLDown = true ;
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	public void ROLButtonUp()
	{
		isROLDown = false;
	}
	public void  ROLButtonExit()
	{
		isROLDown = false;
	}
	#endregion
	#region 上升下降键
	public void RiseDeclineDown()
	{
		isRiseDecline=true;
		GenerateObject.mPlay.Play();//点击按钮音效
	}
	public void RiseDeclineUp()
	{
		isRiseDecline=false;
	}
	public void RiseDeclineExit()
	{
		isRiseDecline=false;
	}
	#endregion

	#endregion

}
