using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFlip : MonoBehaviour
{		
	public Button flipButton;

	public GameObject currCard;

	private int currCardIndex;

	public Animator cardAnimator;

	public bool flipped;

	public CardSwitch cardSwitch;
	private static readonly int Flipped = Animator.StringToHash("Flipped");
	


	private void Awake()
	{
		flipButton.onClick.AddListener(OnClick);
		cardSwitch = FindObjectOfType<CardSwitch>();
	}

	// Use this for initialization
	void Start ()
	{
		currCard = cardSwitch.currCard;
		cardAnimator = currCard.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{
		if(currCard!=cardSwitch.currCard)
			currCard = cardSwitch.currCard;

		if (cardAnimator != currCard.GetComponent<Animator>())
		{
			cardAnimator = currCard.GetComponent<Animator>();
		}
	}

	public void OnClick()
	{
		if (!flipped)
		{
			cardAnimator.SetBool(Flipped,true);
			flipped = true;
		}
		else if (flipped)
		{
			cardAnimator.SetBool(Flipped,false);
			flipped = false;
		}
		
		
	}
}


//List of NoteCards(GameObjects)
//User will go through notecards and based on what card they're on
//This script will grab its animator and flip it

