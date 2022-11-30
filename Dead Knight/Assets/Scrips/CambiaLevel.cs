using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiaLevel : MonoBehaviour
{
    public int sceneNext;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        if(other.tag == "Player")
        {
            print("Switching Scene to" + sceneNext);
            SceneManager.LoadScene(sceneNext, LoadSceneMode.Single);
        }
    }
}
