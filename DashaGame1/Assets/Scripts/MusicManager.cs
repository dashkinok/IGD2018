using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

private GameObject activeMusicObject;
public GameObject kitchenSound;
public GameObject clockSound;
public GameObject binarySound;


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
				if (cL == 2 || cL == 11)
 				{
 					Debug.Log("in bedroom");
	 				if (activeMusicObject == null)
	 				{
	 					activeMusicObject = Instantiate(clockSound);
	 				}
 				}	
		 		else if ( cL == 3  )
		 		{
					Destroy(activeMusicObject);	
					activeMusicObject = Instantiate(kitchenSound);		 			
		 		}
		 		else if ( cL == 6  )
		 		{
					Destroy(activeMusicObject);	
					activeMusicObject = Instantiate(binarySound);
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



