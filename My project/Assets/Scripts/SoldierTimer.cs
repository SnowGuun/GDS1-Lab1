using UnityEngine;
using TMPro;

public class SoldierTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0 && !GameManager.isGameOver)
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime <= 3.0f && remainingTime >= 1.0f)
            {
                timerText.color = Color.red;
            }
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            gameManager.gameOver();

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
    }
}
