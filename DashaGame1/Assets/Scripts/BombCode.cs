using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BombCode : MonoBehaviour {

	//name input field
	private TextMesh _myTM; 
	GameObject player;
	private string bombName;


	
	public void Start()
   	 {
		GameObject roomIndex = GameObject.Find("_loadedRoom");
    	LoadRoomsWithStuff playerScript = roomIndex.GetComponent<LoadRoomsWithStuff>();
   	
      //GameObject.Find("roomIndex").GetComponent<RoomIndex>();
   	 }


	
	public void OnSubmit()
	{

		bombName = _myTM.text;

		if (bombName.CompareTo("wakeup") == 0) 
			{
				player = GameObject.FindWithTag("Bedroom2");
				Debug.Log("You defused the bomb"); 
			}
	}


}
