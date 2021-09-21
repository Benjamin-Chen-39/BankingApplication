using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string username;
            bool ProgramOn = true;
            User currentUser = new User();
            Bank ourBank = new Bank("The best bank in the world");
            Console.WriteLine($"Welcome to {ourBank.Name}!");
            Console.WriteLine("How may we help you today?\n");
            Console.Write("Press 1 to check your existing account.\nPress 2 to open a savings account.\nPress 3 to open a checking account.\nPress 4 to open both.");
            Console.WriteLine("\nPress 0 to exit.");
            Console.Write("Selection: ");
            choice = int.Parse(Console.ReadLine());

            //make sure user enters a valid option
            while (ProgramOn)
            {
                while (choice < 0 || choice > 4)
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
                }

                //test code
                double test = ourBank.AllUsers[0].SavingsAccount.CalculateInterest(10);
                Console.WriteLine($"Test: {test}");

                //looping code to work with existing account
                ////


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
