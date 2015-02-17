using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InstButton : MonoBehaviour {
	public Button inst_btn;
	public Text to_change;

	void Start () {
		inst_btn.onClick.AddListener (on_click);	
	}
	
	void on_click() {
		to_change.text = "Es el dia de la Calendabra y no haz ido por los tamales!\n" +
			"Ve a recojer los ultimos tamales que quedan en la montania de los tamales.\n" +
			"Se contralo con las teclas direccionales o WASD\n" +
			"Izquierda/Derecha para rotar\n" +
			"Arriba/Abajo para accelerar/frenar\n" +
			"Tienes un limite de 2 minutos antes de que se den cuenta de que no hay tamales\n" +
			"Suerte!";
	}
}
