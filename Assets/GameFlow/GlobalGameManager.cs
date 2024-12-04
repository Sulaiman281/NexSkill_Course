using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalGameManager : MonoBehaviour
{
    public static GlobalGameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        // This will make sure that the GlobalGameManager is not destroyed when a new scene is loaded
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        LoadScene("Menu");
    }

    public void LoadScene(string sceneName)
    {
        // SceneManager.LoadScene(sceneName);
        StartCoroutine(LoadSceneAsync(sceneName));
    }


    private IEnumerator LoadSceneAsync(string sceneName)
    {
        var operation = SceneManager.LoadSceneAsync(sceneName);

        while (!operation.isDone)
        {
            // This will give you the progress of the loading
            Debug.Log(operation.progress);
            yield return null;
        }

        // find ILoaders
        var loaders = FindObjectsOfType<MonoBehaviour>().OfType<ILoader>();

        foreach (var loader in loaders)
        {
            yield return loader.SceneLoad();
        }
    }
}
