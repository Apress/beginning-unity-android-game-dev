using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {
	public float delay = 3.0f;

	void Start() {
		Destroy(this.gameObject, delay);
	}
}