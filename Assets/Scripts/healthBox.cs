using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBox : MonoBehaviour {
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            healthManager.instance.ChangeHealth(2);
            Destroy(this.gameObject);
        }
    }
}
