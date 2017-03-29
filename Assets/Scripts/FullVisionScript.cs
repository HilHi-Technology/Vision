using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullVisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 camForward = transform.forward;
        Camera cam = GetComponent<Camera>();
        float vFOV = cam.fieldOfView;
        float radAngle = cam.fieldOfView * Mathf.Deg2Rad;
        float radHFOV = 2 * (float) Math.Atan(Mathf.Tan(radAngle / 2) * cam.aspect);
        float hFOV = Mathf.Rad2Deg * radHFOV;
        Vector3 upperLeft = Quaternion.AngleAxis(-hFOV / 2, transform.up) * Quaternion.AngleAxis(vFOV / 4, transform.right) * camForward;
        Vector3 upperRight = Quaternion.AngleAxis(hFOV / 2, transform.up) * Quaternion.AngleAxis(vFOV / 4, transform.right) * camForward;
        Vector3 lowerLeft = Quaternion.AngleAxis(-hFOV / 2, transform.up) * Quaternion.AngleAxis(-vFOV / 4, transform.right) * camForward;
        Vector3 lowerRight = Quaternion.AngleAxis(hFOV / 2, transform.up) * Quaternion.AngleAxis(-vFOV / 4, transform.right) * camForward;
        Debug.DrawRay(transform.position, upperLeft, Color.red);
        Debug.DrawRay(transform.position, upperRight, Color.blue);
        Debug.DrawRay(transform.position, lowerLeft, Color.green);
        Debug.DrawRay(transform.position, lowerRight, Color.yellow);
        Debug.DrawRay(transform.position, transform.forward, Color.white);
        RaycastHit upperLeftHit;
        RaycastHit upperRightHit;
        RaycastHit lowerLeftHit;
        RaycastHit lowerRightHit;
        if (Physics.Raycast(transform.position, upperLeft, out upperLeftHit)) {
            if (Physics.Raycast(transform.position, upperRight, out upperRightHit)) {
                if (Physics.Raycast(transform.position, lowerLeft, out lowerLeftHit)) {
                    if (Physics.Raycast(transform.position, lowerRight, out lowerRightHit)) {
                        if (upperLeftHit.transform == upperRightHit.transform && lowerLeftHit.transform == lowerRightHit.transform && upperLeftHit.transform == lowerLeftHit.transform) {
                            upperLeftHit.transform.BroadcastMessage("FullVision");
                        }
                    }
                }
            }
        }
    }
}
