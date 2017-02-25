﻿//#define LOG_TRACE_INFO
//#define LOG_EXTRA_INFO

using UnityEngine;
using System.Collections;

//------------------------------------------------------------------------------
// class definition
//------------------------------------------------------------------------------
public class MenuController : MonoBehaviour
{
	private static MenuController menuController;

	//--------------------------------------------------------------------------
	// public static methods
	//--------------------------------------------------------------------------
	//--------------------------------------------------------------------------
	// protected mono methods
	//--------------------------------------------------------------------------
	protected void Awake()
	{
		menuController = this;
	}
	
	protected void OnDestroy()
	{
		if(menuController != null)
		{
			menuController = null;
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
		if(Input.GetButtonDown("Fire1")){
			MainController.SwitchScene("Game Scene");
		}
		if(Input.GetButtonDown("Cancel")){
			Application.Quit ();
		}
	}

	//--------------------------------------------------------------------------
	// private methods
	//--------------------------------------------------------------------------
}
