using UnityEngine;

public class BallControl : MonoBehaviour
{
    // [Header("Ball Control")]
    // [SerializeField] private float speed = 10f;

    [SerializeField] private Rigidbody rb;

    public void OnUserInput(Vector2 direction, float speed)
    {
        var direction3D = new Vector3(direction.x, 0, direction.y);
        rb.AddForce(direction3D * speed, ForceMode.Impulse);
    }
}
