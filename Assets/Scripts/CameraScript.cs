using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	void Start () {
		offset = transform.position;
	}

	void LateUpdate () {
		Quaternion rotation = transform.rotation;
		rotation.y = player.transform.rotation.y;
		transform.rotation = rotation;
		transform.position = player.transform.position + offset;
	}
}
