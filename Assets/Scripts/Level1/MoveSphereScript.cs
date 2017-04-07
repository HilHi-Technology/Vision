﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MoveSphereScript : MonoBehaviour {

    public GameObject detectionObject;

    private HmdQuad_t rect;
    private float zPos = -1.5f;
    private float vel = 0.025f;

    // Update is called once per frame
    void Update() {
        float absX = rect.vCorners0.v0 * 0.9f;
        if (zPos > 1.25f) {
            zPos = -1.25f;
        }
        if (InVision.CanSee(detectionObject)) {
            vel += 0.00025f;
            if (vel > 0.025f) {
                vel = 0.025f;
            }
            zPos += vel;
        } else {
            vel = 0f;
        }
        LevelPlacementScript.PlaceObjectInLevel(gameObject, new Vector2(0.9f, zPos), new Vector2(0f, 0f));
    }
}
