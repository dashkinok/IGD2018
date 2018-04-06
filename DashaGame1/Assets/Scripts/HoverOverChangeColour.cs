using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOverChangeColour : MonoBehaviour {

 
 // Color m_MouseOverColor = Color.red;
 // Color m_OriginalColor = Color.clear;
 // MeshRenderer m_Renderer;


	// void Start() {
		
	// 	m_Renderer = GetComponent<MeshRenderer>();
	// 	m_OriginalColor = m_Renderer.material.color;
	// }
 
	// void OnMouseOver() {
	// 	m_Renderer.material.color = m_MouseOverColor;
	// 	Debug.Log("here!");

	// }
 
	// void OnMouseExit() {
	// 	m_Renderer.material.color = m_OriginalColor;
	// 	Debug.Log("bye!");
	// }

	 SpriteRenderer renderer; 
	 //public Color color = Color.white;

    void Start()
    {
    	
    	renderer = GetComponent<SpriteRenderer>();
        //Fetch the Renderer component of the GameObject
       // m_Renderer = GetComponent<Renderer>();
        // renderer.color = new Color
        // color.a = 0;
    }

    //Run your mouse over the GameObject to change the Renderer's material color to red
    void OnMouseOver()
    {
        //m_Renderer.material.color = Color.red;
        renderer.color = new Color(0f, 0f, 1f, 0.3f);
        Debug.Log("here!");
    }

    //Change the Material's Color back to white when the mouse exits the GameObject
    void OnMouseExit()
    {
        renderer.color = new Color(0f, 0f, 0f, 0f);
        Debug.Log("Bye!");
    }
}
