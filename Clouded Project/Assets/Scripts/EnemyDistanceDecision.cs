using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistanceDecision : MonoBehaviour
{
    // Public the ones you can edit
    public float distanceForDecision;
    public Transform target;
    public AudioSource grumble;
    //privvy
    private EnemyPatrol patrolBehaviour;
    private EnemyChase chaseBehaviour; 


    // When the object first loads
    void Awake()
    {
        patrolBehaviour = GetComponent<EnemyPatrol>();
        chaseBehaviour = GetComponent<EnemyChase>();

        chaseBehaviour.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       

        //How far are we from our target?
        float distance = ((Vector2)target.position - (Vector2)transform.position).magnitude;
       
        //IF we are closer to our target than our mininum distance
        if (distance <= distanceForDecision)
        {
            // Disable patrol and enable chasing
            patrolBehaviour.enabled = false;
            chaseBehaviour.enabled = true;
            grumble.enabled = true;
           
        }
        else
        {
            patrolBehaviour.enabled = true;
            chaseBehaviour.enabled = false;
            grumble.enabled = false;
        }

      


    }
}
