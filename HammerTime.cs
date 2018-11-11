using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTime : MonoBehaviour {
    public Rigidbody one;
    public Rigidbody two;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            one.isKinematic = false;
            two.isKinematic = false;
            Debug.Log("I felt that");
        }
    }
}
