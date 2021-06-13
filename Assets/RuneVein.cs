using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneVein : MonoBehaviour
{
    [SerializeField] private Transform mineUI;
    private Inventory playerInventory;
    private bool canMine;
    // Start is called before the first frame update
    void Start()
    {
        canMine = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMine)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                playerInventory.addToInventory(RuneType.Blank, 1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            canMine = true;
            mineUI.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            canMine = false;
            mineUI.gameObject.SetActive(false);
        }
    }
}
