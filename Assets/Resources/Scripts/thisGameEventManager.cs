using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class thisGameEventManager : MonoBehaviour {
	public Transform mPlay;
	public Transform mCamera;
	// Use this for initialization
	void Start () {
		//this.gameObject.transform.DOLookAt(new Vector3(90.0f,0.0f,0.0f)/*旋转角度*/,3.0f/*时间*/);
	}
	
	// Update is called once per frame
	void Update () {
//		lookcame();
	}

	void lookcame()
	{
		mCamera.transform.LookAt(mPlay.transform);
	}

}
