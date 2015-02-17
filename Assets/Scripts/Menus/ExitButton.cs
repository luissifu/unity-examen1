using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExitButton : MonoBehaviour {
	public Button exit_btn;
	
	void Start () {
		exit_btn.onClick.AddListener (on_click);	
	}
	
	void on_click() {
		Application.Quit();
	}
}
