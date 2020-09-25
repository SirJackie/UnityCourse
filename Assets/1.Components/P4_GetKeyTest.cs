using UnityEngine;
using System.Collections;

public class P4_GetKeyTest : MonoBehaviour {

	public float Speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// Rotate
		float MouseX = Input.GetAxis ("Mouse X");
		float MouseY = Input.GetAxis ("Mouse Y");

		transform.Rotate (-MouseY, 0, 0);
		transform.Rotate (0, MouseX, 0, Space.World);


		// Position
		var DeltaPosition =  new Vector3(0, 0, 0);

		if (Input.GetKey (KeyCode.W)) {
			DeltaPosition -= Vector3.forward;
		}

		if (Input.GetKey (KeyCode.S)) {
			DeltaPosition -= Vector3.back;
		}

		if (Input.GetKey (KeyCode.A)) {
			DeltaPosition -= Vector3.left;
		}

		if (Input.GetKey (KeyCode.D)) {
			DeltaPosition -= Vector3.right;
		}

		DeltaPosition.Normalize ();
		transform.position += DeltaPosition * Speed;

	}
}