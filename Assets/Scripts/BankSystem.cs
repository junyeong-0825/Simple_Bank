using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BankSystem : MonoBehaviour
{
    public TMP_Text cash;
    public TMP_Text balance;

    private int haveCash = 100000;
    private int haveBalance = 50000;

    private void Start()
    {
        cash.text = haveCash.ToString();
        balance.text = haveBalance.ToString();
    }


}
