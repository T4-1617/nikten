using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_Banking
{


    public class Customer
    {

        public Customer(string fName, string lName, int startCap)
        {
            this.fName = fName;
            this.lName = lName;
            createAccount(startCap, 1337);
        }

        private string fName { get; set; }
        private string lName { get; set; }


        public System.Collections.ArrayList accounts = new System.Collections.ArrayList();

        public System.Collections.ArrayList getAccounts()
        {
            return accounts;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", fName, lName);
        }


        public bool createAccount(double initDeposit, long randomAccountNumber)
        {
            if (initDeposit >= 500)
            {
                accounts.Add(new Account(initDeposit, randomAccountNumber));
                return true;
            }
            else
                return false;
        }
    }





    public class Account
    {
        public Account(double Money, long AccountNumber)
        {
            this.Money = Money;
            this.AccountNumber = AccountNumber;
        }

        public bool isComplete = false;

        public double Money { get; set; }
        public System.Collections.ArrayList transactions = new System.Collections.ArrayList();

        public long AccountNumber { get; set; }
        public void addTransaction(double value, string information)
        {
            Transaction t = new Transaction(value, information);
            transactions.Add(t);
        }


        public override string ToString()
        {
            return string.Format("{0}", AccountNumber);
        }

        public double getMoney()
        {
            return Money;
        }

    }


    public class Transaction
    {
        public Transaction(double money, string information)
        {
            this.money = money;
            this.information = information;
        }

        public double money { get; set; }
        public string information { get; set; }
    }
}
