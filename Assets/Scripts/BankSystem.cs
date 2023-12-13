using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BankSystem : MonoBehaviour
{
    public TMP_Text cash;
    public TMP_Text balance;
    public GameObject TitleBtn;
    public GameObject DepositBtn;
    public GameObject WithdrawalBtn;
    private int haveCash = 100000;
    private int haveBalance = 50000;

    private void Start()
    {
        cash.text = haveCash.ToString();
        balance.text = haveBalance.ToString();
    }

    public void CallDepositWindow()
    {
        TitleBtn.SetActive(false);
        DepositBtn.SetActive(true);
    }
    public void CallWithdrawalWindow()
    {
        TitleBtn.SetActive(false);
        WithdrawalBtn.SetActive(true);
    }
    public void BackSpaceBtn()
    {
        TitleBtn.SetActive(true);
        WithdrawalBtn.SetActive(false);
        DepositBtn.SetActive(false);
    }

    void Deposit(int value)
    {
        haveCash -= value;
        haveBalance += value;
    }
    void Withdrawal(int value)
    {
        haveBalance -= value;
        haveCash += value;
    }


}
