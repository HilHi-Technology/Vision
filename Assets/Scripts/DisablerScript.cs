using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablerScript : MonoBehaviour {

    public GameObject rightController;
    public GameObject leftController;
    public GameObject tablet;

    void NextLevel() {
        rightController.SetActive(false);
        leftController.SetActive(false);
        tablet.SetActive(false);
    }
}
