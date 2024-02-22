using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SoldierManager : MonoBehaviour
{
    public int soldierCount;
    public int soldierTreated;
    public PlayerCollision playerCollision;
    public GameManager gameManager;
    public TextMeshProUGUI soldierCountText;
    public TextMeshProUGUI soldierInHospitalText;


    // Update is called once per frame
    public void resetCounter(){
        soldierCount =0;
    }
    void Update()
    {
        soldierCountText.text = "Soldier Rescued: " + soldierCount.ToString() + "/3";
        soldierInHospitalText.text = "Soldier in Hospital: " + soldierTreated.ToString();


        if (soldierCount >=3 )
        {
            soldierCountText.text = "Helicopter at MAX CAPACITY!";

        }
        else if (soldierCount ==0) {
        soldierCountText.text = "Soldier Rescued: " + soldierCount.ToString() + "/3"; 

        }

        if (soldierTreated >= 4){
            gameManager.youWin();
        }
    }

}
