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

	public GameObject button;
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
		triggers.Yelling();
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
		triggers.HandsForwardGesture();
		triggers.PlayClipCall("FantasticCut");
		yield return new WaitForSeconds(2f);
		triggers.PlayClipCall("BirdQuestion");
		triggers.Yelling();
		yield return new WaitForSeconds(9f);
		speechInput.StartKeywordRecognizer();
		lookingForSecond = true;
	}

	public void StartQuestion3()
	{
		StartCoroutine(ThirdQuestion());
	}

	IEnumerator ThirdQuestion()
	{
		triggers.PlayClipCall("OneMoreThing");
		triggers.VictoryIdle();
		yield return  new WaitForSeconds(3.1f);
		triggers.PlayClipCall("LungsCut");
		triggers.Yelling();
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
		triggers.VictoryIdle();
		triggers.PlayClipCall("AfterLastQ");
		yield return new WaitForSeconds(2f);
		triggers.Yelling();
		yield return new WaitForSeconds(7);
		triggers.MacarenaDance();
		button.SetActive(true);
		Debug.Log("You got everything right!");
	}
}
