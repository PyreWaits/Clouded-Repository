using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
   

    //Condition: when the projectile hits a certain object type (plant)
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //Destroys object if it touches another collider. (Which it does. The player is a collider)
        Destroy(gameObject,2);
        //check if the object we collided with has the tag we are looking for(plant)
        if (otherCollider.CompareTag("plant"))
        {
            //Destroys the game object
            Destroy(gameObject);
            //Perform our action
            Hydrate(otherCollider.gameObject);
            
        }
        
       
    }
 
    //Action kills things
    public void Hydrate(GameObject plant)
    {
      Destroy(plant);

    }
}
