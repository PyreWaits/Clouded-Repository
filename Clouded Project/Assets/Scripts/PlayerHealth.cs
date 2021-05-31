using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    //Audio clip It does stuff. It declares there will be an audio clip. Sound may play at some point as part of a function in this code. Do you understand? 
    public AudioSource gameOver;
    public AudioSource playerDeath;

    

    //Cameras connected to player related actions.
    //Camera that follows the player
    public Camera MainCamera;
    //Will never be used if you are a gamer. I know you aren't so this is here.
    public Camera GameOverCamera;

    //Variables for health. Get healthy get strong.
    //Starting health doesn't get much simpler than that. As you get older it gets lower.
    public int startingHealth;
    //This is the players current health. It will go down. Since you suck at gaming.
    int currentHealth;





    //Rise and shine. Time for a healthy start.
    void Awake()
    {
        //Current health is the starting health. Probably max health too
        currentHealth = startingHealth;
    }

   //oH GOD i GET TO NAME THIS ONE I GOT AN IDEA! No I don't. Naming it doctor would be confusing. PUBLIC HEALTHCARE!
   //Function for changing health
   //Not built in and health care uses surgery which can make health reach too low then; Kill will be run. The healthcare is available to the public.
   public void HealthCare(int surgery)
    {
        //Sometimes your current health can get better with surgery or worse.
        currentHealth = currentHealth + surgery;
        //Uses math. The math "clamps" the current health to have a value from 0 to the starting health
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
        Animator ourAnimator2 = GetComponent<Animator>();

        ourAnimator2.SetInteger("hurt", -surgery);
        Invoke("Restore",2);
     
        //Gets the animator component for the game object attached to this script
        Animator ourAnimator1 = GetComponent<Animator>();
        //Sets the animator "currentHealth" to the currentHealth. Yes. IT ACTUALLY WORKED. NICE. 
        ourAnimator1.SetInteger("currentHealth", currentHealth);
        // if out health drops to 0 that means you die. Get good gamer. 
        if (currentHealth == 0)
        {
            //Sound for dying will play since you suck at this game.
            playerDeath.Play();
            //Will delay the kill command by 1 second with invoking 1 being the seconds
            Invoke("Kill",1);
            
        }
    }

    void Restore()
    {
        Animator ourAnimator2 = GetComponent<Animator>();
        ourAnimator2.SetInteger("hurt", 0);
    }

    //Non built in function for unity
    //It will only be called manually through our own code
    //It must be marked public so our other scripts can access it
    public void Kill()
    {
        //Will disable the main camera
        MainCamera.enabled = false;
        //Will enable the game over camera to show a menu 
        GameOverCamera.enabled = true;

        //Game over sound will be callled 
        gameOver.Play();



        // Will destroy the gameObject with this script
        Destroy(gameObject);
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
    }


    public int GetHealth()
    {
        return currentHealth;
    }


}
