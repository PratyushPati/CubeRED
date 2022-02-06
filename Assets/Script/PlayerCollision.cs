using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //public static float speed = Obstacle.OBspeed;
   void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Obstacle.OBspeed = 0.0f;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
   
}
