using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GameManager gameManager;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
      
        if (collisionInfo.collider.tag == "Obstacle")  {
            // Debug.Log("Hit an obstacle3x");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
