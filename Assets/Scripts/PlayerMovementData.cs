using UnityEngine;

[CreateAssetMenu(menuName = "Maze 3D/Player Movement Data ", fileName = "Player Movement Data")]
public class PlayerMovementData : ScriptableObject
{
    [SerializeField, Range(0f, 1f)] float moveSpeed = .5f;
    [SerializeField, Range(0f, 1f)] float rotateSpeed = .5f;
    [SerializeField] string horizontalInputName = "Horizontal";
    [SerializeField] string verticalInputName = "Vertical";

    public float MoveSpeed { get => moveSpeed; }
    public float RotateSpeed { get => rotateSpeed; }
    public string HorizontalInputName { get => horizontalInputName; }
    public string VerticalInputName { get => verticalInputName; }
}
