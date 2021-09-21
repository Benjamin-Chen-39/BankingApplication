using System;
namespace BankingApplication
{
    public class CheckingAccount : Account
    {
        int warningCounter;
        public CheckingAccount(double initialBalance = 0)
        {
            this.Balance = initialBalance;
            warningCounter = 0;
            this.status = true;
        }

        public void deposit(double depositAmount)
        {
            if (this.status)
            {
                this.Balance += depositAmount;
                Console.WriteLine($"{depositAmount} deposited. New balance: {this.Balance}");
            }

            else
            { Console.WriteLine("This Account is closed."); }
        }

        public void withdraw(double withdrawAmount)
        {
            if (this.status)
            {
                if (this.Balance >= withdrawAmount)
                {
                    this.Balance -= withdrawAmount;
                    Console.WriteLine($"{withdrawAmount} withdrawn. New balance: {this.Balance}");

                }
                else
                {
                    Console.WriteLine("Insufficient funds. Fee incurred.");
                    this.Balance -= 50;
                    this.warningCounter += 1;
                    if (this.warningCounter == 3)
                    {
                        this.status = false;
                        Console.WriteLine("Too many fees incurred. Account is now closed.");
                    }
                }
            }

            else
            {
                Console.WriteLine("This Account is closed.");
            }
        }
    }
}