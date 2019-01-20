using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IvoCon1 : MonoBehaviour
{

	public CharacterTriggers triggers; 
	// Use this for initialization

	private void Awake()
	{
		
	}

	void Start () 
	{
		triggers.Backflip();
		StartCoroutine("Wait1");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator Wait1()
	{
		yield return new WaitForSeconds(3f);
		triggers.PlayClipCall("3Stage1_1");
		triggers.Yelling();
		yield return new WaitForSeconds(7);
		triggers.Charge();
	}
}
