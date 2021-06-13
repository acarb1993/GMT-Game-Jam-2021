using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{
    public Patron patron;

    void Update()
    {
        if(patron != null)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                patron.Purchase();
            }
        }
    }
}
