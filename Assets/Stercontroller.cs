using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stercontroller : MonoBehaviour {

	private float rotSpeed = 1.0f;
	// Use this for initialization
	void Start () {
		transform.Rotate (0, Random.Range (0, 360), 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,rotSpeed,0);
	}
}
