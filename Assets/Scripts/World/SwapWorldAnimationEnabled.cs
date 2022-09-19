using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SwapWorldAnimationEnabled : MonoBehaviour
{
    public bool swap;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            if (!swap == true)
            {
                swap = true;
            }
            else
            {
                swap = false;
            }
        }

        if (swap == true)
        {
            GetComponent<TilemapRenderer>().enabled = true;
        }
        else
        {
            GetComponent<TilemapRenderer>().enabled = false;
        }
    }
}
