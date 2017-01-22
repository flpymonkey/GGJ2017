﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;

    public bool diaglogActive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (diaglogActive && Input.GetKeyDown(KeyCode.Space))
        {
            dBox.SetActive(false);
            diaglogActive = false;
        }
	}
    public void showBox(string dialogue)
    {
        diaglogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }
}
