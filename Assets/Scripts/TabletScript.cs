using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletScript : MonoBehaviour {

    void NextLevel() { 
        transform.SetParent(GameObject.FindGameObjectWithTag("MainCamera").transform.parent.transform);
        transform.GetChild(0).gameObject.layer = LayerMask.NameToLayer("StereoRender_See");
        transform.GetChild(1).gameObject.layer = LayerMask.NameToLayer("StereoRender_See");
    }
}
