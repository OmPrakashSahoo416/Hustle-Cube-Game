using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quitscript : MonoBehaviour
{
   
   

    public void playagain()
    {
            SceneManager.LoadScene("level 1");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
