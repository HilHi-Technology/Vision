using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereoCanvasFixer : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        var parentScale = transform.localScale;
        transform.GetChild(0).transform.localScale = new Vector3(1 / parentScale.x, 1 / parentScale.y, 1 / parentScale.z);

    }
}
