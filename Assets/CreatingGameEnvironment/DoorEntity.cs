using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEntity : MonoBehaviour
{
    [Header("Door Settings")]
    [SerializeField] private float doorOpenAtYAxis = 100f;
    [SerializeField] private float doorCloseAtYAxis = 180f;

#if UNITY_EDITOR

    [Header("Debug Settings")]
    [SerializeField] private bool isDoorOpen = false;

    private void OnValidate()
    {
        if (isDoorOpen)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
    }

#endif


    public void OpenDoor()
    {
        transform.localRotation = Quaternion.Euler(0, doorOpenAtYAxis, 0);
    }

    public void CloseDoor()
    {
        transform.localRotation = Quaternion.Euler(0, doorCloseAtYAxis, 0);
    }
}
