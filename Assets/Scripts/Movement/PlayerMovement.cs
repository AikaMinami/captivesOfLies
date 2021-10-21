using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb2D;
    Vector2 movement;
    public static bool isTalking;

    public Animator animator;
    // Start is called before the first frame update

    void Start(){
        if(!isTalking){
        rb2D = GetComponent<Rigidbody2D>();
        movement = new Vector2();
        movementSpeed = 5f;
        } else {
            movementSpeed = 0f;
            return;
        }
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    public void MoveUp()
    {
        movement.y = 1;
    }
    public void MoveDown()
    {
        movement.y = -1;
    }
    public void MoveLeft()
    {
        movement.x = -1;
    }
    public void MoveRight()
    {
        movement.x = 1;
    }
    private void FixedUpdate() {
        // rb2D.MovePosition(rb2D.position + movement * movementSpeed);   
        rb2D.MovePosition(rb2D.position + movement * movementSpeed * Time.fixedDeltaTime);   
    }
}
