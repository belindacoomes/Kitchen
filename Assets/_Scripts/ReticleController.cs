using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleController : MonoBehaviour {

    private GameObject defaultIcon, interactIcon;


	// Use this for initialization
	void Start () {
        defaultIcon = GameObject.Find("DefaultIcon");
        interactIcon = GameObject.Find("InteractIcon");
        interactIcon.SetActive(false);
    }

    public void ShowIcon(bool isInteractIconShown)
    {
        defaultIcon.SetActive(!isInteractIconShown);
        interactIcon.SetActive(isInteractIconShown);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
