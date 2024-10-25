using UnityEngine;

public class CoinPickable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin picked up!");
            PlaygroundManager.Instance.PickCoin();
            Destroy(gameObject);
        }
    }
}
