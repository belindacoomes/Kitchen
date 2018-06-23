using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinObject : MonoBehaviour {

    [SerializeField] private Transform objectVector;
    private Transform spinningObject;
    //private new Vector3 objectVector;

    //// Use this for initialization
    void Start()
    {
        spinningObject = objectVector;

    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(Vector3.up, 10 * Time.deltaTime);
        transform.Rotate(Vector3.right, 10 * Time.deltaTime);
        transform.Rotate(Vector3.back, 10 * Time.deltaTime);
        //transform.Translate(Vector3.forward  * Time.deltaTime);
        


    }

    

  
}
