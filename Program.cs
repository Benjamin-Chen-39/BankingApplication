using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            int accountSelection;
            string username;
            bool ProgramOn = true;
            User currentUser = new User();
            Bank ourBank = new Bank("The best bank in the world");
            Console.WriteLine($"Welcome to {ourBank.Name}!");

            //make sure user enters a valid option
            while (ProgramOn)
            {
                Console.WriteLine("How may we help you today?\n");
                Console.Write("Press 1 to check an existing account(s).\nPress 2 to open a savings account.\nPress 3 to open a checking account.\nPress 4 to open both.");
                Console.WriteLine("\nPress 0 to exit.");
                Console.Write("Selection: ");
                choice = int.Parse(Console.ReadLine());

                while (choice < -1 || choice > 4)
                {
                    Console.WriteLine("Invalid option, please try again: ");
                    choice = Convert.ToInt16(Console.ReadLine());
                }

                //if user wants to open account(s)
                if (choice >= 2 && choice <= 4)
                {
                    Console.WriteLine("\nThank you, please proceed.");
                    Console.WriteLine("Please enter a username to open the account with:");
                    username = Console.ReadLine();

                    ourBank.AddUser(username);
                    ourBank.AllUsers[0].CreateAccount(choice);

                    Console.WriteLine("Account(s) successfully created.");
                    currentUser = ourBank.AllUsers.Find(user => user.Name == username);
                    Console.WriteLine($"Current user: {currentUser.Name}\n");
                    choice = -1;
                }

                //looping code to manage existing account
                while (choice == 1)
                {
                    Console.WriteLine("\nWhat would you like to do?\nPress 1 to access your Savings Account.\nPress 2 to access your Checking Account.\nPress 0 to exit.");
                    accountSelection = Convert.ToInt16(Console.ReadLine());

                    if (accountSelection == 1)
                    {
                        if (currentUser.ActiveSavingsAccount == true)
                        {
                            Console.WriteLine($"Your savings account currently has {currentUser.SavingsAccount.getBalance()}");
                            Console.WriteLine("To calculate your future interest, please enter a number of years: ");
                            double years = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Your total balance in {years} years will be: {currentUser.SavingsAccount.CalculateInterest(years)}");
                        }
                        else
                        {
                            Console.WriteLine("You do not currently have a savings account.");
                        }

                        accountSelection = -1;
                    }

                    else if (accountSelection == 2)
                    {

                        if (currentUser.ActiveCheckingAccount && currentUser.CheckingAccount.status)
                        {
                            int depositOrWithdraw;
                            Console.WriteLine($"Your checking account currently has {currentUser.CheckingAccount.getBalance()}");
                            Console.WriteLine("To make a deposit, enter 1. To make a withdrawal, enter 2. To exit, enter 0.");
                            depositOrWithdraw = Convert.ToInt16(Console.ReadLine());

                            if (depositOrWithdraw == 1)
                            {
                                Console.WriteLine("Enter deposit amount:");
                                double depositAmount = Convert.ToDouble(Console.ReadLine());
                                currentUser.CheckingAccount.deposit(depositAmount);
                            }

                            else if (depositOrWithdraw == 2)
                            {
                                Console.WriteLine("Enter withdrawal amount:");
                                double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                                currentUser.CheckingAccount.withdraw(withdrawalAmount);
                            }

                            else if (depositOrWithdraw == 0)
                            { accountSelection = -1; }


                        }
                        else
                        {
                            Console.WriteLine("You do not currently have a checking account or it is closed.");
                        }
                    }

                    else if (accountSelection == 0)
                    {
                        choice = 0;
                    }
                }
                //if user selects 0, exit bank
                if (choice == 0)
                {
                    ProgramOn = false;
                }
            }
            Console.WriteLine("Thank you, have a nice day.");
        }
    }
}
