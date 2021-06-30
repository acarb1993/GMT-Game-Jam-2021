using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Inventory : MonoBehaviour
{
    public Text[] runeCount;
    Inventory runeInventory;

    int airRune;
    int fireRune;
    int waterRune;
    int earthRune;
    int blankRune;

    private void OnEnable()
    {
        runeInventory = GameObject.FindObjectOfType<Inventory>();
        GetRuneCount();
    }

    public void GetRuneCount()
    {
        airRune = runeInventory.inventory[RuneType.Air];
        runeCount[0].text = airRune.ToString();

        fireRune = runeInventory.inventory[RuneType.Fire];
        runeCount[1].text = fireRune.ToString();

        waterRune = runeInventory.inventory[RuneType.Water];
        runeCount[2].text = waterRune.ToString();

        earthRune = runeInventory.inventory[RuneType.Earth];
        runeCount[3].text = earthRune.ToString();

        blankRune = runeInventory.inventory[RuneType.Blank];
        runeCount[4].text = blankRune.ToString();
    }
}
