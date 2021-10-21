using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayCutsceneAfterTalk : MonoBehaviour
{
    public PlayableDirector dir;
 
    // Start is called before the first frame update
    
    // Update is called once per frame
    public void Update()
    {
        if(DialogueManager.playCutscene){
            dir.Play();
            DialogueManager.playCutscene = false;
        }
    }
}
