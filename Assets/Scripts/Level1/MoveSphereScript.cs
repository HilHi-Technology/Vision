using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MoveSphereScript : MonoBehaviour {

    private HmdQuad_t rect;
    private float zPos = -1.5f;
    private float vel = 0.025f;

    // Use this for initialization
    void Start() {
        rect = new HmdQuad_t();
        SteamVR_PlayArea.GetBounds(SteamVR_PlayArea.Size.Calibrated, ref rect);
    }

    // Update is called once per frame
    void Update() {
        float absX = rect.vCorners0.v0 * 0.9f;
        if (zPos > 1.25f) {
            zPos = -1.25f;
        }
        if (InVision.CanSee(gameObject)) {
            vel += 0.00025f;
            if (vel > 0.025f) {
                vel = 0.025f;
            }
            zPos += vel;
        } else {
            vel = 0f;
        }
        float absZ = rect.vCorners2.v2 * zPos;
        Vector3 positionVector = new Vector3(absX, transform.localPosition.y, absZ);
        print(transform.lossyScale.x);
        print(transform.lossyScale.z);
        print(rect.vCorners0.v0);
        print(rect.vCorners2.v2);
        transform.localPosition = positionVector;
    }
}
