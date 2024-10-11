using UnityEngine;

public class BallGame : MonoBehaviour
{
    public float speed = 10;
    public Vector3 forceDirection;
    public Rigidbody ballRb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ballRb.AddForce(forceDirection * speed, ForceMode.Impulse);
        }
    }
}
