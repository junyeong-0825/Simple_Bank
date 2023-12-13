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
    public GameObject ErrorMassage;
    public TMP_InputField CustomDeposit;
    public TMP_InputField CustomWithdrawal;
    private int haveCash = 100000;
    private int haveBalance = 50000;
    private int DepositInputValue;
    private int WithdrawalInputValue;

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
    public void Add10000Btn()
    {
        if(haveCash >= 10000)
        {
            Deposit(10000);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }
    public void Add30000Btn()
    {
        if (haveCash >= 30000)
        {
            Deposit(30000);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }
    public void Add50000Btn()
    {
        if (haveCash >= 50000)
        {
            Deposit(50000);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }
    public void AddCustomBtn()//InputField에서 받은 값을 기준으로 몬가 해야댐
    {
        DepositInputValue = int.Parse(CustomDeposit.text);
        if (haveCash >= DepositInputValue)
        {
            Deposit(DepositInputValue);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }
    public void Sub10000Btn()
    {
        if (haveBalance >= 10000)
        {
            Withdrawal(10000);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }
    public void Sub30000Btn()
    {
        if (haveBalance >= 30000)
        {
            Withdrawal(30000);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }
    public void Sub50000Btn()
    {
        if (haveBalance >= 50000)
        {
            Withdrawal(50000);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }
    public void SubCustomBtn()//InputField에서 받은 값을 기준으로 몬가 해야댐
    {
        WithdrawalInputValue = int.Parse(CustomWithdrawal.text);
        if (haveBalance >= WithdrawalInputValue)
        {
            Withdrawal(WithdrawalInputValue);
            cash.text = haveCash.ToString();
            balance.text = haveBalance.ToString();
        }
        else
        {
            ErrorMassage.SetActive(true);
        }
    }

    public void ErrorCloseBtn()
    {
        ErrorMassage.SetActive(false);
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
