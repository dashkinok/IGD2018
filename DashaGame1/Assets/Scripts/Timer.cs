using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

    
public class Timer : MonoBehaviour{

public Text scoreText;
public Transform myChildObject;
public bool detachChild;
public GameObject player;
static bool TimerBegin = false;
 

    void Awake()
    {      
    	if(!TimerBegin)
    	{
    		InvokeRepeating("RunTimer", 1, 1);
    		DontDestroyOnLoad (gameObject); 
    		TimerBegin = true; 
    	}                            
    }

public	void Start () {


		// if (FindObjectsOfType(GetType()).Length > 2)
		// 	{
			    //Destroy (this.gameObject);
			    
			//}

		Destroy(gameObject,60);
		
	
	}

	void Update ()
	{
		// player.transform.SetParent(newParent, false);
	
		// if(detachChild == true)
  //        {
  //            myChildObject.parent = null;
  //        } 
	}
 
	void RunTimer() {
		scoreText.text = (int.Parse(scoreText.text) - 1).ToString();
	}

}





// }




// public float myTimer = 120;
//     public Text timerText;
//     private bool timerIsActive = true;

//     void Start () {
//         timerText = GetComponent<Text> ();
//     }

//     void Awake() {
//         DontDestroyOnLoad(transform.gameObject);
//     }

//     void Update () {
//         if (timerIsActive) {
//             myTimer -= Time.deltaTime;
//             timerText.text = myTimer.ToString ("f0");
//             print (myTimer);

//             if (myTimer <= 0) {
//                 myTimer = 0;
//                 timerIsActive = false;
                

//             }
//         }

//     }
// }


