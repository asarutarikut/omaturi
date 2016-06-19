using UnityEngine;
using System.Collections;

public class SyatekiControllerRight : MonoBehaviour {

	public GameObject bullet;
	public GameObject RightController;
	public GameObject Gun;

	public float speed = 1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
		var device = SteamVR_Controller.Input((int) trackedObject.index);
		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)) {
			Shoot();			
		}
	}

	void Shoot () {
		GameObject obj = GameObject.Instantiate(bullet)as GameObject;
		obj.transform.position = RightController.transform.position;
		Vector3 force;
		force = this.gameObject.transform.forward * speed;
	}
}
