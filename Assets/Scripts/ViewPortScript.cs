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
        GameObject headset = GameObject.FindGameObjectWithTag("MainCamera");
        float distanceToPort = Vector3.Distance(headset.transform.position, ViewPort.transform.position);
        float fovAngle =  Mathf.Atan((ViewPort.transform.lossyScale.x / 2) / distanceToPort) * Mathf.Rad2Deg * 2;
        print(Mathf.Atan((ViewPort.transform.lossyScale.x / 2) / distanceToPort) * Mathf.Rad2Deg * 2);
        GetComponent<Camera>().fieldOfView = fovAngle;
	}
}
