using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private CharacterController characterController;

    [Header("Player Settings")]
    [SerializeField] private float horizontalLimit = 2.35f;
    [SerializeField] private float jumpHeight = 2f;

#if UNITY_EDITOR

    [Header("Debug Settings")]
    [SerializeField] private Vector2 inputDirection;
    private void OnGUI()
    {
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 20;

        if (GUILayout.Button("SwipeLeft", buttonStyle))
        {
            Move(new Vector2(-1, 0).normalized);
        }

        if (GUILayout.Button("SwipeRight", buttonStyle))
        {
            Move(new Vector2(1, 0).normalized);
        }

        if (GUILayout.Button("SwipeUp", buttonStyle))
        {
            Move(new Vector2(0, 1).normalized);
        }
    }


#endif

    public void Move(Vector2 direction)
    {
        if (IsPlayerOutOfBound(direction.x) == false)
        {
            float xMove = direction.x * horizontalLimit;
            characterController.Move(new Vector3(xMove, 0, 0));
        }

        if (direction.y > 0)
        {
            var jumpForce = jumpHeight * direction.y;
            characterController.Move(new Vector3(0, jumpForce, 0));
        }
    }

    private bool IsLeftBound()
    {
        return characterController.transform.position.x <= -horizontalLimit;
    }

    private bool IsRightBound()
    {
        return characterController.transform.position.x >= horizontalLimit;
    }

    public bool IsPlayerOutOfBound(float xInput)
    {
        return xInput < 0 ? IsLeftBound() : IsRightBound();
    }
}