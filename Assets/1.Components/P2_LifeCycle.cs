using UnityEngine;
using System.Collections;

public class P2_LifeCycle : MonoBehaviour {

	void Awake () {
		Debug.Log ("Awake");
	}

	void OnEnable () {
		Debug.Log ("OnEnable");
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log ("Update");
	}

	void OnDisable () {
		Debug.Log ("OnDisable");
	}

	void OnDestroy () {
		Debug.Log ("OnDestroy");
	}
}
