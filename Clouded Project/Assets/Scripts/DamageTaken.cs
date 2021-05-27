using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTaken : MonoBehaviour
{
    public int hurt;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collisionData)
     {


        //get the object we collided with
        Collider2D objectWeCollidedWith = collisionData.collider;
        Animator ourAnimator = GetComponent<Animator>();
        //Sets the animator "currentHealth" to the currentHealth. Yes. IT ACTUALLY WORKED. NICE. 
        ourAnimator.SetInteger("hurt", hurt);
        // Update is called once per frame
    }
}
