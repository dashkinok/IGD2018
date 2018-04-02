using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.EventSystems;

public class Singleton : MonoBehaviour {

 public Transform myChildObject;
 public bool detachChild;
	 
static bool AudioBegin = false; 
//public GameObject musicPlayer;

 void Awake()
	 {
	      if (!AudioBegin) 
	     	 {
	       		GetComponent<AudioSource>().Play ();
	            DontDestroyOnLoad (gameObject);
	            AudioBegin = true;
	         } 
 	 }



void Update () 
 	 {
	    if(detachChild == true)
         {
             myChildObject.parent = null;
         } 
         
		
	 }

public void Start()
{
		if (FindObjectsOfType(GetType()).Length > 1)
			{
			    Destroy (this.gameObject);
			    Debug.Log("Object Deleted"); 
			}	
	}


 		 
}

 
      
