using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.EventSystems;

public class SoundClick : MonoBehaviour {

public AudioClip impact;
public AudioSource audioSource;

public void OnMouseDown()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(impact, 0.7F);
        Debug.Log("FridgeOpen");     	
    }
    
}
