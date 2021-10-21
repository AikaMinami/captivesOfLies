using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookInteract : MonoBehaviour
{
    public static bool isInteract;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isPlayerInteracting()
    {
        PlayerMovement.isTalking = true;
    }
}
