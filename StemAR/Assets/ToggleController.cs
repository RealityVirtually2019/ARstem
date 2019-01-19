using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
	public Toggle toggleT;
 	public Toggle toggleF;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(toggleT.isOn){

    	}
    }

    public void SwitchToggles(){
    	
	    if(toggleF.isOn){
	    	toggleT.isOn = false;
	    }
    }



    public void OffFalseToggle(){
    	if(toggleT.isOn){
	    	toggleF.isOn = false;
	    	print("OffFalseToggle");
	    }
    }

    public void OffTrueToggle(){
    	if(toggleF.isOn){
	    	toggleT.isOn = false;
	    	print("OffTrueToggle");
	    }
    }


}
