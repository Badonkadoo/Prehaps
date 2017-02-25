//#define LOG_TRACE_INFO
//#define LOG_EXTRA_INFO

using UnityEngine;
using System.Collections;

//------------------------------------------------------------------------------
// class definition
//------------------------------------------------------------------------------
public class GameController : MonoBehaviour
{
	private static GameController gameController;
	private GameObject[] agents;
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
		for(int i = 0; i < agents.Length; i++){
			agents[i].SetActive (false);
		}
	}

	public void ResetScene(){
		
	}

	//--------------------------------------------------------------------------
	// private methods
	//--------------------------------------------------------------------------
}
