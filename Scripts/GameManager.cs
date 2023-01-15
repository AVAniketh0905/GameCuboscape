using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;

    public float restartDelay = 1f;

    public GameObject complLevelUI;

    public void CompleteLevel()
    {
        // Debug.Log($"Level 1!.");
        complLevelUI.SetActive(true);

        // Invoke("Restart", restartDelay);

        // complLevelUI.SetActive(false);
    }


    public void EndGame()
    {
        if (gameEnded) { return; }
        // Debug.Log($"GameOver!");
        gameEnded = true;

        Invoke("Restart", restartDelay);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
