using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    public CurrMoneyAmount Curramount;
    public Text TEXT;

    public void Update()
    {
        
        TEXT.text = "Budget: " + Curramount.amount.ToString();


    }
   
}
