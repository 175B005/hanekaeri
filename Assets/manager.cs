using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour {

	public Text scoreText;
	int iTime = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		iTime++;
		scoreText.text = "" + iTime;
	}
}
