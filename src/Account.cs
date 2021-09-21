using System;
namespace BankingApplication
{
    public abstract class Account : User
    {
        public double Balance;

        public double getBalance()
        {
            return this.Balance;
        }
    }
}