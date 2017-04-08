using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRevealScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (!InVision.CanSee(gameObject, GetComponent<MeshCollider>().bounds)) {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<AudioSource>().Play();
        }
	}
}
