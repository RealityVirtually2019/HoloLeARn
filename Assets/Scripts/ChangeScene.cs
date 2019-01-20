using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	public CharacterTriggers triggers;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene(2);
        }
	}

	public void changeScene()
	{
		SceneManager.LoadScene(2);
	}

	public void StartGame()
	{
		StartCoroutine(startGame());
	}

	IEnumerator startGame()
	{
		triggers.PlayClipCall("LetsGo");
		triggers.VictoryIdle();
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene(1);
	}
	
}
