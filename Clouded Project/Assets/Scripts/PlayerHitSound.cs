using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitSound : MonoBehaviour
{
    public AudioSource PlayerHit;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !PlayerHit.isPlaying)
        {
            PlayerHit.Play();
        }
    }
}

