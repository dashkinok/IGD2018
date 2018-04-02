using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
public AudioClip coinSound;
new AudioSource blop;

	// Use this for initialization
	void Start () {
		GameObject obj = GameObject.Find("AudioHolder");

		AudioSource aud = obj.GetComponent<AudioSource>();

		aud.PlayOneShot(coinSound, 0.8f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
