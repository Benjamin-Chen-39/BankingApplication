using System;
namespace BankingApplication
{
    public abstract class Account : User
    {
        public double Balance;
        public bool status; //true if open, false if closed

        public double getBalance()
        {
            return this.Balance;

        }
    }
}