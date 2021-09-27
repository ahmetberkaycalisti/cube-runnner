using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel() {
        Debug.Log("Level COMPLETED");
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {

        if (gameHasEnded == false) { 

            gameHasEnded = true;
            Debug.Log("GAME OVER");
            // Restart Game
            // Restart();
            Invoke("Restart", restartDelay);
        }

    }

    void Restart() { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
