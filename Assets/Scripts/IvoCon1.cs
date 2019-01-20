using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IvoCon1 : MonoBehaviour
{

	public CharacterTriggers triggers;

	public Shrink shrink;
	// Use this for initialization

	private void Awake()
	{
		
	}

	private void OnEnable()
	{
		triggers.Backflip();
		StartCoroutine(Grow());
		StartCoroutine("Wait1");
	}

	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator Grow()
	{
		yield return new WaitForSeconds(.7f);
		shrink.grow = true;
		yield return new WaitForSeconds(2f);
		shrink.grow =false;
	}
	
	IEnumerator Wait1()
	{
		yield return new WaitForSeconds(3f);
		triggers.PlayClipCall("3Stage1_1");
		triggers.Yelling();
		yield return new WaitForSeconds(7);
		triggers.Charge();
		triggers.PlayClipCall("ExplainFlashCards");
		yield return new WaitForSeconds(4.2f);
		triggers.PlayClipCall("BackInAMin");
		triggers.Frontflip();
		yield return new WaitForSeconds(1.3f);
		shrink.shrink = true;
	}
}
