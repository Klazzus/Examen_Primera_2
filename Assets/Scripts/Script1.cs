﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Script1 : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }

    void OnTriggerEnter(Collider collision)
    {
        DestroyObject(this.gameObject);
        Debug.Log("COLISION TRUE");
    }
}
