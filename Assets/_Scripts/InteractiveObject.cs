using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class InteractiveObject : MonoBehaviour {

    [SerializeField] private Vector3 openPosition, closedPosition;
    [SerializeField] float animationTime;
    [SerializeField] private MovementType movementType;
    [SerializeField] private List tagType;
    
    private Hashtable iTweenArgs;
    private enum MovementType { Slide, Rotate, Spin };
    private enum List { Door, Drawer, Light, Tv, Valve};

    //private Transform transform;
    

    bool isDrawOpen = false;
    bool isTvOn = false;
    bool isLightOn = false;
    bool isValveOpen = false;

    private AudioSource audioSource;
    private VideoPlayer videoPlayer;
    

    // Use this for initialization
    void Start () {
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("isLocal", true);

        //get audio source
        audioSource = GetComponent<AudioSource>();
        // get video source
        videoPlayer = GetComponent< VideoPlayer>();
        
        
    }

    public void onObjectInteraction()
    {
        // play audio if any to play
        if (audioSource)
        {
            audioSource.Play();
        }

        // determining the type of object found by the interator
        if (tagType == List.Door || tagType == List.Drawer)
        {
            // object is a door/drawer
            this.onDoorOrDrawerInteraction();
        }
        if (tagType == List.Light)
        {
            // object is a light
            this.onLightInteraction();
        }
        if (tagType == List.Tv)
        {
            // object is a tv
            this.onTVInteraction();
        }
        if (tagType == List.Valve)
        {
            this.onTubeValeSpin();
        }

    }

    // Update is called once per frame
    public void onDoorOrDrawerInteraction()
    {
        

        //if draw is closed
        if (!isDrawOpen)
        {
            iTweenArgs["position"] = openPosition;
            iTweenArgs["rotation"] = openPosition;
        }
        else
        {
            iTweenArgs["position"] = closedPosition;
            iTweenArgs["rotation"] = closedPosition;
        }
        
        isDrawOpen = !isDrawOpen;

        switch (movementType) {

            case MovementType.Slide:
                iTween.MoveTo(gameObject, iTweenArgs);
                break;
            case MovementType.Rotate:
                iTween.RotateTo(gameObject, iTweenArgs);
                break;
            

        }

	}

    public void onTVInteraction()
    {
        //if tv is off, turn on
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();

        }
        else if (videoPlayer.isPlaying){
            //turn tv off
            videoPlayer.Stop();
        }

        
        
    }

    public void onLightInteraction()
    { }

    public void onObjectInspectInteraction()
    {
        //object lifts up, spins, and sits back down
    }


    public void onTubeValeSpin()
    {
        if (movementType == MovementType.Spin)
        {
            // open valve
            if (!isValveOpen)
            {
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.x = 0;
                transform.rotation = Quaternion.Euler(rotationVector);
                //openPosition = new Vector3(
                //    this.transform.rotation.eulerAngles.x + 150,
                //    this.transform.rotation.eulerAngles.y,
                //    this.transform.rotation.eulerAngles.z) ;
                //iTweenArgs["rotation"] = openPosition;
            }
            else
            {
                //iTweenArgs["rotation"] = closedPosition;
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.x = 100;
                transform.rotation = Quaternion.Euler(rotationVector);
            }
            // add spin amount
            iTween.RotateTo(gameObject, iTweenArgs);
            isValveOpen = !isValveOpen;
         }
     }

 }

