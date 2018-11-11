using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoFall : MonoBehaviour {
    public GameObject stairTrigger;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (stairTrigger.CompareTag("New"))
        {
            rb.isKinematic = false;
        }

	}

}
