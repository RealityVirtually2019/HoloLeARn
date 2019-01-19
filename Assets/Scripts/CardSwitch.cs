using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSwitch : MonoBehaviour
{

	public Button nextButton;
	public Button previousButton;
	public List<GameObject> noteCards;
	public GameObject currCard;
	public Animator currCardAnimator;
	public int index;
	private static readonly int Nexted = Animator.StringToHash("Nexted");

	private void Awake()
	{
		nextButton.onClick.AddListener(OnNext);
		previousButton.onClick.AddListener(OnPrevious);
		currCard = noteCards[index];
		currCardAnimator = noteCards[index].GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnNext()
	{
		StartCoroutine(Next());
	}

	void OnPrevious()
	{
		currCard.SetActive(false);
		index--;
		currCard = noteCards[index];
		currCard.SetActive(true);
		currCardAnimator = currCard.GetComponent<Animator>();
		currCardAnimator.SetBool(Nexted,true);
	}

	IEnumerator Next()
	{
		currCardAnimator.SetBool("Nexted",true);
		yield return new WaitForSeconds(.45f);
		currCard.SetActive(false);
		index++;
		currCard = noteCards[index];
		currCard.SetActive(true);
		currCardAnimator = currCard.GetComponent<Animator>();
	}


}


//depending on which button is pressed, the user will either
//switch to the next note card or the previous note card