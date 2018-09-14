using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // rb refers to our player
    public Rigidbody rb;

    // Use this for initialization
    // void Start () {
    // Debug.Log("Hello World");
    //  rb.AddForce(0, 200, 500);
    //}

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


	// Fixed update is used to deal with physics
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);



        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}