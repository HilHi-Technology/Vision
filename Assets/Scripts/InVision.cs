using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InVision : MonoBehaviour {
	// Update is called once per frame
	static public bool CanSee (GameObject obj) {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        print("hmm");
        return GeometryUtility.TestPlanesAABB(planes, obj.GetComponent<MeshRenderer>().bounds);
	}
    static public bool CanSee (GameObject obj, Bounds bounds) {
        Camera camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        print("hmm");
        return GeometryUtility.TestPlanesAABB(planes, bounds);
    }
}
