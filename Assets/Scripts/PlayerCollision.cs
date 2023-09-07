using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Debug.Log("I hit an obstacle!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
