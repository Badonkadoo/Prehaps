using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour {

	public GameObject switchableObject;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Button") {
			switchableObject.SetActive (false);
		}
	}
	public void Reset()
	{
		switchableObject.SetActive (true);
	}
}
