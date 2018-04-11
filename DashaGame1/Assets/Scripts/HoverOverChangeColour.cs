using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOverChangeColour : MonoBehaviour {

	public float animNormTime;
	public float maxSize;
	public Color hangOverColor;

	Vector3 originalScale;
	Vector3 targetScale;
 	SpriteRenderer renderer;
	float timer = 0;
	bool ifZoom = false;

    void Start()
    {    	
    	renderer = GetComponent<SpriteRenderer>(); 
		originalScale = transform.localScale;
		targetScale = originalScale * maxSize;
    }


	void Update()
	{
		if (ifZoom) {
			timer += Time.deltaTime / animNormTime;
		} else {
			timer -= Time.deltaTime / animNormTime;
		}

		timer = Mathf.Clamp01 (timer);
		Vector3 scale;
		scale = Vector3.Lerp (originalScale, targetScale, timer);
		transform.localScale = scale;
	}

    //Run your mouse over the GameObject to change the Renderer's material color to red
    void OnMouseOver()
    {
        //m_Renderer.material.color = Color.red;
		renderer.color = hangOverColor;

		ifZoom = true;
        
    }

    //Change the Material's Color back to white when the mouse exits the GameObject
    void OnMouseExit()
    {
		renderer.color = Color.white;

		ifZoom = false;
    }
}
