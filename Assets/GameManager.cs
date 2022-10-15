using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool gameHasEnded = false;   //default value
   
   public float restartDelay = 1f;
   public void EndGame()
   {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            //Restart();      //Restart game
        }
   }
   
   void Restart ()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
