using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusicSwitcherScript : MonoBehaviour {

    public AudioClip firstSong;
    public AudioClip secondSong;
    public AudioClip thirdSong;
    public AudioClip winNoise;

    void Start()
    {
        GetComponent<AudioSource>().clip = firstSong;
    }

    void NextLevel() {
        var clip = GetComponent<AudioSource>().clip;
        if (clip == firstSong)
        {
            GetComponent<AudioSource>().clip = secondSong;
            GetComponent<AudioSource>().loop = true;
            GetComponent<AudioSource>().Play();
        } else if (clip == secondSong)
        {
            GetComponent<AudioSource>().clip = thirdSong;
            GetComponent<AudioSource>().loop = true;
            GetComponent<AudioSource>().Play();
        } else if (clip == thirdSong)
        {
            GetComponent<AudioSource>().clip = winNoise;
            GetComponent<AudioSource>().loop = false;
            GetComponent<AudioSource>().Play();
        }
    }
}
