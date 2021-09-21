using System;
namespace BankingApplication
{
    public class SavingsAccount : Account
    {
        public double interestRate;

        public SavingsAccount(double initialBalance = 0)
        {
            this.Balance = initialBalance;
            this.interestRate = 0.012;
        }

        public double CalculateInterest(double years)
        {
            double amount = 0;
            amount = Math.Round(this.Balance * Math.Pow((1 + this.interestRate / 12.00), (12 * years)), 2);
            return amount;
        }
    }
}