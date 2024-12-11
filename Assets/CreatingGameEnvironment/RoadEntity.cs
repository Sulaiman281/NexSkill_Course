using UnityEngine;

public class RoadEntity : MonoBehaviour
{
    [Header("Road Settings")]
    [SerializeField] private float roadSpeed = 5f;
    [SerializeField] private float roadLength = 15;
    public RoadEntity previousRoad;

    public void Initialize(RoadEntity previousRoad)
    {
        this.previousRoad = previousRoad;
        transform.position = new Vector3(0, 0, previousRoad.transform.position.z + roadLength);
    }

    private void Update()
    {
        transform.Translate(Vector3.back * roadSpeed * Time.deltaTime);

        if (transform.position.z < -100)
        {
            Destroy(gameObject);
        }
    }
}
