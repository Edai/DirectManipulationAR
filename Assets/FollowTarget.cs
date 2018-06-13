using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{

    [SerializeField] private Transform imageTarget;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (imageTarget.gameObject.activeInHierarchy)
    	    transform.position = imageTarget.position;
	    transform.rotation = imageTarget.rotation;
	}
}
