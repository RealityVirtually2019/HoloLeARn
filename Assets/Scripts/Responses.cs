using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.UI;

public class Responses : MonoBehaviour
{

	public SpeechInputSource speechInput;

	public AvatarSpeech avatarSpeech;

	public bool gotSA;
	public bool gotAmRiv;

	public bool gotOx;
	public bool got20;

	public Image brainFill;
	
	
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

	public void Q2Canopy()
	{
		if (avatarSpeech.lookingForSecond)
		{
			speechInput.StopKeywordRecognizer();
			avatarSpeech.StartQuestion3();
			avatarSpeech.lookingForSecond = false;
		}
	}

	public void Q320()
	{
		if (avatarSpeech.lookingForThird)
		{
			Debug.Log("20");
			got20 = true;
			if(gotOx)
			{
				speechInput.StopKeywordRecognizer();
				avatarSpeech.TriggerEnding();
				avatarSpeech.lookingForThird = false;
			}
		}
	}

	public void Q3Oxygen()
	{
		if (avatarSpeech.lookingForThird)
		{
			Debug.Log("oxy");
			gotOx = true;
			if(got20)
			{
				speechInput.StopKeywordRecognizer();
				avatarSpeech.TriggerEnding();
				avatarSpeech.lookingForThird = false;
			}
		}
	}
	
}

//Mathf.Lerp(progressbarvalue, newValue, Time.deltaTime * speed);