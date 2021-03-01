using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Variables that will be used in Unity
    public string startText;


    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(startText);
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(startText);
    }
}
