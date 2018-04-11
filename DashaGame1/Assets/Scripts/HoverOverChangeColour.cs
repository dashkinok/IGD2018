using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOverChangeColour : MonoBehaviour {



 SpriteRenderer renderer; 


    void Start()
    {    	
    	renderer = GetComponent<SpriteRenderer>();      
    }

    //Run your mouse over the GameObject to change the Renderer's material color to red
    void OnMouseOver()
    {
        //m_Renderer.material.color = Color.red;
        renderer.color = new Color(0f, 0f, 1f, 0.3f);
        
    }

    //Change the Material's Color back to white when the mouse exits the GameObject
    void OnMouseExit()
    {
        renderer.color = new Color(0f, 0f, 0f, 0f);
        
    }
}
