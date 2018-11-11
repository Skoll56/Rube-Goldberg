using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropweight : MonoBehaviour {
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        rb.useGravity = true;
    }
}
