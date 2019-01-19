using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFlip : MonoBehaviour
{
	public Button flipButton;
	
	public List<GameObject> noteCards;

	public GameObject currCard;

	private int currCardIndex = 0;

	public Animator cardAnimator;

	public bool flipped;
	private static readonly int Flipped = Animator.StringToHash("Flipped");


	private void Awake()
	{
		flipButton.onClick.AddListener(OnClick);
		cardAnimator = noteCards[currCardIndex].GetComponent<Animator>();
	}

	// Use this for initialization
	void Start ()
	{
		currCard = noteCards[currCardIndex];
	}
	
	// Update is called once per frame
	void Update () 
	{
		
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

