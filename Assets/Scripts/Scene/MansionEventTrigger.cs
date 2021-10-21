using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MansionEventTrigger : MonoBehaviour
{
    public GameObject closingPanel;
    public PlayableDirector director;
 

    private void OnTriggerEnter2D(Collider2D other) {
        closingPanel.SetActive(false);
        director.Play();
    }
}
