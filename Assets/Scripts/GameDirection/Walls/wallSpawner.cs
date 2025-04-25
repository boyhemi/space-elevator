using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject[] initWalls;
    int posCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((int) player.transform.position.y %4 == 0 && (int)player.transform.position.y != posCheck)
        {
            posCheck = (int)player.transform.position.y;
            GameObject posObj = Instantiate(initWalls[Random.Range(0,2)], new Vector3(transform.position.x, transform.position.y + 4f ), Quaternion.identity);
            // GameObject posObj = Instantiate(initWalls[Random.Range(0,2)], new Vector3(transform.position.x, transform.position.y + 4f ), Quaternion.identity);
             posObj.transform.parent = gameObject.transform;
             gameObject.transform.GetChild(0).gameObject.SetActive(false);

            
        }
    }
}
