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
	public Moved moved;


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
		if(index <2)
			StartCoroutine(Next());
	}

	void OnPrevious()
	{
		if (index > 0)
		{
			currCard.SetActive(false);
			index--;
			currCard = noteCards[index];
			currCard.SetActive(true);
			moved = currCard.GetComponent<Moved>();
			currCardAnimator = currCard.GetComponent<Animator>();
			if (moved.up)
			{
				currCardAnimator.SetBool("Down", true);
			}
		}
		
	}

	IEnumerator Next()
	{
		moved = currCard.GetComponent<Moved>();
		if (moved.down)
		{
			currCardAnimator.SetBool("Up", true);
		}
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