using UnityEngine;
using System.Collections;

public class Spinning : MonoBehaviour {

	// Update is called once per frame
	void Update() {
		transform.Rotate (new Vector3 (25, 0, 0) * Time.deltaTime);
	}
}
