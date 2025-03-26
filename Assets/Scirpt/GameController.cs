using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanal;
    public GameObject tapToStart;
    public GameObject scoreText;
    private void Start()
    {
        gameOverPanal.SetActive(false);
        tapToStart.SetActive(true);
        scoreText.SetActive(false);
        PauseGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        gameOverPanal.SetActive(true);
        scoreText.SetActive(false);

    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;

    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        tapToStart.SetActive(false);
        scoreText.SetActive(true);
    }
}
