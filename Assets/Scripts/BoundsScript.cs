using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoundsScript : MonoBehaviour {

	public Text objective;

	void Start () {
		//last_objective = "";
	}

	void OnTriggerEnter(Collider other) {
		objective.text = "Por aqui no es!";
	}
}
