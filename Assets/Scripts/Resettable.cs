using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Resettable : MonoBehaviour {

	Vector2 startPosition;
	Quaternion startRotation;
	bool active;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		startRotation = transform.rotation;
		active = gameObject.activeSelf;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Reset()
	{
		gameObject.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
		gameObject.GetComponent<Rigidbody2D> ().angularVelocity = 0.0f;
		transform.position = startPosition;
		transform.rotation = startRotation;
		gameObject.SetActive (active);
	}
}
