﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Account : IAccount
    {
        public IPerson Owner { get; set; }

        public string ID { get; set; }
        public double Balance { get; set; }
        public double Loan { get; set; }

        public void RequestLoan(double amount)
        {
            //Bank.Instance
        }
    }
}