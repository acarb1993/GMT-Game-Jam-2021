using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public Animator anim;

    public bool isMining;

    void Start()
    {
        isMining = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isMining", true);
            isMining = true;
        }

        else
        {
            anim.SetBool("isMining", false);
            isMining = false;
        }
    }
}
