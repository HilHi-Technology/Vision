using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFadeScript : MonoBehaviour {

    public GameObject portalToActivate;
    public GameObject triggerObj;

    void Update() {
        Color color = GetComponent<MeshRenderer>().material.color;
        float invisPercent = 0.4f - InVision.DistanceFromCenter(gameObject);
        if (invisPercent < 0) {
            color.a = 0;
        } else {
            color.a = 0.5f * invisPercent;
        }
        GetComponent<MeshRenderer>().material.color = color;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == triggerObj.name) {
            portalToActivate.SetActive(true);
            Color color = GetComponent<MeshRenderer>().material.color;
            color.r = 0;
            color.g = 1;
            GetComponent<MeshRenderer>().material.color = color;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.name == triggerObj.name) {
            portalToActivate.SetActive(false);
            Color color = GetComponent<MeshRenderer>().material.color;
            color.r = 1;
            color.g = 0;
            GetComponent<MeshRenderer>().material.color = color;
        }
    }
}
