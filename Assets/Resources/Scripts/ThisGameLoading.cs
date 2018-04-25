using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>  
/// 脚本位置：实例化的Loading Cavas  
/// 脚本功能：场景异步加载的进度条显示  
/// </summary> 
public class ThisGameLoading : MonoBehaviour {

	// 滑动条  
//	private Slider processBar;  

	//过场动画
	private Animator anim_Jitter;
	private Animator anim_Gradient;

	// Application.LoadLevelAsync()这个方法的返回值类型是AsyncOperation  
	private AsyncOperation async;  
	// 当前进度，控制滑动条的百分比  
	private uint nowprocess = 0;

	private void Awake() 
	{ 
//		processBar=transform.Find("Slider").GetComponent<Slider>();
		anim_Jitter=transform.Find("BG/LoadingImage").GetComponent<Animator>();

	}

	// Use this for initialization
	void Start () {
		// 开启一个协程  
		StartCoroutine (loadScene ());  
	}
	// 定义一个协程  
	IEnumerator loadScene ()  
	{  
		// 异步读取场景  
		// 指定需要加载的场景名  
		async = SceneManager.LoadSceneAsync ( SceneManager.GetActiveScene().name /*"需要加载的场景名字或者index"*/);  

		// 设置加载完成后不能自动跳转场景  
		async.allowSceneActivation = false;  

		// 下载完成后返回async  
		yield return async;  

	}  
	// Update is called once per frame
	void Update () {
		// 判断是否加载完需要跳转的场景数据  
		if (async == null) {  
			// 如果没加载完，就跳出update方法，不继续执行return下面的代码  
			return;  
		}  

		// 进度条需要到达的进度值  
		uint toProcess;  
		Debug.Log (async.progress * 100);  

		// async.progress 你正在读取的场景的进度值  0---0.9  
		// 如果当前的进度小于0.9，说明它还没有加载完成，就说明进度条还需要移动  
		// 如果，场景的数据加载完毕，async.progress 的值就会等于0.9  
		if (async.progress < 0.9f) {  
			//  进度值  
			toProcess = (uint)(async.progress * 100);  
		}  
		// 如果能执行到这个else，说明已经加载完毕  
		else {  
			// 手动设置进度值为100  
			toProcess = 100;  
		}  

		// 如果滑动条的当前进度，小于，当前加载场景的方法返回的进度  
		if (nowprocess < toProcess) {  
			// 当前滑动条的进度加一  
			nowprocess++;  
		}  

		// 设置滑动条的value  
//		processBar.value = nowprocess / 100f;  

		// 如果滑动条的值等于100，说明加载完毕  
		if (nowprocess == 100) {  

			anim_Jitter.speed=0;//停止跳动的方块动画播放
			transform.Find("BG/LoadingImage").gameObject.SetActive(false);
			transform.Find("BG").GetComponent<Animator>().enabled=true;
			Invoke("Data_completion",0.2f);
		}  
	}

	public void Data_completion()
	{
		// 设置为true的时候，如果场景数据加载完毕，就可以自动跳转场景  
		async.allowSceneActivation = true;  
	}
}
