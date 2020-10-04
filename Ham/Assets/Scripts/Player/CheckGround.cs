﻿using UnityEngine;

public class CheckGround : MonoBehaviour
{

    #region PublicStuff
    public Transform detectPos;
    public float circleRadius;
    public float maxJumpCount;
    public LayerMask ground;
    public float jumpForce;

    #endregion

    #region PrivateStuff
    bool canJump;
    float currentJumpCount;
    Rigidbody2D rb;
    #endregion

    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();   
        currentJumpCount = maxJumpCount; 
    }
    private void Update() 
    {
        canJump = Physics2D.OverlapCircle(detectPos.position,circleRadius,ground);
        if(canJump)
        {
            currentJumpCount = maxJumpCount;
        }
        if(Input.GetKeyDown(KeyCode.Space) && currentJumpCount > 0)
        {
            Jump();
        }  
    }
    public void Jump()
    {
        rb.velocity = transform.up * jumpForce * 10 * Time.fixedDeltaTime ;
        currentJumpCount --;
    }
    #region Methods
    #endregion
}