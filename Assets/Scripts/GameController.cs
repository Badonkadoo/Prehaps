//#define LOG_TRACE_INFO
//#define LOG_EXTRA_INFO

using UnityEngine;
using System.Collections;

//------------------------------------------------------------------------------
// class definition
//------------------------------------------------------------------------------
public class GameController : MonoBehaviour
{
	public GameObject levelCompleteUI;
	public GameObject objects;

	private static GameController gameController;
	private GameObject[] agents;
	private int childCount;
	public GameObject[] goals;
	//--------------------------------------------------------------------------
	// public static methods
	//--------------------------------------------------------------------------
	//--------------------------------------------------------------------------
	// protected mono methods
	//--------------------------------------------------------------------------
	protected void Awake()
	{
		gameController = this;
	}
	
	protected void OnDestroy()
	{
		if(gameController != null)
		{
			gameController = null;
		}
	}
	
	protected void OnDisable()
	{
	}
	
	protected void OnEnable()
	{
	}
	
	protected void Start()
	{
	}
	
	protected void Update()
	{
		if(Input.GetButtonDown("Fire2")){
			MainController.SwitchScene("Menu Scene");
		}
		if(Input.GetButtonDown("Cancel")){
			Application.Quit ();
		}
	}

	public void ResetLevel(){
		agents = GameObject.FindGameObjectsWithTag ("Agent");
		for(int k = 0; k < agents.Length; k++){
			agents[k].SetActive (false);
		}
		objects.BroadcastMessage ("Reset");
	}

	public void GoalComplete (){
		levelCompleteUI.SetActive (true);
	}

	public void ResetScene(){
		
	}

	//--------------------------------------------------------------------------
	// private methods
	//--------------------------------------------------------------------------
}
