using UnityEngine;
using System.Collections;

public class P1_CRUD : MonoBehaviour {

	// Options
	public bool GetComponent;
	public bool AddComponent;
	public bool UpdateTransformComponent;
	public bool DeleteRendererComponent;

	// Use this for initialization
	void Start () {

		// Get Component
		if (GetComponent == true) {
			Component c = gameObject.GetComponent<P1_CRUD> ();
			Debug.Log (c);
		}

		// Add Component
		if (AddComponent == true) {
			gameObject.AddComponent<EmptyComponent> ();
		}

		// Update Transform Component
		if (UpdateTransformComponent == true) {
			Transform t = gameObject.GetComponent<Transform> ();
			t.position = new Vector3 (1.5f, 1.5f, 1.5f);
		}

		// Delete Renderer Component
		if (DeleteRendererComponent == true) {
			Renderer r = gameObject.GetComponent<Renderer> ();
			Destroy (r);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		// Update Transform Component
		if (UpdateTransformComponent == true) {
			Transform t = gameObject.GetComponent<Transform> ();
			t.position = new Vector3 (1.5f, 1.5f, 1.5f);
		} else {
			Transform t = gameObject.GetComponent<Transform> ();
			t.position = new Vector3 (1.5f, 1.0f, 1.5f);
		}

	}
}
