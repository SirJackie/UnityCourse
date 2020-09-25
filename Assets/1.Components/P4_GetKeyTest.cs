using UnityEngine;
using System.Collections;

public class P4_GetKeyTest : MonoBehaviour {

	public float Speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}

	public Vector3 RotateRound(Vector3 position, Vector3 center, Vector3 axis, float angle)
	{
		return Quaternion.AngleAxis(angle, axis) * (position - center) + center;
	}
	
	// Update is called once per frame
	void Update () {

		// Rotate
		float MouseX = Input.GetAxis ("Mouse X");
		float MouseY = Input.GetAxis ("Mouse Y");

		transform.Rotate (-MouseY, 0, 0);
		transform.Rotate (0, MouseX, 0, Space.World);


		// Position
		var DeltaPosition =  new Vector2(0, 0);

		if (Input.GetKey (KeyCode.W)) {
			DeltaPosition.y += 1;
		}

		if (Input.GetKey (KeyCode.S)) {
			DeltaPosition.y -= 1;
		}

		if (Input.GetKey (KeyCode.A)) {
			DeltaPosition.x -= 1;
		}

		if (Input.GetKey (KeyCode.D)) {
			DeltaPosition.x += 1;
		}

		DeltaPosition.Normalize ();
		Vector3 RotatedPosition = RotateRound (new Vector3 (DeltaPosition.x, 0, DeltaPosition.y) * Speed, new Vector3 (0, 0, 0), Vector3.up, transform.eulerAngles.y);
		Debug.Log (transform.rotation.y);
		transform.position += RotatedPosition;

	}
}