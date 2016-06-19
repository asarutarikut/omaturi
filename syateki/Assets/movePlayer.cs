using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float speed;

	// Update is called once per frame
	void Update () {
		this.transform.position += transform.forward * speed * Time.deltaTime;
	}
}
