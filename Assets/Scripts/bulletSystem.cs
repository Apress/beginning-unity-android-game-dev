using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleInputNamespace;

public class bulletSystem : MonoBehaviour {

	public Transform bulletEnd;
	public Rigidbody bulletPrefab;

	public float force = 500.0f;

	float currentTime;
	public float delay = 0.5f;

	AudioSource audioSource;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

	void FixedUpdate() {
		if (((Mathf.Abs(SimpleInput.GetAxisRaw("MouseX")) > 0.75f) || (Mathf.Abs(SimpleInput.GetAxisRaw("MouseY")) > 0.75f)) &&
            ((Time.time - currentTime > delay) || (currentTime < 0.01f))) {

			currentTime = Time.time;
			audioSource.Play();

			Rigidbody bulletInstance = Instantiate(bulletPrefab, bulletEnd.position, bulletEnd.rotation) as Rigidbody;
			bulletInstance.AddForce(bulletEnd.forward * force);
		}
	}
}