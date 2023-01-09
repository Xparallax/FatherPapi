using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public bool isGrounded;
    

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        isGrounded = IsGrounded();

      if (Input.GetButtonDown("Jump") && IsGrounded())
      {
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
      }
      //  if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f){
      //    rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
      //  }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.Raycast(groundCheck.position, Vector2.down, 0.2f, 1 << groundLayer.value);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
