using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Moveball : MonoBehaviour
{
    public float speed;
    public bool pipe = false;
    private Rigidbody rb;
    private int count;
    public Text countText;
    public GameObject fanCore;
    public GameObject goal;
    private bool airtime = false;
    public Speech doc, mikey;
    private AudioSource source;
    public AudioClip thud;
    public AudioClip cannonfire, blow, music;
    public float sumForce;
    private bool cooldown;
    private float timer;
    public GameObject bigblock;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        source.PlayOneShot(music, 0.021f);
    }

    private void Awake()
    {
        
    }

    private void Update()
    {
        if (pipe == true)
        {
            rb.AddExplosionForce(30.01f, fanCore.transform.position, 75);
        }

        if (airtime == true)
        {
            rb.AddExplosionForce(-30.0f, goal.transform.position, 250);
        }

        if (Time.time > timer + 0.5)
        { cooldown = false; }
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0, moveZ);
        rb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Fire"))
        {
            rb.AddForce(3000, 3000, 3000);
            source.PlayOneShot(cannonfire, 1f);
        }

        if (col.gameObject.CompareTag("Player"))
        {
            bigblock.SetActive(false);
        }

        if (col.gameObject.CompareTag("Bucket"))
        {
            col.rigidbody.mass = 30;
        }

        if (col.gameObject.CompareTag("Pipe"))
        {
            source.PlayOneShot(blow, 0.60f);
            pipe = true;
        }
        //sumForce = col.impactForceSum.x + col.impactForceSum.y + col.impactForceSum.z;
        // if (col.impactForceSum.x < -10 || col.impactForceSum.x > 10 || col.impactForceSum.y < -10 || col.impactForceSum.y > 10 || col.impactForceSum.z < -10 || col.impactForceSum.z > 10)
        if (cooldown == false)
        {
            sumForce = col.impactForceSum.magnitude;
            source.PlayOneShot(thud, sumForce * 0.04f);
            cooldown = true;
            timer = Time.time;
        }        
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Pipe"))
        {
            pipe = false;
        }
    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.tag = "New";
        }
        if (other.gameObject.CompareTag("Goal"))    
        {
            airtime = true;
        }

        if (other.gameObject.CompareTag("Aimpoint"))
        {
            airtime = false;

        }

        if (other.gameObject.CompareTag("voice"))
        {
            doc.SayLine();
        }

        if (other.gameObject.CompareTag("voiceMikey"))
        {
            mikey.SayLine();
        }

    }


}
