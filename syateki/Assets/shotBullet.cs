﻿using UnityEngine;
using System.Collections;

public class shotBullet : MonoBehaviour {
	public GameObject bullet;
	public GameObject iti_gun;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
		var device = SteamVR_Controller.Input((int) trackedObject.index);

		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)) {
			Instantiate (bullet, iti_gun.transform.position, Quaternion.identity);
		}
	}
}
