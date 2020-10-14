using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveIn : MonoBehaviour
{


    GameObject player2;
    PlayerShooting playerSpawned2;

    GameObject player;
    PlayerMovement playerSpawned;

    [SerializeField]
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {

        player2 = GameObject.FindGameObjectWithTag("Gun");
        playerSpawned2 = player2.GetComponent<PlayerShooting>();

        player = GameObject.FindGameObjectWithTag("Player2");
        playerSpawned = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            transform.position = target.position;
            playerSpawned.Spawned();

            playerSpawned2.Spawned2();

        }
      
    }
}
