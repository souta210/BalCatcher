using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour {
	private HingeJoint myHingeJoint;

	private float defaultAngle = 20;
	private float flickAngle = -20;
	// Use this for initialization
	void Start () {
		myHingeJoint = GetComponent<HingeJoint> ();
		SetAngle (defaultAngle);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (flickAngle);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (flickAngle);
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
			SetAngle(defaultAngle);
	}
}
			public void SetAngle (float angle){
				JointSpring jointSpr = myHingeJoint.spring;
				jointSpr.targetPosition = angle;
				myHingeJoint.spring = jointSpr;
			}
			}
