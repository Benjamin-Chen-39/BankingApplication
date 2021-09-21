using System;
namespace BankingApplication
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(double initialBalance = 0)
        {
            this.Balance = initialBalance;
        }

    }
}