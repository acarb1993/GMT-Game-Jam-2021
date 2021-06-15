using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public GameObject door;
    public GameObject doorUI;
    private bool canOpen;

    private void Awake()
    {
        doorUI.SetActive(false);
        canOpen = false;
    }

    private void Update()
    {
        if(canOpen)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("isOpenDoor", true);
                anim.SetBool("isClosedDoor", false);
                door.GetComponent<BoxCollider2D>().enabled = false;

                doorUI.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !anim.GetBool("isOpenDoor"))
        {
            doorUI.SetActive(true);
            canOpen = true;
        }

        if(collision.gameObject.tag == "Patron" && !anim.GetBool("isOpenDoor"))
        {
            anim.SetBool("isOpenDoor", true);
            anim.SetBool("isClosedDoor", false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorUI.SetActive(false);
            canOpen = false;

            if (anim.GetBool("isOpenDoor") )
            {
                anim.SetBool("isOpenDoor", false);
                anim.SetBool("isClosedDoor", true);
                door.GetComponent<BoxCollider2D>().enabled = true;

                doorUI.SetActive(false);
            }
        }

        if(other.gameObject.tag == "Patron")
        {
            if (anim.GetBool("isOpenDoor"))
            {
                anim.SetBool("isOpenDoor", false);
                anim.SetBool("isClosedDoor", true);
            }
        }
    }
}
