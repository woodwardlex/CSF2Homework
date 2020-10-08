using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //field

        //props
        public int AccountNumber { get; set; }
        public List<Customer> ContactInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //ctor
        public CreditCardAccount(int accountNumber, List<Customer> contactInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            ContactInfo = contactInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount() { }

        //methods
        public override string ToString()
        {
            string customers = "";

            foreach (Customer c in ContactInfo)
            {
                customers += c + "";
            }

            return string.Format("{0}\n" +
                "Account Number: {1}\n" +
                "Balance: {2}\n" +
                "Is the bill past due? {3}\n" +
                "Annual Interest Rate: {4}",
                ContactInfo, AccountNumber, Balance, IsPastDue, AnnualInterestRate);
        }
    }
}
