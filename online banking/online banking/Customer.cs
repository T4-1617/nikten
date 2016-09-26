using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_Banking
{


    public class RandomGenerator
    {

        public RandomGenerator()
        {
        }

        public System.Random randomGen = new System.Random();


        private long genAccountID(System.Collections.ArrayList customers)
        {
            long random = 0;
            bool uniqueID = false;
            while (uniqueID == false)
            {
                random = randomGen.Next(10000000, 99999999);
                uniqueID = true;

                foreach (Customer cus in customers)
                {
                    foreach (Account acc in cus.accounts)
                    {
                        if (acc.AccountNumber == random)
                            uniqueID = false;
                    }
                }
            }
            return random;
        }


    }


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

        private double Money { get; set; }
        private System.Collections.ArrayList transactions = new System.Collections.ArrayList();

        public long AccountNumber { get; set; }
        public void addTransaction(double value, string information)
        {
            Transaction t = new Transaction(value, information);
            this.Money += value;
            transactions.Add(t);
        }


        public System.Collections.ArrayList getTransactionsList()
        {
            return transactions;
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

        public override string ToString()
        {
            return String.Format("{0}: {1}", information, money.ToString());
        }

        public double money { get; set; }
        public string information { get; set; }
    }
}
