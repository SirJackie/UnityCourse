using UnityEngine;
using System.Collections;

public class P4_GetKeyTest : MonoBehaviour {

	public float Speed = 0.1f;
	private bool IsCursorLocked = false;

	// Use this for initialization
	void Start () {
	
	}

	public Vector3 RotateRound(Vector3 position, Vector3 center, Vector3 axis, float angle)
	{
		return Quaternion.AngleAxis(angle, axis) * (position - center) + center;
	}

	void ResponseCursor(){
		if (Input.GetKey(KeyCode.Escape)) {
			IsCursorLocked = false;
		} else if(Input.GetMouseButton(0) == true){
			IsCursorLocked = true;
		}

		if (IsCursorLocked == true) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		} else if (IsCursorLocked == false) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
	
	// Update is called once per frame
	void Update () {

		// Response the Cursor
		ResponseCursor ();

		// Rotate
		float MouseX = Input.GetAxis ("Mouse X");
		float MouseY = Input.GetAxis ("Mouse Y");

		transform.Rotate (-MouseY, 0, 0);
		transform.Rotate (0, MouseX, 0, Space.World);


		// Move
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

		Vector3 RotatedPosition = RotateRound (
			                          new Vector3 (DeltaPosition.x, 0, DeltaPosition.y) * Speed,
			                          new Vector3 (0, 0, 0),
			                          Vector3.up,
			                          transform.eulerAngles.y);
		transform.position += RotatedPosition;

	}
}