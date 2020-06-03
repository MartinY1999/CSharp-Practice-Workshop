using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to a Rigidbody
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	void Start ()
	{
	    
	}
    // FixedUpdate - Better use of Unity Engine
    // Time.deltaTime - Controls frames for slow and high-end PCs
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
        if (rb.position.y < 0f)
        {
            enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
