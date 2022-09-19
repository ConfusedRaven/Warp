using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SwapWorldAnimationDisabled : MonoBehaviour
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
            GetComponent<TilemapRenderer>().enabled = false;
        }
        else
        {
            GetComponent<TilemapRenderer>().enabled = true;
        }
    }
}
