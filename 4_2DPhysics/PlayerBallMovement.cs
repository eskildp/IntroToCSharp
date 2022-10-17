using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBallMovement : MonoBehaviour
{
    public float RotationIncrease;
    public float MaxRotationSpeed;

    public float JumpForce;

    private Rigidbody2D rb;

    private float horizontalInput;

    private bool input;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Gets a reference to the players Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal"); // Gets horizontal input

        // Sets input to true if horizontalInput doesn't equal zero, and false if it does
        if (horizontalInput != 0)
        {
            input = true;
        }
        else
        {
            input = false;
        }

        // Checks if rotation speed is more than max
        if(rb.angularVelocity > MaxRotationSpeed)
        {
            rb.angularVelocity = MaxRotationSpeed; //Caps rotation speed
        }

        // Checks if rotation speed is less than minimum
        if (rb.angularVelocity < -MaxRotationSpeed)
        {
            rb.angularVelocity = -MaxRotationSpeed; //Caps rotation speed
        }

        // Checks if player presses space & if player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, 0);
        }
    }

    // FixedUpdate() is used when updating physics (per frame)
    // So when using Rigidbody.AddForce() or Rigidbody.AddTorque()
    void FixedUpdate()
    {
        //Only adds torque if the player is giving input
        if(input == true)
        {
            rb.AddTorque(-horizontalInput * Time.fixedDeltaTime * RotationIncrease);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
