﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKoodi : MonoBehaviour {

	public Transform pelaaja;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(pelaaja);
	}
}
