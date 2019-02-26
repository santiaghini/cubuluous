using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

     void OnCollisionEnter (Collision collisionInfo)
    {
        // Turn off player mov when hitting obj
        if(collisionInfo.collider.tag == "Obstacle")
        { 
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}