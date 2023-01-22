using UnityEngine;
using UnityEngine.InputSystem;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    private Rigidbody rb;
    private Vector3 movementVector;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(movementVector * speed);
    }

    public void HandleMovement(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        movementVector = new Vector3(input.x, 0, input.y);
    }
}
