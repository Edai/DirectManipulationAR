using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleObject : MonoBehaviour {
    bool cubeIn = false;

	// Use this for initialization
	void Start () {
	    GetComponent<Renderer>().material.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
    }
	
	// Update is called once per frame
	void Update () {
        if(cubeIn)
        {
            GetComponent<Renderer>().material.color = new Color32(0x0, 0xFF, 0x0, 0xFF);
        }
        else
        {
            GetComponent<Renderer>().material.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.name == "ColoredFaceCube")
        {
            cubeIn = true;
        }
    }

    void OnTriggerExit()
    {
        cubeIn = false;
    }

}
