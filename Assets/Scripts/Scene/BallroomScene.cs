using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallroomScene : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("isOpen", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
