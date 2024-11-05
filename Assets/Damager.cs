using UnityEngine;

public class Damager : MonoBehaviour
{
    public float damage = 10f;


    private void OnTriggerStay(Collider other)
    {
        // if the other object has the health component then we damage the other object.

        if (other.TryGetComponent(out PlayerHealth playerHealth))
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
