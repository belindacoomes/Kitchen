using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

    [SerializeField]
    private float interactRange;

    private InteractiveObject interactiveObject;
    private Camera cam;
    private RaycastHit hit;
    private ReticleController reticleController;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        reticleController = GameObject.FindObjectOfType<ReticleController>();
	}
	
	// Update is called once per frame
	void Update () {
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactRange);
        //see if this hits any interactive object
        if (hit.transform)
        {
            //Debug.Log(hit.transform.name);
            interactiveObject = hit.transform.GetComponent<InteractiveObject>();

        }
        else
        {
            interactiveObject = null;
        }

        reticleController.ShowIcon(interactiveObject);
        
        if (Input.GetKeyDown(KeyCode.E))
        {

            if (interactiveObject)
            {
                // object is a door/drawer
                interactiveObject.onObjectInteraction();
            }
            
        }
    }

}
