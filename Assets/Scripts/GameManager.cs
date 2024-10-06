using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnGUI()
    {
        // Display time properties
        GUILayout.Label("Time: " + Time.time);
        GUILayout.Label("Delta Time: " + Time.deltaTime);
        GUILayout.Label("Fixed Delta Time: " + Time.fixedDeltaTime);
        GUILayout.Label("Unscaled Time: " + Time.unscaledTime);
        GUILayout.Label("Real Time Since Startup: " + Time.realtimeSinceStartup);
    }
}