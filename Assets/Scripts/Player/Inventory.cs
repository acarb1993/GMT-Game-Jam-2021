using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<RuneType, int> inventory;
    void Start ()
    {
        inventory = new Dictionary<RuneType, int>();

        // Start the game with each of type rune in the inventory with 0
        foreach(RuneType type in Enum.GetValues(typeof(RuneType))) {
            inventory.Add(type, 0);
        }
    }

    public void addToInventory(RuneType runeType, int amount)
    {
        inventory[runeType] += amount;
        Debug.Log(runeType + ": " + inventory[runeType]);
    }
}
