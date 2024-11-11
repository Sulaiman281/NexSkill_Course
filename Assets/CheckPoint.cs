using UnityEngine;
using UnityEngine.Events;

public class CheckPoint : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private string targetTagName;

    [Header("Events")]
    public UnityEvent onCheckPointTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTagName))
        {
            Debug.Log("CheckPoint Get Triggered!");
            onCheckPointTriggered.Invoke();
        }
    }
}
