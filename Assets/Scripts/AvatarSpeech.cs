using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class AvatarSpeech : MonoBehaviour
{

	public SpeechInputSource speechInput;

	public bool lookingForFirst;

	public bool lookingForSecond = false;
	
	public bool lookingForThird = false;
	
	public CharacterTriggers triggers;

	public Shrink shrink;
	
	// Use this for initialization
	void Start ()
	{
		triggers.Backflip();
	
		StartCoroutine(OpeningSpeech());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator StopGrow()
	{
		yield return new WaitForSeconds(5.5f);
		shrink.grow = true;
		yield return new WaitForSeconds(2f);
		shrink.grow =false;
	}

	IEnumerator OpeningSpeech()
	{
		yield return new WaitForSeconds(1.5f);
		triggers.PlayClipCall("RiverQuestion");
		yield return new WaitForSeconds(8f);
		speechInput.StartKeywordRecognizer();
		lookingForFirst = true;
	}

	public void StartQuestion2()
	{
		StartCoroutine(SecondQuestion());
	}

	IEnumerator SecondQuestion()
	{
		Debug.Log("One down, lets keep going!");
		yield return new WaitForSeconds(2f);
		Debug.Log("What's the layer of the Rainforest that most birds live in?");
		speechInput.StartKeywordRecognizer();
		lookingForSecond = true;
	}

	public void StartQuestion3()
	{
		StartCoroutine(ThirdQuestion());
	}

	IEnumerator ThirdQuestion()
	{
		Debug.Log("Thats right!");
		yield return  new WaitForSeconds(1f);
		Debug.Log("Alright! Lets finish it off!");
		Debug.Log("I heard that Amazon Rainforest has a really cool nickname, why??");
		speechInput.StartKeywordRecognizer();
		lookingForThird= true;
	}

	public void TriggerEnding()
	{
		StartCoroutine(Ending());
	}

	IEnumerator Ending()
	{
		Debug.Log("You did it!!");
		yield return new WaitForSeconds(2f);
		Debug.Log("You got everything right!");
	}
}
