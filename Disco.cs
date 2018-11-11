using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour {
    //public float speed;
    Vector3 rotation;
    // Use this for initialization
    void Start ()
    {
        rotation = new Vector3(Random.Range(-5, 30), Random.Range(-30, 10), Random.Range(-30, 25));
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate((rotation) * Time.deltaTime);
    }
}
