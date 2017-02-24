using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViewPortScript : MonoBehaviour {

    public GameObject ViewPort;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float distanceToPort = Vector3.Distance(transform.position, ViewPort.transform.position);
        print(distanceToPort);
        Camera camera = GetComponent<Camera>();
        float fovAngle = Mathf.Atan2(ViewPort.transform.lossyScale.x / 2, distanceToPort) * Mathf.Rad2Deg * 2;
        print(Mathf.Atan2(ViewPort.transform.lossyScale.x / 2, distanceToPort));
        print(fovAngle);
        camera.fieldOfView = fovAngle;
        camera.nearClipPlane = distanceToPort;
        transform.parent.LookAt(ViewPort.transform, Vector3.down);
	}
}
