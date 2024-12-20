using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] Rigidbody2D body;
    [SerializeField] const int SPEED = 10;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] bool jumpPressed = false;
    [SerializeField] float jumpForce = 500.0f;
    [SerializeField] bool isGrounded = true;
    public coinManager cm;

    // Start is called before the first frame update
    void Start()
    {
        if (body == null)
            body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame --used for user input
    //do NOT use for physics & movement
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") )
            jumpPressed = true;
    }

    //called potentially many times per frame
    //use for physics & movement
    private void FixedUpdate()
    {
        body.velocity = new Vector2(SPEED * movement, body.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();
        if (jumpPressed && isGrounded)
            Jump();
        else
            jumpPressed = false;


    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, 0);
        body.AddForce(new Vector2(0, jumpForce));
        Debug.Log("jumped");
        jumpPressed = false;
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag +" and " +collision.gameObject.name);
        if (collision.gameObject.tag == "Ground")
            isGrounded = true;
        else
        {
            Debug.Log("Collided with an object not tagged as Ground: " + collision.gameObject.tag);
        }
           
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            cm.CoinCount++;
        }
    }
       
}
