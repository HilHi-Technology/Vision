using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LevelPlacementScript : MonoBehaviour {

    public Vector2 RelativePosition;
    public Vector2 RelativeScale;

	// Use this for initialization
	void Start () {
        var rect = new HmdQuad_t();
        SteamVR_PlayArea.GetBounds(SteamVR_PlayArea.Size.Calibrated, ref rect);
        float absX = rect.vCorners0.v0 * RelativePosition.x;
        float absZ = rect.vCorners2.v2 * RelativePosition.y;
        Vector3 positionVector = new Vector3(absX, transform.localPosition.y, absZ);
        print(transform.lossyScale.x);
        print(transform.lossyScale.z);
        print(rect.vCorners0.v0);
        print(rect.vCorners2.v2);
        transform.localPosition = positionVector;
        if (RelativeScale.x != 0) {
            Vector3 originScale = transform.localScale;
            originScale.x = rect.vCorners2.v2 * 2 * RelativeScale.x;
            transform.localScale = originScale;
        }
        if (RelativeScale.y != 0) {
            Vector3 originScale = transform.localScale;
            originScale.z = rect.vCorners0.v0 * 2 * RelativeScale.y;
            transform.localScale = originScale;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
