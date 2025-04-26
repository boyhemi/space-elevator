using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public float objectSpeed = 3f;
    public static bool left;
    public static bool right;
    public ParticleSystem trail;
    public ParticleSystem michaelBay;
    public int score;
    public TMP_Text initScore;

    // Start is called before the first frame update
    void Start()
    {
        left = false;
        right = false;
    }

    // Update is called once per frame
    void Update()
    {

        initScore.text = "Score: " + score.ToString();

        transform.Translate(Vector3.up * objectSpeed * Time.deltaTime);

        if (left && transform.position.x >= -3)
        {
            transform.Translate(Vector3.left * objectSpeed * Time.deltaTime);
        }
        if (right && transform.position.x <= 3)
        {
            transform.Translate(Vector3.right * objectSpeed * Time.deltaTime);
        }
    }

    public void leftCommand()
    {
        transform.Translate(Vector3.left * objectSpeed * Time.deltaTime);
    }

    public void rightCommand()
    {
        transform.Translate(Vector3.right * objectSpeed * Time.deltaTime);
    }

    private void OnTriggerStay(Collider other) {
    if (other.gameObject.tag == "Blue Wall")
        {
            trail.Play();
        }
    }

    private void OnTriggerExit(Collider other) {
    if (other.gameObject.tag == "Blue Wall")
        {
            trail.Stop();
        }
    }


    

}
