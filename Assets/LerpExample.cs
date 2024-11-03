using UnityEngine;

public class LerpExample : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform target;
    public float lerpTime = 0.5f;
    private float t = 0.0f;

    void Update()
    {
        t += Time.deltaTime / lerpTime;
        target.position = Vector3.Lerp(pointA.position, pointB.position, t);
        if (t > 1) t = 0; // Reset for looping effect
    }
}
