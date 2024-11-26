using UnityEngine;
using UnityEngine.Events;

public class CheckPoint : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform target; // target for which our checkpoint is made

    [Header("Settings")]
    [SerializeField] private string targetTagName; // target object tag name when it collider our checkpoint will invoke events

    [Header("Events")]
    public UnityEvent onCheckPointTriggered;
    public UnityEvent<Transform> interactionTarget;

    public UnityEvent onCheckPointExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTagName))
        {
            Debug.Log("CheckPoint Get Triggered!");
            onCheckPointTriggered.Invoke();
            if(target != null)
                interactionTarget.Invoke(target);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(targetTagName))
        {
            Debug.Log("CheckPoint Exit Triggered!");
            onCheckPointExit.Invoke();
        }
    }
}
