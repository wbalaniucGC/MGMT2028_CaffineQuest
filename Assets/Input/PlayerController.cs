using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Public variables
    public float movementSpeed = 5.0f;
    public float jumpForce = 10.0f;

    // Private variables
    private Vector2 joystickMovement;
    private bool isFacingRight;
    private bool isOnGround;

    // Component References
    private Animator anim;
    private Rigidbody2D rbody;

    private void Start()
    {
        joystickMovement = Vector2.zero;
        isFacingRight = true;
        isOnGround = false;

        // Component References
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Move my character around
        rbody.linearVelocityX = joystickMovement.x * movementSpeed;
    }

    // Some code that runs when Movement is triggered
    public void OnMove(InputAction.CallbackContext valueFromAction)
    {
        // joystickMovement is a Vector2 ==> (x, y)
        joystickMovement = valueFromAction.ReadValue<Vector2>();

        // Flip my character object around
        // If my character is facing right AND wants to move left, flip!
        if((isFacingRight && joystickMovement.x < 0) || (!isFacingRight && joystickMovement.x > 0))
        {
            FlipGameObject();
        }

        // Set animator values
        anim.SetFloat("SpeedX", Mathf.Abs(joystickMovement.x));
    }

    // Some code that runs with Jump is pressed
    public void OnJump(InputAction.CallbackContext ctx)
    {
        // Debug.Log("JUMP!");

        // If i'm on the ground, I'm allowed to jump!
        if (isOnGround)
        {
            rbody.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FlipGameObject()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1; // <-- Shorthanded version of scale.x = scale.x * -1;
        transform.localScale = scale;

        // Set the isFacingRight boolean to it's opposite
        isFacingRight = !isFacingRight;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.CompareTag("Ground"))
        {
            // I'm on the ground!
            isOnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            // I'm off the ground!
            isOnGround = false;
        }
    }
}
