using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankingProblem
{
    internal class Account
    {
        private string accNum;
        private string custName;
        private double balance = 0;

        public Account()
        {
            balance = balance;
        }

        public Account(string accNum, string custName)
        {
            AccountName = accNum;
            custName = custName;
        }

        public string AccountName
        {
            set
            {
                accNum = value;
            }
            get
            {
                return accNum;
            }
        }

        public string CustName
        {
            set
            {
                custName = value;
            }
            get
            {
                return custName;
            }
        }
        public double Balance { private set; get; }

        
        
        
        
        
        
        
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }

        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
        
    
}
}
