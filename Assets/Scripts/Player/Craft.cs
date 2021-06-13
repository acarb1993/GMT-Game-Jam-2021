using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    private RuneTable craftingTable;
    // Start is called before the first frame update
    void Start()
    {
        craftingTable = GameObject.Find("Rune-Table").GetComponent<RuneTable>(); ;
    }

    // Update is called once per frame
    void Update()
    {
        if(craftingTable.CanCraft)
        {
            if(Input.GetMouseButtonDown(0))
            {
                // Raycast to see what rune we should craft
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if(hit.collider != null)
                {
                    Debug.Log(hit.collider.name);
                }
            }
        }
    }
}
