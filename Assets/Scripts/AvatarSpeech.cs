using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class AvatarSpeech : MonoBehaviour
{

	public SpeechInputSource speechInput;

	public bool lookingForFirst;
	// Use this for initialization
	void Start ()
	{
		StartCoroutine(OpeningSpeech());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator OpeningSpeech()
	{
		yield return new WaitForSeconds(1.5f);
		Debug.Log("Time to learn!!!");
		yield return new WaitForSeconds(1f);
		Debug.Log("What was the first letter of the alphabet again?");
		speechInput.StartKeywordRecognizer();
		lookingForFirst = true;
	}
}
