﻿//------------------------------------------------------------------------------
// Simple Object Pool 
// Copyright © 2014 Enrique Uriarte
// You are free to redistribute, use, or modify this code in commercial or
// non commercial projects, but you may not resell it, keep this free
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

public class PoolParticleHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		particleSystem.renderer.enabled = true;
		particleSystem.time = 0;
		particleSystem.Clear(true);
		particleSystem.Play(true);
	}
	
	// Update is called once per frame
	void Stop () {
		particleSystem.Stop();
		particleSystem.time = 0;
		particleSystem.Clear(true);
		particleSystem.renderer.enabled = false;
	}
}