using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

private GameObject activeMusicObject;
public GameObject kitchenSounds;
public GameObject clockSound;


 private int cL;
 private int currentLevel
 {
 	get{
 		return cL;
 	}
 	set{
 		if (value != cL)
 		{
 			cL = value;
 			if (cL == 2)
 			{
 				Debug.Log("in bedroom");
 				if (activeMusicObject == null)
 				{
 					activeMusicObject = Instantiate(clockSound);
 				} 
 				
 			}
 		
 			else if ( cL == 3 || cL == 4 || cL == 5 )
 			{
 				
 				if(activeMusicObject = clockSound)
 				{
 					Debug.Log("not bedroom");
 				}

 				activeMusicObject = Instantiate(kitchenSounds);
 			
 			}
 		}
 	}
 }

 public LoadRoomsWithStuff mySM;
	
	 void Update () {
		currentLevel = mySM.roomIndex;
		cL = currentLevel;
	}
}



