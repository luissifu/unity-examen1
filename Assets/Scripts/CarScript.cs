using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {

	public float turn_speed;
	public float move_speed;
	public float max_speed;
	public float acc_rate;

	private float new_angle;



	void Start () {
		turn_speed = 90;
		move_speed = 0;
		new_angle = 0;

		max_speed = 70;
		acc_rate = 0.25f;
	}

	void FixedUpdate () {
		calculate_speed ();
		calculate_rotation ();

		float movement = move_speed * Time.deltaTime;
		transform.rotation = Quaternion.Euler (0, new_angle, 0);
		transform.Translate (Vector3.forward * movement);
	}

	private void calculate_rotation() {
		if (move_speed != 0)
		{
			float turn_angle = Input.GetAxis ("Horizontal") * turn_speed * Time.deltaTime;
			new_angle += turn_angle;
		}
	}

	private void calculate_speed() {
		float accel = Input.GetAxis ("Vertical");

		if (accel > 0)
		{
			move_speed += acc_rate;
		}
		else if (accel < 0)
		{
			move_speed -= acc_rate;
		}
		else if (move_speed != 0)
		{
			if (move_speed > 0)
			{
				move_speed -= acc_rate * 2;
			}
			else
			{
				move_speed += acc_rate * 2;
			}
		}

		if (move_speed > max_speed)
		{
			move_speed = max_speed;
		}
		else if (move_speed < -max_speed / 2.0f)
		{
			move_speed = -max_speed / 2.0f;
		}
	}
}
