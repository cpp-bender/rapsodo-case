using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("DEPENDENCIES")]
    [SerializeField] PlayerMovementData movementData;

    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        float moveSpeed = movementData.MoveSpeed;
        float rotateSpeed = movementData.RotateSpeed;
        string horizontal = movementData.HorizontalInputName;
        string vertical = movementData.VerticalInputName;

        Vector3 oldPos = transform.position;
        Vector3 input = new Vector3(Input.GetAxis(horizontal), 0, Input.GetAxis(vertical));
        Quaternion lookRotation = input == Vector3.zero ? transform.rotation : Quaternion.LookRotation(input * rotateSpeed);
        body.Move((oldPos + input * moveSpeed), lookRotation);
    }
}
