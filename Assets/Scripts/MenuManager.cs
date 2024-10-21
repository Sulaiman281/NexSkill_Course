using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // we need our inputField to store the player's name
    [SerializeField] private TMP_InputField playerName_InputField;

    [SerializeField] private GameObject error_msg;
    [SerializeField] private GameObject loading_panel;

    private void Awake()
    {
        // we will hide the error message at the beginning
        error_msg.SetActive(false);
        loading_panel.SetActive(false);
    }


    // this method will be called when the player clicks on the "Start" button
    public void StartGame()
    {
        // if the player's name is empty, we will not start the game
        if (string.IsNullOrEmpty(playerName_InputField.text))
        {
            Debug.Log("Please enter your name");
            error_msg.SetActive(true);
            Invoke(nameof(HideErrorMsg), 3.5f);
            return;
        }

        Debug.Log("Player's name: " + playerName_InputField.text + " - Starting the game...");
        loading_panel.SetActive(true);
        Invoke(nameof(ChangeSceneToGame), 2f);
    }

    private void HideErrorMsg()
    {
        error_msg.SetActive(false);
    }

    private void ChangeSceneToGame()
    {
        // we will change the scene to the game scene
        SceneManager.LoadScene(1);
    }

}
