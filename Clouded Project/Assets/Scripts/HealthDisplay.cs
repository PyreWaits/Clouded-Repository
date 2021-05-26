using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    // This will contain a list of game objects for the health icons
    // public - shown in unity
    // [] indicates an array (list)
    // GameObject [] will contain GameObjects
    public GameObject[] healthIcons;

    //will contain PlayerHealth component that is on the player game object
    // so we can ask it for info about the player health
    PlayerHealth player;


    // Start is called before the first frame update
    void Start()
    {
        // search the scene for the object iwth PlayerHealth attached 
        // Store the PlayerHealth component from that object in out player health variable.
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a variable to keep track of which item in the list we are on
        // and how much health that icon is worth
        int iconHealth = 0;

        // go through each icon in the list
        //we will do everything inside the vracks for each item in the list
        // for each step in the loop, we'll store the current 
        foreach (GameObject icon in healthIcons)
        {
            //Each icon is worth 1 more haelth than the last
            // so we get the current health add one to it
            // and store the result back into the iconHealth variable
            iconHealth = iconHealth + 1;

            // if the players current health is equal or greater 
            //than the health value for this icon
            if (player.GetHealth() >= iconHealth)
            {
                //then turn the icon ON
                icon.SetActive(true);
            }
            //Else
            //The players health is less than this icons value
            else
            {
                // turn the icon off
                icon.SetActive(false);
            }
        }
    }
}
