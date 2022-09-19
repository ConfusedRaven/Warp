using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SwapWorldDisabled : MonoBehaviour
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
            GetComponent<TilemapCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<TilemapCollider2D>().enabled = true;
        }
    }
}
