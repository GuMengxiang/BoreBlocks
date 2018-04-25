using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using HedgehogTeam.EasyTouch;
/// <summary>
/// 控制摄像机视角转动
/// </summary>
public class GameCameraControll : MonoBehaviour {
	public Transform mCamera_LR;//左右
	public Transform mCamera_UD;//上下
	bool isBig=true;//放大或者缩小 true:放大 false：缩小
	// Use this for initialization
	void Start () {
		mCamera_LR.Rotate(new Vector3(30.0f,0,0),Space.World);
		mCamera_UD.position=new Vector3(0.0f,2.5f,-2.5f);
		OnEnable();
	}
	// Update is called once per frame
	void Update () {
		if (mCamera_LR.GetComponent<Camera>().fieldOfView > 120.0f) {
			isBig=false;//当FOV>120时，将缩小
		}

		if (mCamera_LR.GetComponent<Camera>().fieldOfView < 20.0f) {
			isBig=true;//当FOV<20时，将放大
		}
	}
		
	 
	#region  碰撞事件
	//进入碰撞事件
	void OnCollisionEnter(Collision m_collision)
	{
		if (m_collision.gameObject.tag=="wall" || m_collision.gameObject.tag=="GameCube") {

			mCamera_LR.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.zero);
			mCamera_LR.gameObject.GetComponent<Rigidbody>().freezeRotation=true;
		}
		mCamera_LR.localEulerAngles=new Vector3(30.0f,0,0);
		//		mCamera_UD.localPosition +=new Vector3(0,0.5f,0);

		Debug.Log("oncollisionEnter:" + m_collision.gameObject.name);
	}
	#endregion


	#region  EasyTouch事件

	void OnEnable()
	{
		EasyTouch.On_PinchIn += On_PinchIn;
		EasyTouch.On_PinchOut += On_PinchOut;
	}

	/// <summary>
	/// 捏放手势开启事件
	/// </summary>
	/// <param name="gesture">Gesture.</param>
	public void On_PinchIn(Gesture gesture)
	{
//		if (isBig) {
			mCamera_LR.GetComponent<Camera>().fieldOfView+=0.5f;
//		}
	}
	/// <summary>
	/// 捏合手势开启事件
	/// </summary>
	/// <param name="gesture">Gesture.</param>
	public void On_PinchOut(Gesture gesture)
	{
//		if (!isBig) {
			mCamera_LR.GetComponent<Camera>().fieldOfView-=0.5f;
//		}
	}
	#endregion
}