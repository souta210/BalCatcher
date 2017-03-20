using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Touchversion : MonoBehaviour {
	private HingeJoint myHingeJoint;
	private float defaultAngle= 20;
	private float flickAngle = -20;

	// Use this for initialization
	void Start () {
		myHingeJoint = GetComponent<HingeJoint> ();
		SetAngle(defaultAngle);
		
	}
	
	// Update is called once per frame
	void Update () {
		for (var touch : Touch in Input.touches);
		if (TouchPhase.Stationary && tag == "LeftFripperTag") {
			SetAngle (this.flickAngle);
		}
		//右矢印キーを押した時右フリッパーを動かす
		if (TouchPhase.Stationary && tag == "RightFripperTag") {
			SetAngle (this.flickAngle);
		}

		//矢印キー離された時フリッパーを元に戻す
		if TouchPhase.Ended || TouchPhase.Ended {
			SetAngle (this.defaultAngle);
		}
	}
	public void SetAngle (float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
}
}

