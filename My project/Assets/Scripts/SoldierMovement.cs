using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMovement : MonoBehaviour
{
    [SerializeField]float speed;
    [SerializeField]float range;
    [SerializeField]float maxDistance;

    Vector2 wayPoint;
    // Start is called before the first frame update
    void Start()
    {
        setNewDestination();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.isGameOver)
        {
            transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed *Time.deltaTime);
            if (Vector2.Distance(transform.position, wayPoint) < range)
            {
                setNewDestination();
        }
        }
        
    }

    void setNewDestination (){
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance,maxDistance));
    }
}
