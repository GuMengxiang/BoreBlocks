using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class NoviceTutorial : MonoBehaviour {
	public GameObject _Tipstrans;
	public Text _NovicText;
	public Transform _Arrowtrans;
	private bool _TransBack=false;
	Tweener tween;/* DoTween中所有对动画的设置都是通过对象Tweener来完成的 */


	public Animator ArrowAnim;
	// Use this for initialization
	void Start () {
//		if (!PlayerPrefs.HasKey("NovicOver")) {
//			TipsOpen();
//			ChangeNoviceText();
//		}
	//	PointingArrowTween();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
		{
			ArrowAnim.enabled=false;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			ArrowAnim.enabled=true;
		}
	}
	/// <summary>
	/// 新手教程中，指向箭头的动画
	/// </summary>
	public void PointingArrowTween()
	{
		_Arrowtrans.DOLocalMoveY(-10.0f,0.5f,false);
		tween=_Arrowtrans.DOLocalMoveY(-10.0f,0.5f,false);
		tween.OnComplete(ChangeNoviceText);

	}

	/// <summary>
	/// 新手教程的界面
	/// </summary>
	public void TipsOpen()
	{
		if (!_TransBack )
		{
			_TransBack=true;
			_Tipstrans.gameObject.SetActive(true);
			/*因为不需要动画，所以注释掉*/
//			_Tipstrans.DOLocalMoveX(-280f,3.0f,false);
//			tween=_Tipstrans.DOLocalMoveX(-280f,3.0f,false);
		}
		else
		{
			/*理由同上*/
//			_Tipstrans.DOLocalMoveX(-1500f,3.0f,false);
			_Tipstrans.gameObject.SetActive(false);
			_TransBack=false;
		}
	}

	public void ChangeNoviceText()
	{
		
//		//_NovicText.DOText("点击发光的物体。点击此窗口关闭",2f);/*20170109更改需求，不需要动画*/
//		_NovicText.text="点击发光的物体。点击此窗口关闭";
//		PlayerPrefs.SetString("NovicOver",_NovicText.ToString());
		_Arrowtrans.DOLocalMoveY(20.0f,0.5f,false);
		tween=_Arrowtrans.DOLocalMoveY(20.0f,0.5f,false);
		tween.OnComplete(PointingArrowTween);
	}
}
