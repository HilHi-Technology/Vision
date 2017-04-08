using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlecardScript : MonoBehaviour {
    public GameObject levelToEnable;
	// Update is called once per frame
	void Update () {
        if (Time.time > 5)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            if (Time.time > 7)
            {
                transform.GetChild(1).gameObject.SetActive(true);
                if (Time.time > 12)
                {
                    levelToEnable.SetActive(true);
                    transform.parent.GetComponent<AudioSource>().Play();
                    gameObject.SetActive(false);
                }
            }
        }
    }
}
