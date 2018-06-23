using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour {

    public KeyCode changeClr;
    public Material materialOfObject;
    public Color newColor;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(changeClr))
        {
            materialOfObject.color = newColor;
        }
	}
}
