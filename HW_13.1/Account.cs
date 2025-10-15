using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13._1
{
    class Account
    {
        private string accountName;
        private double balance;

        //get set
        public string AccountName
        {
            get { return accountName; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The initial balance cannot be less than 0!");
                balance = value;
            }
        }
        //Constructor
        public Account(string accountName, double balance)
        {
            this.accountName = accountName;
            if(balance < 0)
                throw new ArgumentException("The initial balance cannot be less than 0!");

            this.balance = balance;

        }

        //Class behavior
        public void Withdrawal(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("It isn't possible to deposit a negative amount!");
                return;
            }
            if(balance - amount < 0)
            {
                Console.WriteLine("There are not enough funds in the account!");
                return;
            }
            balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("It isn't possible to deposit a negative amount!");
                return;
            }
            balance += amount;
        }

    }
}
