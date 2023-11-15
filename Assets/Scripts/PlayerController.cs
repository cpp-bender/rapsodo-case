using UnityEngine;

public class PlayerController : MonoBehaviour
{
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
        float moveSpeed = .1f;
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed;
        Vector3 oldPos = transform.position;
        body.Move(oldPos + input, Quaternion.LookRotation(input));
    }
}
