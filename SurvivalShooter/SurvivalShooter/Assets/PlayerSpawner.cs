using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    public GameObject player;


    void Start()
    {
        
    }


    void Spawn()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(player, transform.position, transform.rotation);
        }
        
    }
}
