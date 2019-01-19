using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Moved : MonoBehaviour
{

	public bool moved;

	public bool up;

	public bool down;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.activeSelf)
		{
			down = true;
			up = false;
		}	
		
	}

	private void OnDisable()
	{
		up = true;
		down = false;
	}
}
