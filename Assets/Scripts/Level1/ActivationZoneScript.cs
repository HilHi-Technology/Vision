using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationZoneScript : MonoBehaviour {

    public GameObject triggerObj;

    void Update()
    {
        var camera = GameObject.FindGameObjectWithTag("MainCamera");
        if (transform.position.x - transform.lossyScale.x/3 < camera.transform.position.x && transform.position.x + transform.lossyScale.x/3 > camera.transform.position.x && transform.position.z - transform.lossyScale.z/3 < camera.transform.position.z && transform.position.z + transform.lossyScale.z/3 > camera.transform.position.z)
        {
            Debug.Log("inhere");
            GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0, 0.5f);
            triggerObj.GetComponent<MoveSphereScript>().enabled = true;
        } else
        {
            Debug.Log("outtahere");
            GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 0.5f);
            triggerObj.GetComponent<MoveSphereScript>().enabled = false;

        }
    }
}
