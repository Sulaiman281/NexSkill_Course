using StarterAssets;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private ThirdPersonController playerController;
    [SerializeField] private float health = 100f;

    public bool IsDead => health <= 0;


    private void Start()
    {
        // player start with full health.
        health = 100f;
        playerController.enabled = true;
    }


    public void TakeDamage(float damage)
    {
        health -= damage;

        // if the health is less than or equal to 0 then player is dead.
        if (health <= 0)
        {
            // player is dead. so disable the playerController.
            playerController.enabled = false;
            Debug.Log("Player is dead.");
        }
    }
}
