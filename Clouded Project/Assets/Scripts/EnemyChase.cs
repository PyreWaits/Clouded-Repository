using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    //public
    public float forceStrength; // how fast we move
    public Transform target; // the thing you want to chase
    
    // private
    private Rigidbody2D ourRigidBody; // the body attached to this object

    // Awake is called when the script first loads
    void Awake()
    {
        // get the rigidbody that we'll be using for movement
        ourRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move in the driection of our target
        //Get the direction (as in enemy patrol)
        Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

        // Move in the correct direction with the set force strength
        ourRigidBody.AddForce(direction * forceStrength);
        
    }
}
