using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMeteor : MonoBehaviour
{
    public GameObject meteor;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
         speed = 3;
         InvokeRepeating("meteorSpawn", 2.0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    public void meteorSpawn()
    {
        Instantiate(meteor, new Vector3(Random.Range(-1, 1), transform.position.y, transform.position.z), Quaternion.identity);
        if (speed == 3)
        {

            speed = 0;

        }
        speed++;
    }
}
