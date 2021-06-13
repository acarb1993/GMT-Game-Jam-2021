using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("isMining", true);
        }

        else
        {
            anim.SetBool("isMining", false);
        }
    }
}
