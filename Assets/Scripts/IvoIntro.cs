using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IvoIntro : MonoBehaviour {

	public CharacterTriggers triggers;

	public Shrink shrink;
	
	// Use this for initialization
	void Start ()
	{
		StartCoroutine(Intro());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator Intro()
	{
		yield return new WaitForSeconds(1f);
		triggers.PlayClipCall("Greeting");
		triggers.Wave();
	}
}
