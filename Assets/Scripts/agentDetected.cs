using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agentDetected : MonoBehaviour {

	private GameController controller;
	private List<GameObject> indicators;
	private int agentsInGoalCount;
	private Transform goalTransform;
	private int numberOfActiveIndicators;
	// Use this for initialization
	void Start () {
		controller = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<GameController> ();
		agentsInGoalCount = 0;
		numberOfActiveIndicators = 0;
		GetActiveIndicators ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Agent") {
			transform.GetChild (agentsInGoalCount).GetComponent<SpriteRenderer> ().color = Color.green;
			agentsInGoalCount++;
			if (numberOfActiveIndicators == agentsInGoalCount) {
				controller.GoalComplete ();
				print ("goal complete");
			}
		}
	}

	void GetActiveIndicators(){
		int numberOfIndicators = transform.childCount;
		for (int i = 0; i < numberOfIndicators-1; i++) {
			if (transform.GetChild (i).gameObject.activeSelf) {
				numberOfActiveIndicators++;
			}
		}
	}
}
