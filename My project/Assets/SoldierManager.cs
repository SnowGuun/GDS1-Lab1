using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SoldierManager : MonoBehaviour
{
    public int soldierCount;
    public PlayerCollision playerCollision;
    public TextMeshProUGUI soldierCountText;

    // Update is called once per frame
    public void resetCounter(){
        soldierCount =0;
    }
    void Update()
    {
        soldierCountText.text = "Soldier Rescued: " + soldierCount.ToString() + "/3"; 
        if (soldierCount >=3 )
        {
            soldierCountText.text = "Helicopter at MAX CAPACITY!";

        }
        else if (soldierCount ==0) {
        soldierCountText.text = "Soldier Rescued: " + soldierCount.ToString() + "/3"; 

        }
    }

}
