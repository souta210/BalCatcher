using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	private GameObject ScoreText;
	int score = 0;

	// Use this for initialization
	void Start () {
		ScoreText = GameObject.Find ("Score");
		ScoreText.GetComponent<Text> ().text = "Score:" + score;
	}

	// Update is called once per frame
	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "SmallStarTag") {
			score += 30;
		}
		if (collision.gameObject.tag == "LargeStarTag") {
			score += 50;
		}
		if (collision.gameObject.tag == "SmallCloudTag") {
			score += 90;
		}
		if (collision.gameObject.tag == "LargeCloudTag") {
			score += 5;
		}
	
//合計点を表示させる何かが必要
		ScoreText.GetComponent<Text>().text = "Score:" + score;

		Debug.Log ("Collision");
	}

}
