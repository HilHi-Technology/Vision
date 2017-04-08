using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour {
    private bool moving = false;
    private bool seen = false;
    // Update is called once per frame
	void Update () {
        transform.Rotate(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        if (moving) {
            if (InVision.CanSee(gameObject)) {
                seen = true;
                print("yesssss");
            }
            if (seen) {
                Vector3 localPos = transform.localPosition;
                localPos.x = localPos.x - 0.005f;
                transform.localPosition = localPos;
            }
        }
	}

    void NextLevel() {
        moving = true;
        print("fuck");
    }
}
