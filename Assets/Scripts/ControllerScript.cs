using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

    void NextLevel() {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
