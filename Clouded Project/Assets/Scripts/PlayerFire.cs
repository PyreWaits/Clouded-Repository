using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // unity pubs are editble
    public GameObject rainDropPrefab;
    public Vector2 projectileVelocity;
    public int startingWater;
    int currentWater;
    void Awake()
    {
        currentWater = startingWater;
    }
    public void GiveWater(int Hydrate)
    {
        //Remember if your current water is low hydrate.
        currentWater = currentWater + Hydrate;
        //Uses math. The math "bottles" the water to have a value from 0 to the starting water
        currentWater = Mathf.Clamp(currentWater, 0, startingWater);
    }
    //Action: Fire a Projectile
    public void FireProjectile()
    {
   
        if (currentWater >=1)
            {


            // clone the projectile and fire it in a direction
            // variable to hold the cloned object
            GameObject clonedProjectile;

            //Use Instantiate to clone the rainDropPrefab and keep the result in our variable
            clonedProjectile = Instantiate(rainDropPrefab);

            //position the projectile
            clonedProjectile.transform.position = transform.position;

            //fire it in a direction
            //Declare a variable to hold the cloned objects rigidbody
            Rigidbody2D projectileRigidbody;
            //get the rigidbody from out cloned projectile and store it 
            projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
            //set the velocity on the rigidbody to the editor setting
            projectileRigidbody.velocity = projectileVelocity;
            //reduce the counter for water
            currentWater = currentWater - 1;

        }


    }
    //This is to be used in the water display code
    public int GetWater()
    {
        return currentWater;
    }

}
