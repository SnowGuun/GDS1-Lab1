using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody2D rb;
    public GameManager gameManager;
    public AudioManager audioManager;
    public SoldierManager soldierManager;
    private bool isCollide;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioManager = AudioManager.instance;
    }
   private void OnCollisionEnter2D(Collision2D collisionInfo) 
   {
        if (collisionInfo.collider.tag == "Obstacle" & !isCollide)
        {
            isCollide = true;
            movement.enabled = false;
            rb.isKinematic = false;
            Debug.Log("Game Over!");
            gameManager.gameOver();
            
        }
   }
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.gameObject.CompareTag("Soldier")  && soldierManager.soldierCount < 3)
       {
        audioManager.Play("Pick up");
        Destroy(other.gameObject);
        soldierManager.soldierCount++;
        Debug.Log("Soldier collected!");
       }
       else if (other.gameObject.CompareTag("Hospital")) 
       {
        soldierManager.soldierTreated += soldierManager.soldierCount;
        soldierManager.resetCounter();
        


       }
       
   }

   
   
}
