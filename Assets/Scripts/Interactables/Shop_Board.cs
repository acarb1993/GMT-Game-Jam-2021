using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Board : MonoBehaviour
{

    private bool canShop;
    private bool isShopping;
    public GameObject shopUI;
    public GameObject shop_BoardGUI;

    Movement playerMove;

    private void Awake()
    {
        shopUI.SetActive(false);
        canShop = false;
        isShopping = false;
        shop_BoardGUI.SetActive(false);
    }

    void Update()
    {
        if (canShop)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shopUI.SetActive(false);
                shop_BoardGUI.SetActive(true);

                isShopping = true;
            }
        }

        if (isShopping)
        {
            playerMove = FindObjectOfType<Movement>();
            playerMove.enabled = false;

            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                isShopping = false;
                shop_BoardGUI.SetActive(false);

                playerMove = FindObjectOfType<Movement>();
                playerMove.enabled = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canShop = true;
            shopUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canShop = false;
            shopUI.SetActive(false);
        }
    }
}
