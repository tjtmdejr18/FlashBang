using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    public float filp;
    public Transform groundCheck;
    public LayerMask whatIsGround;

    Hook hook;
    private Rigidbody2D rb;
    public float horizontalInput;
    public bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hook = GetComponent<Hook>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        Move();
        CheckGround();
        Filp();
    }

    void Filp()
    {
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            filp = 1f;
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            filp = -1f;
        }
        else if (horizontalInput == 0)
            transform.localScale = new Vector3(filp, 1f, 1f);
    }

    void Move()
    {
        if (hook.isAttach)
        {
            Vector2 movement = new Vector2(horizontalInput * moveSpeed, 0);
            rb.AddForce(movement);
        }
        else
        {
            Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
            rb.velocity = movement;
        }
        
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void CheckGround()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, whatIsGround);
    }
}

