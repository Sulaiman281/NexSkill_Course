using System.Collections;
using StarterAssets;
using TMPro;
using UnityEngine;

public class PlaygroundManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab; // enemy prefab
    [SerializeField] private Transform enemiesParent;

    [SerializeField] private TMP_Text cointCountText;
    [SerializeField] private GameObject countDownPanel;
    [SerializeField] private TMP_Text countDownText;
    [SerializeField] private GameObject gameOverPanel;

    public static PlaygroundManager Instance { get; private set; }


    public float spawnInterval = 2f;
    public int maxEnemies = 5;

    public int currentEnemies = 0;
    private float _spawnTimer = 0f;

    public GameObject Player { get; private set; }
    public int collectedCoins = 0;

    private bool _isGameStarted = false;

    public int playerHitCounts;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Player = GameObject.FindWithTag("Player");
    }

    void Start()
    {
        playerHitCounts = 0;
        collectedCoins = 0;
        cointCountText.text = $"Coins: {collectedCoins}";
        countDownPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        StartCoroutine(CountDownCoroutine(3));
    }

    private void Update()
    {
        if (!_isGameStarted)
        {
            return;
        }
        if (currentEnemies < maxEnemies)
        {
            _spawnTimer += Time.deltaTime;

            if (_spawnTimer >= spawnInterval)
            {
                SpawnEnemy();
                _spawnTimer = 0f;
            }
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(obstaclePrefab, enemiesParent);
        currentEnemies++;
    }

    private IEnumerator CountDownCoroutine(int countDown)
    {
        countDownPanel.SetActive(true);
        // disable player controls
        if (Player.TryGetComponent<ThirdPersonController>(out ThirdPersonController controller))
        {
            controller.enabled = false;
        }

        while (countDown > 0)
        {
            countDownText.text = $"Starting in {countDown}";
            yield return new WaitForSeconds(1f);
            countDown--;
        }

        countDownPanel.SetActive(false);
        // enable player controls
        if (controller != null)
        {
            controller.enabled = true;
        }
        _isGameStarted = true;
    }

    public void PickCoin()
    {
        collectedCoins++;
        cointCountText.text = $"Coins: {collectedCoins}";
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        _isGameStarted = false;
    }
}
