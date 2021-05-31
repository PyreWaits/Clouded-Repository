using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBackForthReallyFast : MonoBehaviour
{
    //variabubs of the public kind
    // exposed (ohno) for editing in the UNITY editor
    public float forceStrength;

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

        //Get Vectored loser -o-o 
        //normalise our direction
        //normalise changes it to be length1, so we can multiply
        // it by our speed/ force NOW!
        direction = direction.normalized;
        //Here is where the magic happens
        ourRigidBody.AddForce(direction * forceStrength);

        //gets the reverse void with a 2 second counter
        Invoke("reverse", 2);
    }


    //is called during the awake function.
    void reverse()
    {   //reverses the direction 
        ourRigidBody.AddForce(-direction *forceStrength);
        //it's in the name
        Invoke("VROOM", 2);
    }
    //goes fast
    void VROOM()
    {
        //makes the direction * force strength but fast
        ourRigidBody.AddForce(direction * forceStrength);
        //self created infinite loop of speed
        Invoke("reverse", 2);
    }
}
