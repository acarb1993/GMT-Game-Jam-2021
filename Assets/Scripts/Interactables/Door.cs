using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public GameObject door;
    public GameObject doorUI;

    //Test
    private void Awake()
    {
        doorUI.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && anim.GetBool("isOpenDoor") == false)
        {
            doorUI.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("isOpenDoor", true);
                anim.SetBool("isClosedDoor", false);
                door.GetComponent<BoxCollider2D>().enabled = false;

                doorUI.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorUI.SetActive(false);

            if (anim.GetBool("isOpenDoor") == true)
            {
                anim.SetBool("isOpenDoor", false);
                anim.SetBool("isClosedDoor", true);
                door.GetComponent<BoxCollider2D>().enabled = true;

                doorUI.SetActive(false);
            }
        }
    }
}
