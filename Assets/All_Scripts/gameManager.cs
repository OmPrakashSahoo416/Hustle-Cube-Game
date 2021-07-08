using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdelay=1f;
    public GameObject completelevelui;
    public void leveldone()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
  public  void EndGame()
    {
        if(gamehasended==false){
            gamehasended=true;
        Debug.Log("Game Over...");
        Invoke("restart",restartdelay);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
