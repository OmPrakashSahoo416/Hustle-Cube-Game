using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float frwdfrc=2000f; 
    public float sideforce=2500f;

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, frwdfrc * Time.deltaTime);
        // right();
        // left();
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }

    }
    public void right()
    {
        //rb.AddForce(0, 0, frwdfrc * Time.deltaTime);

        Debug.Log("Right");
        rb.AddForce(sideforce , 0, 0, ForceMode.VelocityChange);



        //  rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


    }

    public void left()
    {
        //rb.AddForce(0, 0, frwdfrc * Time.deltaTime);


        //rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);



        rb.AddForce(-sideforce, 0, 0, ForceMode.VelocityChange);


       
    }
}
