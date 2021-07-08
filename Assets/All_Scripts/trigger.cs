
using UnityEngine;

public class trigger : MonoBehaviour
{
    public gameManager GameManager;
    void OnTriggerEnter()
    {
        GameManager.leveldone();
    }
}
