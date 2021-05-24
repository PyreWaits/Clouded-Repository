using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Will track and follow the target
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        //Will keep tracking the object while the object is not null
        if(target != null)
        {
            //Transforms the position of the object with the script to the target
            transform.position = target.position;
        }
        
    }
}
