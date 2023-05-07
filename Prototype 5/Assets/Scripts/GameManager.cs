using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public GameObject startScreen;
    public Button restartButton;
    public bool isGameOver = false;

    private float spawnRate = 1.5f;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score < 0)
        {
            SetGameOver();
        }
    }

    IEnumerator SpawnTarget()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(spawnRate);
            if (!isGameOver)
            {
                int prefabIndex = Random.Range(0, targets.Count);
                Instantiate(targets[prefabIndex]);
            }
        }
    }

    public void StartGame(float difficulty)
    {
        StartCoroutine("SpawnTarget");
        UpdateScore(0);
        startScreen.gameObject.SetActive(false);
        spawnRate /= difficulty;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void SetGameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameOver = true;
    }

    public void RestartGame()
    {
        UpdateScore(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
