using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
   
    public Transform target;
    // Update is called once per frame
    void Start()
    {
        transform.position = target.position;
        
    }
}
