using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bob : MonoBehaviour
{//Bob= Back.Over(to).(the)B(other)(scene)

    //pubs 
    public string levelToLoad;
    public AudioSource swoosh;
    //when clicking with the pointer
   public void OnPointerClick()
    {
        //plays swoosh audiosource
        swoosh.Play();
        //invokes the sceneChange function
        Invoke("sceneChange",1);
       


    }
    void sceneChange()
    {

        //changes scene
        SceneManager.LoadScene(levelToLoad);
    }
}

