using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuButton : MonoBehaviour {
	public Button main_menu_btn;

	void Start () {
		main_menu_btn.onClick.AddListener (on_click);	
	}

	void on_click() {
		Application.LoadLevel ("MainMenu");
	}
}
