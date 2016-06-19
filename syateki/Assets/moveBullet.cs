using UnityEngine;
using System.Collections;

public class moveBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += 60 * Time.deltaTime * transform.forward;
	}
}
