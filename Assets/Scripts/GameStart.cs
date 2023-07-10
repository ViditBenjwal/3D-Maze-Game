using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

public void Start ()
{
   FindObjectOfType<gameManager>().EndGame();
           
}

}



