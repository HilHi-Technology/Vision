using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionTeleportScript : MonoBehaviour {

    public Vector3 teleportLoc;

	void FullVision() {
        GameObject.FindGameObjectWithTag("CameraRig").transform.position = teleportLoc;
    }
}
