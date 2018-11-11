using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removebutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Time.timeSinceLevelLoad >= 3.5)
        {
            gameObject.SetActive(false);
        }
	}
}
