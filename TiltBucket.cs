using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltBucket : MonoBehaviour
{
    private Rigidbody rb;
    private float currentTime;
    private bool contacted = false;
    public Rigidbody cube;
    public MeshCollider arch;
    public Vector3 down;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Started");
	}

    private void Update()
    {
        if (Time.time > currentTime + 8 && contacted == true)
        {
            rb.mass = 400;
            cube.mass = 100;
            arch.enabled = true;
            //Debug.Log("Time passed now");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameController"))
        {   
            rb.AddForce(down);
        }
    }
    void OnTriggerEnter (Collider col)
    {
        Debug.Log("Contacted");
		if (col.gameObject.CompareTag("GameController"))
        {
            rb.freezeRotation = false;
            contacted = true;
            currentTime = Time.time;
        }
	}
}
