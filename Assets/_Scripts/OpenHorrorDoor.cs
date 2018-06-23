using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHorrorDoor : MonoBehaviour {

    private Animator animator = null;

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("open", true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("open", false);
    }
}
