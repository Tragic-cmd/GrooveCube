using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // With this you can drag player movement into the script window
    public PlayerMovement movement; // A reference to the PlayerMovement script

    // This function will run when we collide with an object
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check to see if the object we collided with has the tag "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disable the players movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}