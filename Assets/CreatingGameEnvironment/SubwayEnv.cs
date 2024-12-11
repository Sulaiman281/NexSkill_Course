using UnityEngine;

public class SubwayEnv : MonoBehaviour
{
    [Header("Env Settings")]
    [SerializeField] private RoadEntity[] roadsPrefab;
    [SerializeField] private float roadLength = 15f;
    [SerializeField] private int minRoads = 10;
    [SerializeField] private float previousRoadZPositionToSpawn = 20;

    private RoadEntity _previousRoad;

    private void Start()
    {
        for (int i = 0; i < minRoads; i++)
        {
            SpawnRoad();
        }
    }

    private void Update()
    {
        if (IsPreviousRoadIsCloseToPlayer())
        {
            SpawnRoad();
        }
    }

    public void SpawnRoad()
    {
        if (roadsPrefab.Length == 0)
        {
            Debug.LogError("No Roads Found");
            return;
        }

        RoadEntity road = Instantiate(GetRandomRoad(), transform);

        if (_previousRoad != null)
        {
            road.Initialize(_previousRoad);
        }
        else
        {
            road.transform.position = new Vector3(0, 0, 0);
        }

        _previousRoad = road;

    }


    private RoadEntity GetRandomRoad()
    {
        return roadsPrefab[Random.Range(0, roadsPrefab.Length)];
    }

    public bool IsPreviousRoadIsCloseToPlayer()
    {
        if (_previousRoad == null)
        {
            return false;
        }
        return _previousRoad.transform.position.z < previousRoadZPositionToSpawn;
    }

}
