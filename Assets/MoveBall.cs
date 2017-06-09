using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
	public float vx = -10f;
	public float vy = -10f;
	private Rigidbody rig;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody> ();
		rig.velocity = new Vector3 (vx, vy, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
