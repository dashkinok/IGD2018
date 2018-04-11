using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTime : MonoBehaviour {

	private TextMesh _myTM;
	private Timer _myTimer;

	void Start(){
	
		_myTM = GetComponent<TextMesh> ();
		_myTimer = GameObject.Find ("Managers").GetComponent<Timer> ();

	}

	void Update(){
	
		_myTM.text = _myTimer.displayTimer.ToString();
	
	
	}






}
