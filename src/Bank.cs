using System;
using System.Collections.Generic;
namespace BankingApplication
{
    public class Bank
    {
        public string Name; //Bank Name
        public List<User> AllUsers; //Stores all bank users

        //property to add users
        public void AddUser(string userName)
        {
            this.AllUsers.Add(new User() { Name = userName });
        }

        //constructor to set the bank's name
        public Bank(string bankName = " The bank")
        {
            this.Name = bankName;
            this.AllUsers = new List<User>();
        }
    }
}