using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject CompleteGameUI; 

    public void CompleteGame()
    {
        CompleteGameUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke ("Restart" , restartDelay);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene("MiniGame");
    }

}




