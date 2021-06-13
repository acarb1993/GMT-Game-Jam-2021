using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{

    private RuneVein rv;
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

            if(rv != null)
            {
                rv.VeinDamage();
            }
        }

        else
        {
            anim.SetBool("isMining", false);
            isMining = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rv = collision.gameObject.GetComponent<RuneVein>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        rv = null;
    }
}
