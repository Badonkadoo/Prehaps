//#define LOG_TRACE_INFO
//#define LOG_EXTRA_INFO

using UnityEngine;
using System.Collections;

//------------------------------------------------------------------------------
// class definition
//------------------------------------------------------------------------------
public class MenuController : MonoBehaviour
{
	private static MenuController menuController;

	public GameObject FirstMenu;

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
			MainController.SwitchScene("Level 4");
		}
		if(Input.GetButtonDown("Cancel")){
			Application.Quit ();
		}
	}

	public void startPressed(){
		FirstMenu.transform.Translate (Vector3.up*2000);
	}

	//--------------------------------------------------------------------------
	// private methods
	//--------------------------------------------------------------------------
}
