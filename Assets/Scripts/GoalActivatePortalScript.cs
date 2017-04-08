using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalActivatePortalScript : MonoBehaviour {

    public GameObject portalToActivate;
    public GameObject triggerObj;

    private void OnTriggerEnter(Collider other) {
        if (other.name == triggerObj.name)
        {
            portalToActivate.SetActive(true);
            GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0, 0.5f);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.name == triggerObj.name) {
            portalToActivate.SetActive(false);
            GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 0.5f);
        }
    }
}
