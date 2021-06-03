using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BushCounter : MonoBehaviour
{
    public string levelToLoad;
    public int startingCounter;
    int currentCounter;
    public GameObject bush;
    public AudioSource winSound;
    public AudioSource watered;
    //start the counter for the win state
    private void Awake()
    {
        currentCounter = startingCounter;
    }
    //Condition: when the collider hits a certain object type (water)
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //check if the object we collided with has the tag we are looking for(water)
        if (otherCollider.CompareTag("water"))
        {
            
            //Get the object assigned as bush's colider component and if it is enabled them
            if (bush.GetComponent<Collider2D>().enabled == true)
            {
                //increase the counter
                
                Destroy(bush.GetComponent<Collider2D>());
                currentCounter = currentCounter + 1;
                //Watered sound plays
                watered.Play();
                //The collider that causes the counter to go up gets destroyed
                
                
            }
            
        }
        // The counter = 5 then
        if (currentCounter == 5)
        {
            //win sound plays congrats gamer
            winSound.Play();
            //invokes Gamer
            //That's the scene change 
            Invoke("Gamer",2);
    
        }
    }
    void Gamer()
    {//Loads a scene
        SceneManager.LoadScene(levelToLoad);
    }
}
