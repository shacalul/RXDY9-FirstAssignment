using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour
{

   // GameObject zombie;
   /// <summary>
   /// Called when the scene is loaded
   /// </summary>
   public GameObject warrior;

   public GameObject virtualButtonObject;
    void Start() {
	    warrior = GameObject.Find("warrior");
		virtualButtonObject = GameObject.Find ("actionButton");
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
      //  virtualButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
			

    }

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
   void OnButtonPressed(VirtualButtonBehaviour vb) { 
	
        Debug.Log("button Pressed");
        warrior.GetComponent<Animation>().Play();

    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
     void OnButtonReleased(VirtualButtonBehaviour vb) { 
	
       warrior.GetComponent<Animation> ().Stop ();
       

    }
    
    
}