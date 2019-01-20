using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Responses : MonoBehaviour
{

	public SpeechInputSource speechInput;

	public AvatarSpeech avatarSpeech;

	public bool gotSA;
	public bool gotAmRiv;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Q1SouthAmerica()
	{
		if (avatarSpeech.lookingForFirst)
		{
			Debug.Log("SA");
			gotSA = true;
			if (gotAmRiv)
			{
				speechInput.StopKeywordRecognizer();
				avatarSpeech.StartQuestion2();
				avatarSpeech.lookingForFirst = false;
			}	
		}
	}

	public void Q1AmazonRiver()
	{
		if (avatarSpeech.lookingForFirst)
		{
			Debug.Log("AR");
			gotAmRiv = true;
			if (gotSA)
			{
				speechInput.StopKeywordRecognizer();
				avatarSpeech.StartQuestion2();
				avatarSpeech.lookingForFirst = false;
			}
		}
	}
	
	
}
