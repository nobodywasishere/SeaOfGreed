﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamUtility.IO;

public class GameOptions : MonoBehaviour {
	public Canvas parent;
	private Canvas canvas;

	void Start(){
		canvas = GetComponent<Canvas> ();
		
	}
}