using UnityEngine;
using UnityEngine.SceneManagement;
public class STARTMENU : MonoBehaviour
{
    public void startmenu()
    {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
