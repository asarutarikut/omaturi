using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class moveWanage : MonoBehaviour {
	public GameObject player;

	// Update is called once per frame
	void Update () {
		float c = player.transform.position.x;
		float d = player.transform.position.z;
		float a = transform.position.x;
		float b = transform.position.z;

		if (Mathf.Abs (Mathf.Sqrt (Mathf.Pow (c - a, 2f)) + Mathf.Pow (d - b, 2f)) < 1.5) {
			SceneManager.LoadScene ("syateki");
		}
	}
}
