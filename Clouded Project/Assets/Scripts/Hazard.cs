using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //Variabubbles
    //will be the hurt that happens. Reducing player health
    public int hurt;
    public AudioSource PlayerHit;

    // Built in unity function for handling collisions
    // This function will be called when another object bumps
    // into the one this script is attached to
    public void OnCollisionEnter2D(Collision2D collisionData)
    {
        //get the object we collided with
        Collider2D objectWeCollidedWith = collisionData.collider;
        

        // Get the PlayerHealth script attached to that object (if there is one)
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();
        
        
        //Check if we actually found a player health script on the object we collided with
        //This if statement is true if the player variable is not null (empty)
        if (player != null)
        {
            //This means there was a playerhealth script attached to the object we bumped into
            //Which means the object is the player
            PlayerHit.Play();
            //If so then perform our action
            //Remember healthcare is the change health function. Why did you name things this way. 
            player.HealthCare(-hurt);
           
            
            
           



        }

    }
}
