using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public bool isDashOn;
    public float dashSpeed = 10f;

    public float horizontal;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        horizontal = GetComponent<JumpMovement>().horizontalInput;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = GetComponent<JumpMovement>().horizontalInput;
        Dash();
    }

    void Dash()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Vector2 dash = new Vector2(10 * dashSpeed, rb.velocity.y);
            rb.AddForce(dash * horizontal, ForceMode2D.Impulse);
            isDashOn = false;
        }
    }
}
