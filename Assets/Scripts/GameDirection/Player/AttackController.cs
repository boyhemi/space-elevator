using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public Transform attackPoint;
    public GameObject prefabLaser;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Attack();
        }
        
    }


    public void Attack()
    {
        Instantiate(prefabLaser, attackPoint.position, attackPoint.rotation);
    }





}
