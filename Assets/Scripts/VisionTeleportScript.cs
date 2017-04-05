using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionTeleportScript : MonoBehaviour {

    public Vector3 teleportLoc;
    public GameObject disableLevel;
    public GameObject enableLevel;

	void FullVision() {
        GameObject.FindGameObjectWithTag("CameraRig").transform.position = teleportLoc;
        disableLevel.active = false;
        enableLevel.active = true;
    }
}
