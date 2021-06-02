using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDisplay : MonoBehaviour
{
    // This will contain a list of game objects for the water icons
    // public - shown in unity
    // [] indicates an array (list)
    // GameObject [] will contain GameObjects
    public GameObject[] waterIcons;

    //will contain PlayerHealth component that is on the player game object
    // so we can ask it for info about the water the player has
    PlayerFire player;


    // Start is called before the first frame update
    void Start()
    {
        // search the scene for the object with PlayerFire attached 
        // Store the PlayerFire component from that object in out playerFire variable.
        player = FindObjectOfType<PlayerFire>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a variable to keep track of which item in the list we are on
        // and how much that icon is worth
        int iconWater = 0;

        // go through each icon in the list
        //we will do everything inside the vracks for each item in the list
        // for each step in the loop, we'll store the current 
        foreach (GameObject icon in waterIcons)
        {
            //Each icon is worth 1 more haelth than the last
            // so we get the currentWater add one to it
            // and store the result back into the iconWater variable
            iconWater = iconWater + 1;

            // if the players currentwater is equal or greater 
            //than the Water value for this icon
            if (player.GetWater() >= iconWater)
            {
                //then turn the icon ON
                icon.SetActive(true);
            }
            //Else
            //The players water is less than this icons value
            else
            {
                // turn the icon off
                icon.SetActive(false);
            }
        }
    }
}
