using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    //variabubs of the public kind
    // exposed (ohno) for editing in the UNITY editor
    public float forceStrength;
    //Get Vectored loser -o-o 
    public Vector2 direction; // what direction the enemy will move in

    //Private Investigator varnbubbles
    // Used for tracking data while the game is running
    private Rigidbody2D ourRigidBody; // the container for teh rigid body
                                      // attached to this object

    // awake is called when the script is loaded
    void Awake()
    {
        // get and store the rigid body used for movement
        ourRigidBody = GetComponent<Rigidbody2D>();

        
        //normalise our direction
        //normalise changes it to be length1, so we can multiply
        // it by our speed/ force later
        direction = direction.normalized;
        
        

    }

    public void Update()
    {
        //Comrade/Workforce/Direction/x/Forcestrength
        ourRigidBody.AddForce(direction * forceStrength);
    }
}