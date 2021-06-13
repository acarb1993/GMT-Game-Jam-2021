using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Board : MonoBehaviour
{

    private bool canShop;
    private bool isShopping;
    public GameObject shopUI;
    public GameObject shop_BoardGUI;

    private void Awake()
    {
        shopUI.SetActive(false);
        canShop = false;
        isShopping = false;
        shop_BoardGUI.SetActive(false);
    }

    void Update()
    {
        if (canShop && !isShopping)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isShopping = true;

                shopUI.SetActive(false);
                shop_BoardGUI.SetActive(true);

                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;
            }
        }

        else if (isShopping)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shopUI.SetActive(true);
                shop_BoardGUI.SetActive(false);

                isShopping = false;

                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
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
