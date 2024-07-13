using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.bankAccount
{
    public class BankAccount
    {
        public string AccountName;  //Instance member
        public decimal Balance;  //Instance member
        public static decimal InterestRate; // Shared meber
    }
}