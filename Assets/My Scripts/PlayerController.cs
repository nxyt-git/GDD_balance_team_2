using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Siła z jaką kula przyspiesza.")]
    public float acceleration = 25.0f;
    private Rigidbody rb;
    private PlayerLevelProgress playerProgress;

    [Tooltip("Maksymalna prędkość kuli.")]
    public float MaxSpeed => playerProgress.EnergyLevel == playerProgress.MaxEnergyLevel ? 25f : 10f;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerProgress = GetComponent<PlayerLevelProgress>();

        rb.linearDamping = 2.5f;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void FixedUpdate()
    {
        if (Keyboard.current == null) return;

        Vector2 moveInput = Vector2.zero;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveInput.y = 1f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveInput.y = -1f;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveInput.x = -1f;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveInput.x = 1f;

        Vector3 localMovement = new Vector3(moveInput.x, 0.0f, moveInput.y).normalized;

        Vector3 worldMovement = transform.TransformDirection(localMovement);

        rb.AddForce(worldMovement * acceleration, ForceMode.Acceleration);

        if (rb.linearVelocity.magnitude > MaxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * MaxSpeed;
        }
    }
}