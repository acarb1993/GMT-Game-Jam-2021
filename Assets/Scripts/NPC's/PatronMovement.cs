using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    private GameObject patronWait;
    private GameObject patronSpawn;

    Patron patron;
    
    void Start()
    {
        patron = GameObject.FindObjectOfType<Patron>();
        patronWait = GameObject.Find("Patron Wait");
        patronSpawn = GameObject.Find("Patron Spawn");
    }

    void Update()
    {
        if (!patron.returnToSpawn && !patron.waitInLine)
        {
            transform.position = Vector2.MoveTowards(transform.position, patronWait.transform.position, Time.deltaTime * speed);
        }

        else if (patron.returnToSpawn)
        {
            transform.position = Vector2.MoveTowards(transform.position, patronSpawn.transform.position, Time.deltaTime * speed);

            if (transform.position == patronSpawn.transform.position)
            {
                gameObject.SetActive(false);
                patron.returnToSpawn = false;
            }
        }

        WaitInLine();
    }

    public void WaitInLine()
    {
        if(patron.waitInLine && !patron.returnToSpawn)
        {
            transform.position = Vector2.MoveTowards(transform.position, transform.position, 0);
        }
    }
}
