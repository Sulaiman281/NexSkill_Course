using StarterAssets;
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

        int randomLifeTime = Random.Range(10, 25);
        Destroy(gameObject, randomLifeTime);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        if (Vector3.Distance(PlaygroundManager.Instance.Player.transform.position, transform.position) < 5f)
        {
            targetPosition = PlaygroundManager.Instance.Player.transform.position;
        }
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

    // this method calculates distance between two vectors and check if it is less than 1f distance.
    private bool HasReachedDestination()
    {
        return Vector3.Distance(transform.position, targetPosition) < 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("obstacle hit! to the player give him damage.");
            // explosion effects etc.
            PlaygroundManager.Instance.currentEnemies--;
            PlaygroundManager.Instance.playerHitCounts++;
            if (PlaygroundManager.Instance.playerHitCounts >= 5)
            {
                Debug.Log("Player is dead!");
                Animator animator = other.GetComponent<Animator>();

                if (animator != null)
                {
                    animator.SetBool("Die", true);
                    ThirdPersonController controller = other.GetComponent<ThirdPersonController>();
                    controller.enabled = false;
                }

                PlaygroundManager.Instance.GameOver();

            }
            Destroy(gameObject);
            // CharacterController controller = other.GetComponent<CharacterController>();
            // if (controller != null)
            // {
            //     Debug.Log("Delta Time: "+Time.deltaTime);
            //     controller.Move(Vector3.up * 3f);
            // }

            // Animator animator = other.GetComponent<Animator>();

            // if (animator != null)
            // {
            //     animator.SetBool("Die", true);
            //     ThirdPersonController controller = other.GetComponent<ThirdPersonController>();

            //     controller.enabled = false;
            // }
        }
    }
}
