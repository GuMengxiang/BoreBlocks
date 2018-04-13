using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
/// <summary>
/// 控制摄像机视角转动
/// </summary>
public class GameCameraControll : MonoBehaviour {
	public Transform mCamera_LR;//左右
	public Transform mCamera_UD;//上下

	// Use this for initialization
	void Start () {
		mCamera_LR.Rotate(new Vector3(30.0f,0,0),Space.World);
		mCamera_UD.position=new Vector3(0.0f,2.5f,-2.5f);
	}
	// Update is called once per frame
	void Update () {

//		PhotonCamContronObj();
//		LookAtTarget()  ;
		//mCamera_LR.LookAt(GameObject.Find("CubeControl").transform.position);
	}




	/// <summary>
	/// Ioses the cam contron object.  手机端，滑动屏幕旋转物体
	/// </summary>
	public void PhotonCamContronObj()
	{
/*
 * if (Input.touchCount <= 0)
		{
			return;
		}
		if (Input.touchCount == 1) //单点触碰
		{
			
			if (Input.GetMouseButtonDown(0)||Input.touches[0].phase==TouchPhase.Moved )//手指在屏幕上移动 
			{
				Vector2 m_screenPos=Input.touches[0].deltaPosition;

				//左右
				if (Input.touches[0].deltaPosition.x>=5.0f||Input.touches[0].deltaPosition.x<=-5.0f)
				{
					mCamera_LR.Rotate(new Vector3(0,m_screenPos.x*Time.deltaTime*2f,0),Space.Self);
					//mCamera_LR.RotateAround(Vector3.zero,Vector3.up,m_screenPos.x*Time.deltaTime*2f);
				}
				

					//上下
				if (Input.touches[0].deltaPosition.y>=5.0f||Input.touches[0].deltaPosition.y<=-5.0f)
				{
					mCamera_UD.Rotate(new Vector3(-m_screenPos.y*Time.deltaTime*2f,0,0),Space.World);//(Vector3.right * m_screenPos.y,Space.Self);
				}

				if (Input.touches[0].deltaPosition.x!=0.0f && Input.touches[0].deltaPosition.y!=0.0f)
				{
					return;
				}
			
			}
		} 
*/


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
}