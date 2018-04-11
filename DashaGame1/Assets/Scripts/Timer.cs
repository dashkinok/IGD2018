using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class Timer : MonoBehaviour{
	// when time changes, it plays a tick sound
	private int _displayTimer;
	public int displayTimer
	{
		get {
			return _displayTimer;
		}
		set{
			if (value != _displayTimer) {
				_displayTimer = value;
				myAS.PlayOneShot (tick);
			}
		}
	}

	// When the timer turns on, the timer gets to 60 
	private bool _isTimerOn;
	private bool isTimerOn
	{
		get 
		{
			return _isTimerOn; 
		}
		set
		{ 
			if (value != _isTimerOn) 
			{
				_isTimerOn = value;
				if (value == true) {
					timer = 60;
				}
			}
		}
	}
	[SerializeField] private AudioSource myAS;
	[SerializeField] private float timer;

	[SerializeField] private LoadRoomsWithStuff mySm;

	public AudioClip tick;

	// Adding audiosource, grab scenemanager
	void Start()
	{
		myAS = gameObject.AddComponent<AudioSource> ();
		mySm = GetComponent<LoadRoomsWithStuff> ();
	
	
	
	}

	void Update()
	{
		TimerCheckRoom ();
		//Keep track of time, display integer, and if gets to 0 change the scene
		if (isTimerOn == true) {
			timer -= Time.deltaTime;
			Debug.Log (timer);
			displayTimer = (int)(timer);
			if (timer <= 0) {
				mySm.roomIndex = 9; 
			}
		}

	}

	void TimerCheckRoom()
	{
		// Turn timer on int he dream
		if (mySm.roomIndex == 6 || mySm.roomIndex == 7 || mySm.roomIndex == 8) {
			Debug.Log ("True");
			isTimerOn = true;
		} else {
			Debug.Log ("False");
			isTimerOn = false;
		} 
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


