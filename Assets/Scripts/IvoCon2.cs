using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IvoCon2 : MonoBehaviour 
{
	public CharacterTriggers triggers;

	public Shrink shrink;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(StopGrow());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator StopGrow()
	{
		yield return new WaitForSeconds(.7f);
		shrink.grow = true;
		yield return new WaitForSeconds(2f);
		shrink.grow =false;
	}
	
}
