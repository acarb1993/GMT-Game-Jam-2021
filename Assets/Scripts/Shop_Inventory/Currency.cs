using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public int currency;

    Text currencyTxt;

    void Start()
    {
        currencyTxt = GameObject.Find("Currency").GetComponent<Text>();
    }

    
    void Update()
    {
        GetMoney();
    }

    public void GetMoney()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            currency++;
            currencyTxt.text = currency.ToString();
        }
    }
}
