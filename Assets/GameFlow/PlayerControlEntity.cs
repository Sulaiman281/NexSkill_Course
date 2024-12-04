using UnityEngine;

public class PlayerControlEntity : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    public void OnUserInput(Vector2 direction)
    {
        Debug.Log("Direction: " + direction);
        var move = new Vector3(direction.x, direction.y, 0);
        rb.AddForce(move * speed);
    }

    public void AddForce(Vector3 force)
    {
        rb.AddForce(force, ForceMode.Impulse);
    }

    public void Stop()
    {
        rb.velocity = Vector3.zero;
    }
}
