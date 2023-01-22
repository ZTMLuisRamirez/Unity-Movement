using UnityEngine;
using UnityEngine.InputSystem;

public class TransformMovement : MonoBehaviour
{
    [SerializeField] private int speed = 8;
    private Vector3 movementVector;

    private void Update()
    {
        transform.Translate(movementVector * Time.deltaTime * speed);
    }

    public void HandleMovement(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        movementVector = new Vector3(input.x, 0, input.y);
    }
}
