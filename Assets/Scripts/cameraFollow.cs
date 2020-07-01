using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform player;
    public float height = 12.5f;

    void LateUpdate() {
        if (player) {
            this.transform.position = new Vector3(player.position.x, height, player.position.z);
        }
    }
}
