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
        if (Input.GetButton("Jump"))
        {
            Instantiate(player, transform.position, transform.rotation);
        }
        
    }
}
