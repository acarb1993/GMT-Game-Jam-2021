using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneVein : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform mineUI;
    private Inventory playerInventory;
    private bool canMine;

    private Mine mining;

    public RuneVein_UI runeVeinUI;

    public float durability;
    public float maxDurability = 100f;

    void Start()
    {
        mining = FindObjectOfType<Mine>();
        playerInventory = player.GetComponent<Inventory>();
        canMine = false;

        durability = maxDurability;
        runeVeinUI.SetDurability(durability, maxDurability);
    }

    void Update()
    {
        runeVeinUI.SetDurability(durability, maxDurability);

        if (canMine)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                playerInventory.addToInventory(RuneType.Blank, 1);
            }
        }

        if(durability <= 0f)
        {
            gameObject.SetActive(false);
        }
    }

    public void VeinDamage()
    {
        durability -= 20;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            canMine = true;
            mineUI.gameObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            canMine = false;
            mineUI.gameObject.SetActive(false);
        }
    }
}
