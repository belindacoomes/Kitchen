using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomLightLeft : MonoBehaviour {


    public GameObject light;
    private bool isLightOn = false;
    public AudioClip bedroomLampSound;

    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource.clip = bedroomLampSound;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E) && !isLightOn)
        //{
        //    light.SetActive(true);
        //    isLightOn = true;
        //}
        // if player in sphere area and light is on, turn light off
        //else if (Input.GetKeyDown(KeyCode.E) && isLightOn)
        //{
        //    light.SetActive(false);
        //    isLightOn = false;

        //}
    }



    void OnTriggerStay(Collider plyr)
    {
        // Debug.Log("Object is in the trigger area");

        // if player in sphere area and light is off, turn light on
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !isLightOn)
        {
            light.SetActive(true);
            isLightOn = true;
            audioSource.Play();

        }
        // if player in sphere area and light is on, turn light off
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && isLightOn)
        {
            light.SetActive(false);
            isLightOn = false;
            audioSource.Play();

        }
    }
}
