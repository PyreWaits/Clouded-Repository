using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerContactSound : MonoBehaviour
{
    //turns out I might not need this keeping for reference. Can't belive I spent all this time trying to figure this out myself then there was a simpler way.
    //Gets the audio source 
    public AudioSource PlayerContact;
    //When a 2d trigger collider enters a collider
    public void OnTriggerEnter2D(Collider2D other)
    {
        // Object that has the tag player will cause the player hit sound to play when touching others with the script
        if (other.tag == "Player" && !PlayerContact.isPlaying)
        {
            PlayerContact.Play();
        }
    }
}

