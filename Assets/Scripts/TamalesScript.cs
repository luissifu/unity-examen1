using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TamalesScript : MonoBehaviour {

	public Text objective;
	public GameObject game_controller;

	void Start() {
		game_controller = GameObject.Find("Timer");
	}

	void LateUpdate () {
		transform.Rotate (new Vector3 (0,4,0));
	}

	void OnTriggerEnter(Collider other) {
		objective.text = "Regresa a tu casa!";
		Destroy (transform.parent.gameObject);
		game_controller.GetComponent<GameScript> ().tamales_recojidos = true;
	}
}
