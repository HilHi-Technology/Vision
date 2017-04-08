using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LevelPlacementScript : MonoBehaviour {

    public Vector2 RelativePosition;
    public Vector2 RelativeScale;
    static private HmdQuad_t rect;
    static private bool initialized = false;

	// Use this for initialization
	void Start () {
        LevelPlacementScript.PlaceObjectInLevel(gameObject, RelativePosition, RelativeScale);
    }

    static public void PlaceObjectInLevel(GameObject obj, Vector2 pos, Vector2 scale)
    {
        if (!initialized)
        {
            InitializeRect();
        }
        float absX = rect.vCorners0.v0 * pos.x;
        float absZ = rect.vCorners2.v2 * pos.y;
        Vector3 positionVector = new Vector3(absX, obj.transform.localPosition.y, absZ);
        obj.transform.localPosition = positionVector;
        if (scale.x != 0)
        {
            Vector3 originScale = obj.transform.localScale;
            originScale.x = rect.vCorners2.v2 * 2 * scale.x;
            obj.transform.localScale = originScale;
        }
        if (scale.y != 0)
        {
            Vector3 originScale = obj.transform.localScale;
            originScale.z = rect.vCorners0.v0 * 2 * scale.y;
            obj.transform.localScale = originScale;
        }
    }

    static private void InitializeRect()
    {
        SteamVR_PlayArea.GetBounds(SteamVR_PlayArea.Size.Calibrated, ref rect);
        initialized = true;
    }
}
