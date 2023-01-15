using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
