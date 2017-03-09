using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoureWinner : MonoBehaviour {

    public GameObject WinnerText;

	void OnTriggerEnter() {
        WinnerText.SetActive(true);
        print("pls");
    }
}
