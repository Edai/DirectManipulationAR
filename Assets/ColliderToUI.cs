using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderToUI : MonoBehaviour {

    public Text text;
    public Color color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other)
        {
            text.text = this.name;
            text.color = color;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        text.text = "";
    }
}
