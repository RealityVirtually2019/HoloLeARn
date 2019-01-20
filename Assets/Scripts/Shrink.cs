using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
	
	public float speed;

	public bool shrink;
	
	public bool grow;
	// Use this for initialization
	
	// Update is called once per frame
	void Update ()
	{
		if(shrink)
			transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0, 0, 0), speed * Time.deltaTime);
			
			if(grow)
				transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.1419437f, 0.1419437f, 0.1419437f), speed * Time.deltaTime);
	}

	private void OnDisable()
	{
		shrink = false;
	}
}
