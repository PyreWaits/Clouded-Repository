using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    //Cameras connected to player health
    public AudioClip audioClip;
    public Camera MainCamera;
    public Camera GameOverCamera;

    //Non built in function for unity
    //It will only be called manually through our own code
    //It must be marked public so our other scripts can access it
    public void Kill()
    {
        //Will disable the main camera
        MainCamera.enabled = false;
        //Will enable the game over camera to show a menu 
        GameOverCamera.enabled = true;


        AudioSource.PlayClipAtPoint(audioClip, transform.position);



        // Will destroy the gameObject with this script
        Destroy(gameObject);
        
    }


}
