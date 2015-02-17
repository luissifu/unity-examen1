using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TryAgainButton : MonoBehaviour {
	public Button try_again_btn;
	
	void Start () {
		try_again_btn.onClick.AddListener (on_click);	
	}
	
	void on_click() {
		Application.LoadLevel ("Main");
	}
}
