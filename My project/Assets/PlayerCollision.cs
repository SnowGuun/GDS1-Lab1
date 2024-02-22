using System.Security.Cryptography.X509Certificates;
using UnityEditor.Callbacks;
using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   void OnCollisionEnter2D(Collision2D collisionInfo) 
   {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            rb.isKinematic = false;
            Debug.Log("Game Over!");
            
        }
   }
}
