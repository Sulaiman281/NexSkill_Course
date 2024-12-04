using UnityEngine;

public class DetectEntity : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LevelManager.Instance.ReachAtTop();
        }
    }
}
