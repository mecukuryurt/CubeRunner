using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        Debug.Log("I hit the player!");
        gameManager.CompleteLevel();
    }
}
