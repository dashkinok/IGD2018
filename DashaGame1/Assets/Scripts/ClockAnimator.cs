using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour {


	public Transform SecondHand, MinuteHand, HourHand;

	[SerializeField] private LoadRoomsWithStuff mySm;

	// When the timer turns on, the timer gets to 60 
	private bool _isClockOn;
	private bool isClockOn;



	void Start(){
		mySm = GetComponent<LoadRoomsWithStuff> ();
	}


	void Update(){
		
		DateTime currentTime = DateTime.Now;
		float second = (float)currentTime.Second;
		float minute = (float)currentTime.Minute;
		float hour = (float)currentTime.Hour % 12;

		float secondAngle = -360 * (second / 60);
		float minuteAngle = -360 * (minute / 60);
		float hourAngle = -360 * (hour / 60);

		SecondHand.localRotation = Quaternion.Euler (0, 0, secondAngle);
		MinuteHand.localRotation = Quaternion.Euler (0, 0, minuteAngle);
		HourHand.localRotation = Quaternion.Euler (0, 0, hourAngle);
	}


	void ClockCheckRoom()
	{
		// Turn timer on int he dream
		if (mySm.roomIndex == 2 || mySm.roomIndex == 11) {
			Debug.Log ("True");
			isClockOn = true;
		} else {
			Debug.Log ("False");
			isClockOn = false;
		} 
	}









}

