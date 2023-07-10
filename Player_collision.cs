
using UnityEngine;

public class Player_collision : MonoBehaviour
{
    public Player_movement movement;

   void OnCollisionEnter(Collision collisionInfo)
   {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled=false;
        }
   }
}
