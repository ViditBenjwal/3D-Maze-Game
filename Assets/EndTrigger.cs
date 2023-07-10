using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public gameManager Gamemanager;

    void OnTriggerEnter() 
    {
        Gamemanager.CompleteGame();
    }
}
