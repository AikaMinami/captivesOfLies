using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlace : MonoBehaviour
{
    public string roomDestination;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            SceneManager.LoadScene(roomDestination);
        }
    }

    public void GO_TO_ANOTHER_SCENE(string sceneName)
    {
            SceneManager.LoadScene(sceneName);
    }
}
