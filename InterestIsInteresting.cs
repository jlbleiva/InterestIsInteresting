using System;
using System.IO;
using Microsoft.VisualBasic;
using Xunit.Sdk;

static class SavingsAccount
{
    
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) return 3.213f;
        else if (balance >= 0 && balance < 1000) return 0.5f;
        else if (balance >= 1000 && balance < 5000) return 1.621f;
        else return 2.475f;

    }

    public static decimal Interest(decimal balance)
    {
        return ((((decimal)InterestRate(balance)) * balance) / 100);
       }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return (balance + ((balance * (decimal)InterestRate(balance)) / 100));
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal  rate = (decimal)InterestRate(balance);
        decimal rent = (rate * balance) / 100;
        decimal dif = targetBalance - balance;
        int years = 0;

        while (dif > 0)
        {
            years ++;
            dif -= rent;
            balance += rent;
            rate = (decimal)InterestRate(balance);
            rent = (rate * balance) / 100;
        }
        return years;
    }
}
