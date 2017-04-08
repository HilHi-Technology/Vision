using HTC.UnityPlugin.StereoRendering;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionTeleportScript : MonoBehaviour {

    public GameObject thisLevel;
    public GameObject nextLevel;
    public GameObject followingLevel;
    public GameObject[] thingsToTrigger;
    private Quaternion portalNormal;
    private Quaternion nextLevelNormal;
    private Quaternion portalRotated;
    private Quaternion nextLevelRotated;
    private bool rotated;

    void Start()
    {
        portalNormal = transform.localRotation;
        var rotation = transform;
        rotation.Rotate(0, 180, 0);
        portalRotated = rotation.localRotation;
        rotation.Rotate(0, -180, 0);
        nextLevelNormal = nextLevel.transform.localRotation;
        var nextLevelRotation = nextLevel.transform;
        nextLevelRotation.Rotate(0, 180, 0);
        nextLevelRotated = nextLevelRotation.localRotation;
        nextLevelRotation.Rotate(0, -180, 0);
        print(portalNormal.y);
        print(portalRotated.y);
    }

    void Update()
    {
        var parentScale = transform.localScale;
        transform.GetChild(0).transform.localScale = new Vector3(1 / parentScale.x, 1 / parentScale.y, 1 / parentScale.z);
        if (GameObject.FindGameObjectWithTag("MainCamera").transform.position.x < transform.position.x)
        {
            transform.localRotation = portalRotated;
            rotated = true;
        } else
        {
            transform.localRotation = portalNormal;
            rotated = false;
        }
    }

    void FullVision() {
        var camera = GameObject.FindGameObjectWithTag("MainCamera");
        if (rotated)
        {
            camera.transform.parent.transform.Rotate(0, 180, 0);
        }
        camera.transform.parent.transform.position = nextLevel.transform.position;
        thisLevel.active = false;
        followingLevel.active = true;
        foreach (GameObject go  in thingsToTrigger)
        {
            go.BroadcastMessage("NextLevel");
        }
    }
}
