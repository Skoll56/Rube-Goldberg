using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {
    public Rigidbody[] item = new Rigidbody[50];
    public GameObject blackHole;
    bool pop = false;
    float timer = 0;
    public AudioClip succ;
    public AudioSource source;
    //public GameObject blackHole;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (pop == true)
        {
            for (int i = 0; i< item.Length; i++)
            {
                item[i].AddExplosionForce(-5000, blackHole.transform.position, 1000000);
            }

        }

        if (pop == true && Time.time >= timer+1.0f)
        {
            SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene(2);
        }
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Respawn"))
            {
                timer = Time.time;
                pop = true;
            source.PlayOneShot(succ, 2);
            }
    }
}
