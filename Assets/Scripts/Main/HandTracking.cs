﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour {

	public OVRInput.Controller controller;
	public GameObject Hand;
	public bool right = true;

	private bool left;
	private Quaternion handRot;
	private Vector3 handPose;
	private Vector3 handScal;
	private Matrix4x4 handpose=Matrix4x4.identity;
	private Material hand;

	// Use this for initialization
	void Start () 
	{
		
		handScal = new Vector3 (1, 1, 1);
		hand = Hand.GetComponent<Renderer> ().sharedMaterial;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//working on switching hands

		left = this.GetComponent<LHandTracking> ().left;

		if (OVRInput.GetDown (OVRInput.RawButton.Y)) {
			right = false;
			this.GetComponent<LHandTracking> ().left = true;
		}
		
		if (right)
			this.GetComponent<LHandTracking> ().enabled = false;

		if (right == false)
			this.GetComponent<LHandTracking> ().enabled = true;
	

		handRot = OVRInput.GetLocalControllerRotation (controller);
		handPose = OVRInput.GetLocalControllerPosition (controller);

		var Hpose = hand.GetMatrix ("_objectpose");
		Hpose=Matrix4x4.TRS(handPose,handRot,handScal);
		hand.SetMatrix ("_objectpose", Hpose);

		if (OVRInput.GetDown (OVRInput.RawButton.Start))
			UnityEngine.Application.LoadLevel (0);
	}
}
