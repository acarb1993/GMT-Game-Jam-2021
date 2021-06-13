using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneVein : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform mineUI;
    private Inventory playerInventory;
    private bool canMine;

    private Mine mining;

    protected int veinDurability { get; set; }


    void Start()
    {
        mining = FindObjectOfType<Mine>();
        playerInventory = player.GetComponent<Inventory>();
        canMine = false;
        Init();
    }

    public int Init()
    {
        veinDurability = 100;

        return veinDurability;
    }

    
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

    public void VeinDamage()
    {
        veinDurability -= 20;

        Debug.Log(veinDurability);
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
