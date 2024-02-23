using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject startGameUI;
    public AudioManager audioManager;
    public GameObject youWinUI;
    public static bool isGameOver = false;
    public static bool isGameStart= false;

    void Start()
    {
        AudioManager.instance.Play("Theme");
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            quit();
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
    public void quit()
    {
        Application.Quit();
        #if UNITY_EDITOR
        Debug.Log("Quit game requested. This works only in a built version of the game.");
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
