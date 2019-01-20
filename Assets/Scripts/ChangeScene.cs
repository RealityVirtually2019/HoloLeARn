using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	public CharacterTriggers triggers;

	public GameObject card1;

	public GameObject buttons;

	public GameObject menu;

	public GameObject aj;

	public GameObject otheraj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene(1);
        }
	}

	public void changeScene()
	{
		SceneManager.LoadScene(1);
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
		aj.SetActive(false);
		card1.SetActive(true);
		buttons.SetActive(true);
		otheraj.SetActive(true);
		menu.SetActive(false);
	}
	
}
