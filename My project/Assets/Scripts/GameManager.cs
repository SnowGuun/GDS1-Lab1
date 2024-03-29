using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject startGameUI;
    

    public GameObject youWinUI;
    public static bool isGameOver = false;
    public static bool isGameStart= false;

    void Start()
    {
        isGameStart = false; // Ensure game doesn't start immediately
        Time.timeScale = 0; // Pause the game
        startGameUI.SetActive(true); // Show the start screen
        
    }
    void Update()
    {
        if (!isGameStart && Input.anyKeyDown) 
        {
            startGame();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            restart();
        }
    }
    private void startGame() 
    {
        isGameStart = true;
        Time.timeScale = 1; 
        startGameUI.SetActive(false); 
    }

    public void gameOver()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);
    }
    public void youWin()
    {
        isGameOver = true;
        youWinUI.SetActive(true);
    }

    public void restart()
    {
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    }
}
