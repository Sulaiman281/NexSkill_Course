using System.Collections;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour, ILoader
{
    public static LevelManager Instance;

    [SerializeField] private TMP_Text screen_msg;

    [SerializeField] private PlayerSwipeInput playerSwipeInput;
    [SerializeField] private PlayerControlEntity playerControl;

    public bool reachAtTop;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public IEnumerator SceneLoad()
    {
        reachAtTop = false;
        playerSwipeInput.OnSwipe.RemoveAllListeners();

        for (int i = 1; i <= 3; i++)
        {
            screen_msg.text = "Count Down " + i;
            yield return new WaitForSeconds(1);
        }
        screen_msg.text = "Start!";
        yield return new WaitForSeconds(2);
        screen_msg.text = "";
        playerSwipeInput.OnSwipe.AddListener(playerControl.OnUserInput);
    }

    public void ReachAtTop()
    {
        reachAtTop = true;
        screen_msg.text = "You Win!";
        playerSwipeInput.OnSwipe.RemoveAllListeners();
        playerControl.Stop();

        StartCoroutine(GameOver());
    }

    private IEnumerator GameOver()
    {
        yield return new WaitForSeconds(5);
        GlobalGameManager.Instance.LoadScene("GameOver");
    }
}
