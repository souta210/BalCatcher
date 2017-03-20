using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
	private float visiblePosZ = -6.5f;
	private GameObject GameOver;
	// Use this for initialization
	void Start () {
		GameOver = GameObject.Find ("GameOver");

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < visiblePosZ) {
			GameOver.GetComponent<Text> ().text = "Game Over";
		}
		
	}
}
