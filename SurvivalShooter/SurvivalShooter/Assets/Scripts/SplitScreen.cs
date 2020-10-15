using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour
{
    bool playerActive5 = false;
    public Camera cam1;
    public Camera cam2;

    public bool Horizontal = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //ChangeSplitScreen();
            cam1.rect = new Rect(0, 0, 0.5f, 1);
            playerActive5 = true;
        }
        else if(playerActive5 == false)
        {
            cam1.rect = new Rect(0, 0, 1, 1);
        }
    }

    public void ChangeSplitScreen()
    {
        Horizontal = !Horizontal;
        if (playerActive5 == true)
        {
            if (Horizontal)
            {
                cam1.rect = new Rect(0, 0, 1, 0.5f);
                cam2.rect = new Rect(0, 0.5f, 1, 0.5f);
            }
            else
            {
                cam1.rect = new Rect(0, 0, 0.5f, 1);
                cam2.rect = new Rect(0.5f, 0, 0.5f, 1);
            }
        }    

        
    }

}
