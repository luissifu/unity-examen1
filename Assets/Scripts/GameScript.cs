using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScript : MonoBehaviour {

	public Text timer;
	public float time_left;
	public bool tamales_recojidos;

	void Start () {
		time_left = 120;
		tamales_recojidos = false;
	}

	void Update () {
		timer.text = format_time (Mathf.FloorToInt(time_left));

		time_left -= Time.deltaTime;

		if (time_left <= 0)
		{
			Application.LoadLevel("GameOverBad");
		}
	}


	public string format_time(int time) {
		int minutes = time / 60;
		int seconds = time % 60;

		if (seconds >= 10)
			return minutes + ":" + seconds;
		else
			return minutes + ":0" + seconds;
	}
}
