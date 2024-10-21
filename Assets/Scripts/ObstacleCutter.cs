using UnityEngine;

public class ObstacleCutter : MonoBehaviour
{
    [Header("References")]
    public Rigidbody rb;
    public GameObject fanObject;

    [Header("Settings")]
    public float fanSpeed = 1000f;
    public float moveSpeed = 10f;
    public float moveRadius = 10f;

    private Vector3 targetPosition = Vector3.zero;

    private void Start()
    {
        GetRandomMoveDirection();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (HasReachedDestination())
        {
            GetRandomMoveDirection();
        }

        // formula to calculate the direction to move.
        Vector3 direction = (targetPosition - transform.position).normalized;

        // rigidbody.AddForce(direction * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);

        rb.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);

        // rotate fan on y-axis
        fanObject.transform.Rotate(Vector3.up, fanSpeed * Time.deltaTime);
    }



    private void GetRandomMoveDirection()
    {
        targetPosition = new Vector3(Random.Range(-moveRadius, moveRadius), 0, Random.Range(-moveRadius, moveRadius));
    }

    private bool HasReachedDestination()
    {
        return Vector3.Distance(transform.position, targetPosition) < 1f;
    }
}
