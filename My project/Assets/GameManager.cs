using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject youWinUI;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            restart();
        }
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void youWin()
    {
        youWinUI.SetActive(true);
    }

    public void restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
