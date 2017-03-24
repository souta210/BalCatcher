using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour {
	public Vector2 startPos; //？
	public Vector2 direction; //？
	public int sw = Screen.width; //int値で画面幅をswに代入して

	private HingeJoint myHingeJoint; //HingeJointをmyHingeJointで呼び出せるようにして
	private float defaultAngle = 20; //Fripperの通常位置の設定
	private float flickAngle = -20; //Fripperが動いた時の位置の設定



	void Start () {
		myHingeJoint = GetComponent<HingeJoint> ();//myHingeJointにオブジェクトのHingejointを代入
		SetAngle (defaultAngle);//通常位置の設定
	}
		
	void Update () {
		for ( int i = 0;i < Input.touches.Length;i++){
			Touch touch = Input.touches[i];
			Vector2 touchPos = touch.position;
		    float screenHalfWidth = sw / 2;

			if(touchPos.x < screenHalfWidth){
				switch (touch.phase) {
				//タッチした瞬間
				case TouchPhase.Began:
					{
						if (tag == "LeftFripperTag") {
							SetAngle (this.flickAngle);
						}
					}
					break;

					//タッチが終わった瞬間
				case TouchPhase.Ended:
				case TouchPhase.Canceled:
					{
						if (tag == "LeftFripperTag") {
							SetAngle (defaultAngle);
						}
					}
					break;
				}
			}
			//右半分だったら
			else {
				switch (touch.phase) {
				//タッチした瞬間
				case TouchPhase.Began:
					{
						if (tag == "RightFripperTag") {
							SetAngle (this.flickAngle);
						}
					}
					break;

					//タッチが終わった瞬間
				case TouchPhase.Ended:
				case TouchPhase.Canceled:
					{
						if (tag == "RightFripperTag") {
							SetAngle (defaultAngle);
						}
					}
					break;
				}
			}
		
		}	
	}
	public void SetAngle (float angle){
		JointSpring jointSpr = myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		myHingeJoint.spring = jointSpr;
	}//？
}
