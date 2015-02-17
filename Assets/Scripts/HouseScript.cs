using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HouseScript : MonoBehaviour {

	public Text objective;
	public GameObject game_controller;
	
	void Start() {
		game_controller = GameObject.Find("Timer");
	}

	void OnTriggerEnter(Collider other) {
		if (game_controller.GetComponent<GameScript> ().tamales_recojidos)
		{
			Application.LoadLevel("GameOver");
		}
		else
		{
			objective.text = "Aun no tienes los tamales, ve por ellos!";
		}
	}
}
