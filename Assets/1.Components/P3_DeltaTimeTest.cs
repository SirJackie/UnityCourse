using UnityEngine;
using System.Collections;

public class P3_DeltaTimeTest : MonoBehaviour {

	private float NowXPosition = 0f;
	private float Step = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		NowXPosition += Step * Time.deltaTime;
		if (NowXPosition >= 1.5f) {
			Step = -1f;
		} else if (NowXPosition <= -1.5f) {
			Step = 1f;
		}

		float NowYPosition = -1 * (NowXPosition - 0f) * (NowXPosition - 0f) + 3f;

		Transform t = gameObject.GetComponent<Transform> ();
		t.position = new Vector3(NowXPosition, NowYPosition, 1.5f);
	}
}
