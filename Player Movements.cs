using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    //var

    public float speed = 6f;
    public float jumpspeed = 15f;
    private bool isGround = true;

    //ref

    Rigidbody2D rb;

    //start

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    //start

    void Update()
    {

        Move();
        Jump();


    }

    //fixedupdates

    void FixedUpdate()
    {

        

    }

    //move left right

    private void Move()
    {
        float move = 0;
        if (Keyboard.current.dKey.isPressed)
        {
            move = 1;
            
        }
        if (Keyboard.current.aKey.isPressed)
        {
            move = -1;
            
        }
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    }

    // jump up


    private void Jump()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isGround)
        {
         
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpspeed);
        }
    }

    //ground check
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }


}
