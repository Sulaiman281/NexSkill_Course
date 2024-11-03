using UnityEngine;

public class PlayerLookAt : MonoBehaviour
{
    [SerializeField] private Transform target;

    void Update()
    {
        if (target == null) return; // Don't do anything if target is null 

        transform.LookAt(target.position);
    }
}
