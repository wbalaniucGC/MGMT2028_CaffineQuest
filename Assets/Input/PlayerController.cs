using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Rules for the event function.
    // 1. It must be "public"
    // 2. It must have a "void" return type
    // 3. It SHOULD have a proper function name (On_____) Ex: OnMove, OnJump, OnAttack
    // 4. It will pass in an InputAction.CallbackContent object

    // Some code that runs when Movement is triggered
    public void OnMove(InputAction.CallbackContext valueFromAction)
    {
        // joystickMovement is a Vector2 ==> (x, y)
        Vector2 joystickMovement = valueFromAction.ReadValue<Vector2>();
        Debug.Log(joystickMovement);

        // Get the velocity of your character
        // Apply the joystickMovement * movementSpeed to your character
        // ?????
        // Profit
        
    }

    // Some code that runs with Jump is pressed
    public void OnJump(InputAction.CallbackContext ctx)
    {
        Debug.Log("JUMP!");

        // Apply an impulse force to your character via the Rigidbody2D
    }

}
