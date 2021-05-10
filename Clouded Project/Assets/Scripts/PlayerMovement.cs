using UnityEngine;

// This script assumes the player will have a Rigidbody2D attached
// and it won't work without it
// This line enforces that the object have a Rigidbody2D in the 
// Unity editor
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{

    // ------------------------------------------------
    // Public variables, visible in Unity Inspector
    // Use these for settings for your script
    // that can be changed easily
    // ------------------------------------------------

    // This variable will hold the strength of the force
    // propelling us toward our target
    // (ie our speed)
    public float forceStrength;


// This variable will determine how close we get to 
// the target point before stopping
public float stopDistance;

    // ------------------------------------------------
    // Private variables, NOT visible in the Inspector
    // Use these for tracking data while the game
    // is running
    // ------------------------------------------------

    // This variable will hold the last point we touched
    // so we can keep moving to that point even after we
    // stop touching the screen
    private Vector2 targetPoint;

    // This variable will store the attached RigidBody 
    // so we can use it to move
    Rigidbody2D ourRigidbody;

    // This variable will hold the audio source
    AudioSource ourAudioSource;

    // ------------------------------------------------
    // Awake is called when the script is loaded
    // ------------------------------------------------
    void Awake()
    {

        // Get the rigidbody that we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();

        // Get audio when game starts
        ourAudioSource = GetComponent<AudioSource>();

        // Set our target point to be our current position
        // so we don't start moving right away
        targetPoint = transform.position;
    }

    // ------------------------------------------------
    // Update is called once per frame
    // ------------------------------------------------
    public void Update()
    {

        // Find out from the rigidbody what our current horizontal and vertical speeds are
        float currentSpeed = ourRigidbody.velocity.magnitude;

        // Get the animator that we'll be using for movement
        Animator ourAnimator = GetComponent<Animator>();

        // Tell our animator what the speeds are
        ourAnimator.SetFloat("speed", currentSpeed);
        // If the mouse button is down or touch is detected...
        if (Input.GetMouseButton(0))
        {
            // Record the mouse / touch position as our target
            // Do this by using the camera to convert from screen 
            // coordinates to game world coordinates
            targetPoint = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        // How far away are we from the target?
        float distance = (targetPoint - (Vector2)transform.position).magnitude;

        // If we are farther away from our target than our minimum distance...
        if (distance > stopDistance)
        {
            // ... Move in the direction of our target

            // Get the direction
            // Subtract the current position from the target position to get a distance vector
            // Normalise changes it to be length 1, so we can then multiply it by our speed / force
            Vector2 direction = (targetPoint - (Vector2)transform.position).normalized;

            // Move in the correct direction with the set force strength
            ourRigidbody.AddForce(direction * forceStrength);


            // Audiosource when moving
            if (!ourAudioSource.isPlaying)
                ourAudioSource.Play();
        }
        else
        {
            ourAudioSource.Stop();
        }
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    // Public Variables, Visible in unity inspector
    public float forceStrength;

    public void MoveLeft()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Move in the correct Direction with the set force strength
        ourRigidbody.AddForce(Vector2.left * forceStrength);
    }
    public void MoveRight()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Move in the correct Direction with the set force strength
        ourRigidbody.AddForce(Vector2.right * forceStrength);

    }

}
*/