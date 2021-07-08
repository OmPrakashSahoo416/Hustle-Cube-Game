using UnityEngine;
using UnityEngine.SceneManagement;

public class newlevel : MonoBehaviour
{
    public void loadnextlevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
