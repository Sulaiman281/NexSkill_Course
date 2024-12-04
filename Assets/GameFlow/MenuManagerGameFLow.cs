using System.Collections;
using TMPro;
using UnityEngine;

public class MenuManagerGameFLow : MonoBehaviour, ILoader
{
    [SerializeField] private TMP_Text msg;

    public IEnumerator SceneLoad()
    {
        msg.text = "Loading...";
        yield return new WaitForSeconds(5);
        msg.text = "Loaded!";
    }

    public void PlayGame()
    {
        GlobalGameManager.Instance.LoadScene("Game");
    }
}
