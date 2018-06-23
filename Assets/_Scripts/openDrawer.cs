using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDrawer : MonoBehaviour {

    private bool isDrawOpen = false;
    //public  Cabinet Right drawDimensions;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider plyr)
    {
        //if player is in trigger zone and presses E, and the draw is not open, open the draw
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !isDrawOpen)
        {

            //isDrawOpen == true;
        }
    }
}
