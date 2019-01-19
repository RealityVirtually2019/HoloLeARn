using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Responses : MonoBehaviour
{

	public SpeechInputSource speechInput;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void A()
	{
		Debug.Log("Thats right!!");
		speechInput.StopKeywordRecognizer();
	}
}
