using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InVision : MonoBehaviour {
	static public bool CanSee (GameObject obj) {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, obj.GetComponent<MeshRenderer>().bounds);
	}
    static public bool CanSee (GameObject obj, Bounds bounds) {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, bounds);
    }
    static public float DistanceFromCenter (GameObject obj)
    {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        var screenPos = camera.WorldToScreenPoint(obj.transform.position);
        var distance =  (1.75f * Mathf.Sqrt(Mathf.Pow((camera.pixelWidth / 2) - screenPos.x, 2) + Mathf.Pow((camera.pixelHeight / 2) - screenPos.y, 2))) / (Mathf.Sqrt(Mathf.Pow(camera.pixelWidth, 2) + Mathf.Pow(camera.pixelHeight, 2)) / 2);
        if (distance > 1)
        {
            distance = 0;
        } else
        {
            distance = 1 - distance;
        }
        return distance;
    }
}
