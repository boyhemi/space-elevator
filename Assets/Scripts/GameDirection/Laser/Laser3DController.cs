using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser3DController : MonoBehaviour
{
    public float laserSpeed = 20;
    public Rigidbody rb3D;
    public AudioSource laserSoundEffect;
    public GameObject explosionEffect;


    // Start is called before the first frame update
    void Start()
    {
        rb3D.velocity = transform.forward * laserSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
