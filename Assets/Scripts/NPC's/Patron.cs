using System;
using System.Collections.Generic;
using UnityEngine;

public class Patron : MonoBehaviour
{
    private List<RuneType> runes;
    private RuneType rune;
    private ChatBubble chatbubble;
    private Inventory playerInventory;
    private int amount;

    public bool returnToSpawn;
    public bool waitInLine;

    float distance;

    
    void Start()
    {
        runes = new List<RuneType>();
        chatbubble = transform.Find("Chat Bubble").GetComponent<ChatBubble>();
        returnToSpawn = false;
        waitInLine = false;

        // Get each type of rune the patron can ask for.
        foreach (RuneType type in Enum.GetValues(typeof(RuneType)))
        {
            runes.Add(type);
        }

        // Get a random rune and amount
        int index = UnityEngine.Random.Range(0, runes.Count);
        rune = runes[index];
        // TODO change from being hard coded numbers, only here for testing, this won't happen OOF
        amount = UnityEngine.Random.Range(1, 5);

        chatbubble.SetIcon(rune);
        chatbubble.SetText("Greetings Dwarf, I will purchase a " + rune + " rune. I'll take " + amount +  " of them.");

        playerInventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    public void Update()
    {
        
    }

    public bool Purchase()
    {
        if(playerInventory.inventory[rune] >= amount)
        {
            chatbubble.SetText("Thanks little guy, i'm off!");
            returnToSpawn = true;
            return true;
        }

        chatbubble.SetText("I don't believe you have enough runes in stock, you need " + amount + " of them");
        returnToSpawn = false;
        return false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Sell sell = collision.GetComponent<Sell>();
        
        if(sell != null)
        {
            sell.patron = GetComponent<Patron>();
        }
        
        if(collision.gameObject.tag == "Patron")
        {
            waitInLine = true;
        }

        else
        {
            waitInLine = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Sell sell = collision.GetComponent<Sell>();

        if (sell != null)
        {
            sell.patron = null;
        }
    }
}
