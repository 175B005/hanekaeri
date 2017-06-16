using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killcheck : MonoBehaviour {

	/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/

	//使わない場合はstart updateは消してもよい↑
	//マウスが重なった時の処理
	void OnMouseEnter(){
		//ぶつかったら消す
		//destroy(=実体)→そのものを消す

		Debug.Log("hit");
		Destroy (gameObject);
		//gameObject.SetActive(false);動作無効。非表示
		//生成。削除は処理が重い、、、
}
}
