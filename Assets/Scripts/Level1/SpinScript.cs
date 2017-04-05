using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour {
    public GameObject levelCheck;
    // Update is called once per frame
	void Update () {
        transform.Rotate(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        if (!levelCheck.activeSelf) {
            Vector3 localPos = transform.localPosition;
            localPos.x = localPos.x - 0.005f;
            transform.localPosition = localPos;
        }
	}
}
