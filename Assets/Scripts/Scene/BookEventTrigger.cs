using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookEventTrigger : MonoBehaviour
{
    public GameObject btnInteract;
    // Start is called before the first frame update
   

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            btnInteract.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            btnInteract.SetActive(false);
        }
        
    }
}
