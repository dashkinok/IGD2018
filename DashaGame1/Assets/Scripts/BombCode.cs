using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BombCode : MonoBehaviour {

	//name input field
	public InputField nameField; 
	GameObject player;
	private string bombName;


	public void helloBombCode()
	{
	
	}

	public void Start()
   {
		GameObject roomIndex = GameObject.Find("_loadedRoom");
    LoadRoomsWithStuff playerScript = roomIndex.GetComponent<LoadRoomsWithStuff>();
   	
      //GameObject.Find("roomIndex").GetComponent<RoomIndex>();

   }


	
	public void OnSubmit()
	{
	

		bombName = nameField.text;
		if (bombName.CompareTo("wakeup") == 0) 
		{
		

		player = GameObject.FindWithTag("Bedroom2");
		Debug.Log("You defused the bomb"); 
		}
	}


}
