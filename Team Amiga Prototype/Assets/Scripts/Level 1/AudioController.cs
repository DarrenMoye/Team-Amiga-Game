using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    //Variables
    ///////////
    public bool Playing = false;
    AudioSource Audio;
    ///////////

    void Start()
    {
        //Defines the Audio Souce to paly
        Audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        //Plays the Audio if Space is Used and the Audio isn't alread playing
       if (Input.GetKey(KeyCode.Space) && Playing == false)
       {
            Audio.Play();
            Playing = true;
       }
        //Stops the Audio if Space isn't Used and the Audio is alread playing
        if (!Input.GetKey(KeyCode.Space) && Playing == true)
        {
            Audio.Stop();
            Playing = false;
        }
    }
}
