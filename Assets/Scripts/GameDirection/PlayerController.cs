using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// enum for button commands
enum BtnCommand{
    leftBtn = 0,
    rightBtn = 1
}
// enum for trail states
enum TrailState{
    off = 0,
    on = 1
}
public class PlayerController : MonoBehaviour
{

    public float objectSpeed = 3f;
    public static bool left;
    public static bool right;
    public ParticleSystem trail;
    public ParticleSystem michaelBay;

    // Start is called before the first frame update
    void Start()
    {
        left = false;
        right = false;
    }

    // Update is called once per frame
    void Update()
    {

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


    // Simplified button command into a single command function with parameter for left button and right button in the enum
    public void buttonCommand(int comm)
    {
        switch(comm)
        {
            case (int)BtnCommand.leftBtn:
                transform.Translate(Vector3.left * objectSpeed * Time.deltaTime);
            break;

            case (int)BtnCommand.rightBtn:
                transform.Translate(Vector3.right * objectSpeed * Time.deltaTime);
            break;
        }
    }

    void SetTrailState(int state)
    {
        if (state == (int)TrailState.on)
        {
            trail.Play();
        }
        else
        {
            trail.Stop();
        }
    }

    private void OnTriggerStay(Collider other) {
    if (other.gameObject.tag == "Blue Wall")
        {
            SetTrailState((int)TrailState.on);
        }
    }

    private void OnTriggerExit(Collider other) {
    if (other.gameObject.tag == "Blue Wall")
        {
            SetTrailState((int)TrailState.off);
        }
    }


    

}
