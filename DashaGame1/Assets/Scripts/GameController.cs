using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GameController : MonoBehaviour {

	public string CorrectAnswer;
	public int countGuess;

	private int cL;
	private int currentLevel;


	[SerializeField]
	private InputField input;

	[SerializeField]
	private Text text;

	[SerializeField] 
	private LoadRoomsWithStuff myRl;

	void Awake()
	{
		
		CorrectAnswer = "wakeup";
		text.text = "Enter the Code";  
	}


	void Start(){
	
		myRl = GameObject.Find("Managers").GetComponent<LoadRoomsWithStuff> ();
	
	}

	public void GetInput(string guess)
	{
		Debug.Log (guess);
		CompareGuesses(guess);
		input.text = "";
	}

	void CompareGuesses(string guess)
	{
		Debug.Log ("CompareGuesses is called");
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

		RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);


		if (guess == CorrectAnswer )
		{		
			Debug.Log("You defused the bomb");

			if (hit.collider.gameObject.tag == "Bedroom2") {
				myRl.roomIndex = 10;
			}
				
		} 
		else if (guess != CorrectAnswer && hit.collider.gameObject.tag == "Bedroom2" )
	 	{
			text.text = "Tik-Tok";
		}
				
	}
		
	void Update () {
		currentLevel = myRl.roomIndex;
		cL = currentLevel;
	}
}
