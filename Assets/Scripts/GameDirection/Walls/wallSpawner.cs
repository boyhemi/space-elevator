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
        
        WallSpawner();
        
    }

    void WallSpawner()
    {
        //FIX: FIX ERROR MEESAGE WHEN PLAYER DIDN'T TOUCH THE OBJECT
        if (player != null)
        {
            if ((int) player.transform.position.y %4 == 0 && (int)player.transform.position.y != posCheck)
            {
                posCheck = (int)player.transform.position.y;
                int randWalls = Random.Range(0,2);
                GameObject posObj = Instantiate(initWalls[randWalls], new Vector3(transform.position.x, transform.position.y + 4f + posCheck), Quaternion.identity);
                posObj.transform.parent = gameObject.transform;
                Destroy(gameObject.transform.GetChild(0).gameObject);

                for (int i = 0; i < 2; i++)
                {
                    initWalls[i] = posObj;
                }

            }
        }
    }

}
