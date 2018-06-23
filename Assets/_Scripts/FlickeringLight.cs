using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

    public float minTime = 0.05f;
    public float maxTime = 1.2f;

    private float timer;
    private Light light;

    public GameObject FlickeringLightDarkFilter;

    // Use this for initialization
    void Start () {
        light = GetComponent<Light>();
        timer = Random.Range(minTime, maxTime);
        //GetComponent<GameObject.Find("FlickeringLightDarkFilter") > ();
    }

    
    // Update is called once per frame
    void Update ()
    {
        //
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            light.enabled = !light.enabled;
            
            // enable/diable FlickeringLightDarkFilter
            FlickeringLightDarkFilter.SetActive(!light.enabled);

            timer = Random.Range(minTime, maxTime);
            
            
        }
    }
}
