using UnityEngine;
using System.Collections;

public class P4_GetKeyTest : MonoBehaviour {

	public float Speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float DeltaX = 0f;
		float DeltaY = 0f;
		float DeltaZ = 0f;

		if (Input.GetKey (KeyCode.W)) {
			DeltaZ -= Speed;
		}

		if (Input.GetKey (KeyCode.S)) {
			DeltaZ += Speed;
		}

		if (Input.GetKey (KeyCode.A)) {
			DeltaX += Speed;
		}

		if (Input.GetKey (KeyCode.D)) {
			DeltaX -= Speed;
		}

		Transform t = gameObject.GetComponent<Transform> ();
		var DeltaPosition =  new Vector3 (
			DeltaX,
			DeltaY,
			DeltaZ
		);
		DeltaPosition.Normalize ();
		DeltaPosition *= Speed;
		t.position += DeltaPosition;

	}
}
