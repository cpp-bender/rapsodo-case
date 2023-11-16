using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [Header("DEPENDENCIES")]
    [SerializeField] PlayerMovementData movementData;
    [SerializeField] RunnerCameraController cameraController;

    private Rigidbody body;
    private Vector3 oldPos = Vector3.zero;
    private Quaternion oldRot = Quaternion.identity;  

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        cameraController.SetTarget(gameObject);
        cameraController.SetState(RunnerCameraState.FOLLOW);
    }

    private void Update()
    {
        oldPos = transform.position;
        oldRot = transform.rotation;
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

        double horizontalValue = Math.Round(Input.GetAxis(horizontal), 2);
        double verticalValue = Math.Round(Input.GetAxis(vertical), 2);

        Vector3 input = new Vector3((float)horizontalValue, 0, (float)verticalValue);
        Quaternion lookRotation = input == Vector3.zero ? oldRot : Quaternion.LookRotation(input * rotateSpeed);
        body.Move((oldPos + input * moveSpeed), lookRotation);
    }
}
