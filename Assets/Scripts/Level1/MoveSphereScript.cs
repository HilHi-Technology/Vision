using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MoveSphereScript : MonoBehaviour {

    public GameObject detectionObject;

    private HmdQuad_t rect;
    private float zPos = -1f;
    private float vel = 0.025f;
    private bool moving = false;

    // Update is called once per frame
    void Update() {
        if (moving)
        {
            float absX = rect.vCorners0.v0 * 0.9f;
            vel = 0.025f * InVision.DistanceFromCenter(detectionObject);
            if (zPos > 1.1f) {
                zPos = -1f;
            }
            if (InVision.CanSee(detectionObject)) {
                zPos += vel;
            }
        }
        LevelPlacementScript.PlaceObjectInLevel(gameObject, new Vector2(0.9f, zPos), new Vector2(0f, 0f));
    }

    void NextLevel()
    {
        moving = true;
    }
}
