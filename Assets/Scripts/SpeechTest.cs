using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechTest : MonoBehaviour
{

	public GameObject cube;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void testtest()
	{
		cube.GetComponent<MeshRenderer>().material.color = Color.red;
		
	}
}
