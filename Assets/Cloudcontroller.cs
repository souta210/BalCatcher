using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudcontroller : MonoBehaviour {

	private float minimum = 1.0f;
	private float magSpeed = 10.0f;
	private float magnification = 0.07f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3(minimum + Mathf.Sin (Time.time * magSpeed) * magnification, transform.localScale.y, minimum + Mathf.Sin (Time.time * magSpeed) * magnification);	
	}
}
