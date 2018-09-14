using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    
    // we create a public reference to our player movement script called movement
    public PlayerMovement movement;
    //we create a reference to our GameManager class
    public GameManager GameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Debug.Log("We hit an Obstacle.");
            // this causes the player to stop moving if he hits an obstacle
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        Debug.Log(collisionInfo.collider.name);
    }
}
