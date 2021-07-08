
using UnityEngine;

public class collision : MonoBehaviour
{

    public movement movement;
    public AdsManager AdsManager;

    void OnCollisionEnter (Collision collisioninf){
        if(collisioninf.collider.tag == "obstacle"){
            movement.enabled=false;
            AdsManager.ShowInterstitialAd();
            FindObjectOfType<gameManager>().EndGame();

        }
    }
}
