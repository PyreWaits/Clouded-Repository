using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // public vabubs
    public float forceStrength; // how fast we move
    public Vector2[] patrolPoints; // patrol points we will move to
    public float stopDistance; //How close we get before moving to the next patrol point

    //privs varimbless
    private Rigidbody2D ourRigidBody;// is body that is rigid for object
    private int currentPoint = 0; // index of teh current point we are moving too
    // Start is called before the first frame update
    void Awake()
    {
        ourRigidBody = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        // How far are we from our target?
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;
        // if we are closer to our target than our mininum distance
        if (distance <= stopDistance)
        {
            // the update to the next target
            currentPoint = currentPoint + 1;

            // if we've gone past the end of our list 
            //if our current point is equal or bigger than
            // the length of our list
            if (currentPoint >= patrolPoints.Length)
            {
                // Loop back to the start by setting current index to 0
                currentPoint = 0;
            }

        }





        //MOVE IN direction of our target

        //get the direction we should move in
        // subtracting the current position from the target posistion
        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;

        ourRigidBody.AddForce(direction * forceStrength);
    }
}
