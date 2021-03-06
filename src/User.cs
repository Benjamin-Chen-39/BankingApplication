using System;
namespace BankingApplication
{
    public class User
    {
        public string Name;
        public bool ActiveSavingsAccount;
        public bool ActiveCheckingAccount;
        public SavingsAccount SavingsAccount;
        public CheckingAccount CheckingAccount;

        public User(string name = "Default")
        {
            this.Name = name;
            this.ActiveSavingsAccount = false;
            this.ActiveCheckingAccount = false;

        }

        public void CreateAccount(int choice)
        {
            if (choice == 2) //create savings account
            {
                //put money into savings account
                Console.WriteLine("Creating Savings Account.\nPlease deposit an initial amount: ");
                this.SavingsAccount = new SavingsAccount(Convert.ToDouble(Console.ReadLine()));
                this.ActiveSavingsAccount = true;
                Console.WriteLine($"You have created a savings account with: {this.SavingsAccount.getBalance()}");
            }

            else if (choice == 3) //create checking account
            {
                //put money into checking account
                Console.Write("Creating Checking Account.\nPlease deposit an initial amount: ");
                this.CheckingAccount = new CheckingAccount(Convert.ToDouble(Console.ReadLine()));
                this.ActiveCheckingAccount = true;
                Console.WriteLine($"You have created a checking account with: {this.CheckingAccount.getBalance()}");
            }

            else if (choice == 4) //create both savings and checking accounts
            {
                //put money into both accounts
                Console.Write("Creating Savings Account.\nPlease deposit an initial amount: ");
                this.SavingsAccount = new SavingsAccount(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Creating Checking Account.\nPlease deposit an initial amount: ");
                this.CheckingAccount = new CheckingAccount(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine($"You have created a savings account with: {this.SavingsAccount.getBalance()}");
                Console.WriteLine($"You have created a checking account with: {this.CheckingAccount.getBalance()}");
                this.ActiveSavingsAccount = true;
                this.ActiveCheckingAccount = true;
            }
        }
    }
}
