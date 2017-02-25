using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resettable : MonoBehaviour {

	Vector2 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Reset(){
		transform.position = startPosition;
	}
}
