//#define LOG_TRACE_INFO
//#define LOG_EXTRA_INFO

using UnityEngine;
using System.Collections;

//------------------------------------------------------------------------------
// class definition
//------------------------------------------------------------------------------
public class Rotate : MonoBehaviour
{

	public float speed;
	// singleton instance
	private static Rotate rotatingObject;

	//--------------------------------------------------------------------------
	// public static methods
	//--------------------------------------------------------------------------
	//--------------------------------------------------------------------------
	// protected mono methods
	//--------------------------------------------------------------------------
	protected void Awake()
	{
		rotatingObject = this;
	}

	protected void OnDestroy()
	{
		if(rotatingObject != null)
		{
			rotatingObject = null;
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
		// rotate the spawn point
		transform.Rotate(Vector3.forward, Time.deltaTime * speed);
	}

	//--------------------------------------------------------------------------
	// private methods
	//--------------------------------------------------------------------------
}
