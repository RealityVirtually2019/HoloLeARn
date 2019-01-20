using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void Load()
	{
		SceneManager.LoadScene(1);
	}
}
